/* Procedimiento para registrar un préstamo */
IF OBJECT_ID('spu_PrestamoInsert', 'P') IS NOT NULL
    DROP PROCEDURE spu_PrestamoInsert;
GO

CREATE PROCEDURE spu_PrestamoInsert 
    @Cod_Lector VARCHAR(6),
    @Cod_Libro VARCHAR(10),
    @Cod_Admin VARCHAR(8)
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;
        
        -- Verificar si el lector está activo
        IF NOT EXISTS (SELECT 1 FROM Lector WHERE Cod_Lector = @Cod_Lector AND Estado = 'Activo')
            RAISERROR('El lector no está activo para realizar préstamos.', 16, 1);
            
        -- Verificar si hay stock disponible
        IF NOT EXISTS (SELECT 1 FROM Libro WHERE Cod_Libro = @Cod_Libro AND Stock_Disponible > 0)
            RAISERROR('No hay ejemplares disponibles de este libro.', 16, 1);
            
        -- Registrar el préstamo
        INSERT INTO Prestamo (Cod_Lector, Cod_Libro, Cod_Admin, Estado)
        VALUES(@Cod_Lector, @Cod_Libro, @Cod_Admin, 'Prestado');
        
        -- Actualizar el stock disponible
        UPDATE Libro
        SET Stock_Disponible = Stock_Disponible - 1
        WHERE Cod_Libro = @Cod_Libro;
        
        -- Registrar en el historial
        INSERT INTO Historial_Prestamos (Cod_Lector, Cod_Libro, Fecha_Prestamo, Estado)
        VALUES(@Cod_Lector, @Cod_Libro, GETDATE(), 'Prestado');
        
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO

/* Procedimiento para registrar una devolución */
IF OBJECT_ID('spu_PrestamoDevolucion', 'P') IS NOT NULL
    DROP PROCEDURE spu_PrestamoDevolucion;
GO

CREATE PROCEDURE spu_PrestamoDevolucion 
    @Id_Prestamo INT
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;
        
        DECLARE @Cod_Libro VARCHAR(10);
        DECLARE @Estado VARCHAR(15);
        
        -- Obtener datos del préstamo
        SELECT @Cod_Libro = Cod_Libro, @Estado = Estado
        FROM Prestamo
        WHERE Id_Prestamo = @Id_Prestamo;
        
        -- Verificar si el préstamo existe
        IF @Cod_Libro IS NULL
            RAISERROR('El préstamo especificado no existe.', 16, 1);
            
        -- Verificar si ya fue devuelto
        IF @Estado = 'Devuelto'
            RAISERROR('Este préstamo ya fue devuelto anteriormente.', 16, 1);
            
        -- Actualizar el préstamo
        UPDATE Prestamo
        SET Fecha_Devolucion = GETDATE(),
            Estado = 'Devuelto'
        WHERE Id_Prestamo = @Id_Prestamo;
        
        -- Actualizar el stock disponible
        UPDATE Libro
        SET Stock_Disponible = Stock_Disponible + 1
        WHERE Cod_Libro = @Cod_Libro;
        
        -- Actualizar el historial
        UPDATE Historial_Prestamos
        SET Fecha_Devolucion = GETDATE(),
            Estado = 'Devuelto'
        WHERE Id_Historial = (
            SELECT MAX(Id_Historial) 
            FROM Historial_Prestamos 
            WHERE Cod_Libro = @Cod_Libro AND Estado = 'Prestado'
        );
        
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO

/* Procedimiento para recuperar Préstamos activos */
IF OBJECT_ID('spu_PrestamosActivosSelect', 'P') IS NOT NULL
    DROP PROCEDURE spu_PrestamosActivosSelect;
GO

CREATE PROCEDURE spu_PrestamosActivosSelect 
    @Cod_Lector VARCHAR(6) = '*',
    @Cod_Libro VARCHAR(10) = '*'
AS
BEGIN
    SELECT P.Id_Prestamo, P.Cod_Lector, 
           L.Nombre + ' ' + L.Apellido AS Nombre_Lector,
           P.Cod_Libro, Li.Titulo AS Titulo_Libro,
           CONVERT(VARCHAR, P.Fecha_Prestamo, 103) AS Fecha_Prestamo,
           DATEDIFF(DAY, P.Fecha_Prestamo, GETDATE()) AS Dias_Prestamo,
           P.Estado
    FROM Prestamo P
    INNER JOIN Lector L ON P.Cod_Lector = L.Cod_Lector
    INNER JOIN Libro Li ON P.Cod_Libro = Li.Cod_Libro
    WHERE P.Estado = 'Prestado' AND
          (@Cod_Lector = '*' OR P.Cod_Lector = @Cod_Lector) AND
          (@Cod_Libro = '*' OR P.Cod_Libro = @Cod_Libro)
    ORDER BY P.Fecha_Prestamo DESC
