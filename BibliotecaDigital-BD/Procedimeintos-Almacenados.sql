-- 1. Obtener lectores activos
CREATE PROCEDURE spu_LectoresActivosSelect
AS
BEGIN
    SELECT 
        Cod_Lector, 
        Nombre + ' ' + Apellido AS NombreCompleto,
        DNI
    FROM Lector
    WHERE Estado = 'Activo'
    ORDER BY Apellido, Nombre;
END;

-- 2. Obtener libros disponibles
CREATE PROCEDURE spu_LibrosDisponiblesSelect
AS
BEGIN
    SELECT 
        Cod_Libro, 
        Titulo + ' - ' + Autor AS TituloAutor,
        Stock_Disponible
    FROM Libro
    WHERE Stock_Disponible > 0
    ORDER BY Titulo;
END;

-- 3. Obtener administradores
CREATE PROCEDURE spu_AdministradoresSelect
AS
BEGIN
    SELECT 
        Cod_Admin,
        Nombre + ' ' + Apellido AS NombreCompleto,
        Usuario
    FROM Administrador
    ORDER BY Apellido, Nombre;
END;

-- 4. Registrar nuevo préstamo
CREATE PROCEDURE spu_PrestamoInsert
    @Cod_Lector VARCHAR(6),
    @Cod_Libro VARCHAR(10),
    @Cod_Admin VARCHAR(8)
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;
        
        -- Verificar disponibilidad
        IF NOT EXISTS (SELECT 1 FROM Libro WHERE Cod_Libro = @Cod_Libro AND Stock_Disponible > 0)
            RAISERROR('No hay ejemplares disponibles de este libro', 16, 1);
            
        -- Registrar préstamo
        INSERT INTO Prestamo (Cod_Lector, Cod_Libro, Cod_Admin, Estado)
        VALUES (@Cod_Lector, @Cod_Libro, @Cod_Admin, 'Prestado');
        
        -- Actualizar stock
        UPDATE Libro SET Stock_Disponible = Stock_Disponible - 1 
        WHERE Cod_Libro = @Cod_Libro;
        
        -- Registrar en historial
        INSERT INTO Historial_Prestamos (Cod_Lector, Cod_Libro, Fecha_Prestamo, Estado)
        VALUES (@Cod_Lector, @Cod_Libro, GETDATE(), 'Prestado');
        
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;

-- 5. Obtener préstamos activos
CREATE PROCEDURE spu_PrestamosActivosSelect
AS
BEGIN
    SELECT 
        P.Id_Prestamo,
        L.Nombre + ' ' + L.Apellido AS Lector,
        Li.Titulo AS Libro,
        CONVERT(VARCHAR, P.Fecha_Prestamo, 103) AS Fecha_Prestamo,
        DATEDIFF(DAY, P.Fecha_Prestamo, GETDATE()) AS Dias_Transcurridos
    FROM Prestamo P
    INNER JOIN Lector L ON P.Cod_Lector = L.Cod_Lector
    INNER JOIN Libro Li ON P.Cod_Libro = Li.Cod_Libro
    WHERE P.Estado = 'Prestado'
    ORDER BY P.Fecha_Prestamo DESC;
END;