END;
GO

/* Procedimiento para recuperar Historial de Préstamos */
IF OBJECT_ID('spu_HistorialPrestamosSelect', 'P') IS NOT NULL
    DROP PROCEDURE spu_HistorialPrestamosSelect;
GO

CREATE PROCEDURE spu_HistorialPrestamosSelect 
    @Cod_Lector VARCHAR(6) = '*',
    @Cod_Libro VARCHAR(10) = '*',
    @Fecha_Inicio DATE = NULL,
    @Fecha_Fin DATE = NULL
AS
BEGIN
    SELECT H.Id_Historial, H.Cod_Lector, 
           L.Nombre + ' ' + L.Apellido AS Nombre_Lector,
           H.Cod_Libro, Li.Titulo AS Titulo_Libro,
           CONVERT(VARCHAR, H.Fecha_Prestamo, 103) AS Fecha_Prestamo,
           CONVERT(VARCHAR, H.Fecha_Devolucion, 103) AS Fecha_Devolucion,
           H.Estado,
           CASE 
               WHEN H.Fecha_Devolucion IS NOT NULL 
               THEN DATEDIFF(DAY, H.Fecha_Prestamo, H.Fecha_Devolucion)
               ELSE DATEDIFF(DAY, H.Fecha_Prestamo, GETDATE())
           END AS Dias_Prestamo
    FROM Historial_Prestamos H
    INNER JOIN Lector L ON H.Cod_Lector = L.Cod_Lector
    INNER JOIN Libro Li ON H.Cod_Libro = Li.Cod_Libro
    WHERE (@Cod_Lector = '*' OR H.Cod_Lector = @Cod_Lector) AND
          (@Cod_Libro = '*' OR H.Cod_Libro = @Cod_Libro) AND
          (@Fecha_Inicio IS NULL OR H.Fecha_Prestamo >= @Fecha_Inicio) AND
          (@Fecha_Fin IS NULL OR H.Fecha_Prestamo <= @Fecha_Fin)
    ORDER BY H.Fecha_Prestamo DESC
END;
GO

-----
--se aumento esoooooooo
-- 1. Procedimiento adicional para actualizar estado
IF OBJECT_ID('spu_ActualizarEstadoPrestamo', 'P') IS NOT NULL
    DROP PROCEDURE spu_ActualizarEstadoPrestamo;
GO

CREATE PROCEDURE spu_ActualizarEstadoPrestamo
    @Id_Prestamo INT,
    @NuevoEstado VARCHAR(15)
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;
        
        -- Validar que el préstamo existe y no está devuelto
        IF NOT EXISTS (SELECT 1 FROM Prestamo WHERE Id_Prestamo = @Id_Prestamo AND Estado <> 'Devuelto')
            RAISERROR('El préstamo no existe o ya fue devuelto', 16, 1);
            
        -- Validar estado permitido
        IF @NuevoEstado NOT IN ('Retrasado', 'Perdido')
            RAISERROR('Estado no válido para actualización', 16, 1);
        
        -- Actualizar el préstamo
        UPDATE Prestamo
        SET Estado = @NuevoEstado
        WHERE Id_Prestamo = @Id_Prestamo;
        
        -- Actualizar el historial
        UPDATE Historial_Prestamos
        SET Estado = @NuevoEstado
        WHERE Id_Historial = (
            SELECT MAX(Id_Historial) 
            FROM Historial_Prestamos 
            WHERE Cod_Libro = (SELECT Cod_Libro FROM Prestamo WHERE Id_Prestamo = @Id_Prestamo)
            AND Estado <> 'Devuelto'
        );
        
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO

----
CREATE PROCEDURE spu_HistorialPrestamosSelect
AS
BEGIN
    SELECT 
        H.Id_Historial,
        L.Cod_Lector,
        L.Nombre + ' ' + L.Apellido AS Nombre_Lector,
        Li.Cod_Libro,
        Li.Titulo AS Titulo_Libro,
        CONVERT(VARCHAR, H.Fecha_Prestamo, 103) AS Fecha_Prestamo,
        CONVERT(VARCHAR, H.Fecha_Devolucion, 103) AS Fecha_Devolucion,
        H.Estado,
        CASE 
            WHEN H.Fecha_Devolucion IS NOT NULL 
            THEN DATEDIFF(DAY, H.Fecha_Prestamo, H.Fecha_Devolucion)
            ELSE DATEDIFF(DAY, H.Fecha_Prestamo, GETDATE())
        END AS Dias_Prestamo
    FROM Historial_Prestamos H
    INNER JOIN Lector L ON H.Cod_Lector = L.Cod_Lector
    INNER JOIN Libro Li ON H.Cod_Libro = Li.Cod_Libro
    ORDER BY H.Fecha_Prestamo DESC
END