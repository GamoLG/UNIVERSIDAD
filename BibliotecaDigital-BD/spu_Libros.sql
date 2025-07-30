/* Procedimiento para insertar/actualizar Libros */
IF OBJECT_ID('spu_LibroInsertUpdate', 'P') IS NOT NULL
    DROP PROCEDURE spu_LibroInsertUpdate;
GO

CREATE PROCEDURE spu_LibroInsertUpdate 
    @Cod_Libro VARCHAR(10), 
    @Titulo VARCHAR(100),
    @Autor VARCHAR(100),
    @Editorial VARCHAR(50) = NULL,
    @Anio_Publicacion INT = NULL,
    @ISBN VARCHAR(20) = NULL,
    @Categoria VARCHAR(30) = NULL,
    @Stock_Total INT = 1
AS
BEGIN
    -- Verificar si código ya existe
    IF EXISTS (SELECT Cod_Libro FROM Libro WHERE Cod_Libro = @Cod_Libro)
        -- Actualizar datos
        UPDATE Libro
        SET Titulo = @Titulo,
            Autor = @Autor,
            Editorial = @Editorial,
            Anio_Publicacion = @Anio_Publicacion,
            ISBN = @ISBN,
            Categoria = @Categoria,
            Stock_Total = @Stock_Total,
            Stock_Disponible = Stock_Disponible + (@Stock_Total - Stock_Total)
        WHERE Cod_Libro = @Cod_Libro
    ELSE
        -- Insertar datos
        INSERT INTO Libro
        VALUES(@Cod_Libro, @Titulo, @Autor, @Editorial, @Anio_Publicacion, 
               @ISBN, @Categoria, @Stock_Total, @Stock_Total);
END;
GO

/* Procedimiento para eliminar Libros */
IF OBJECT_ID('spu_LibroDelete', 'P') IS NOT NULL
    DROP PROCEDURE spu_LibroDelete;
GO

CREATE PROCEDURE spu_LibroDelete @Cod_Libro VARCHAR(10)
AS
BEGIN
    -- Solo permitimos eliminar si no hay préstamos activos
    IF NOT EXISTS (SELECT 1 FROM Prestamo WHERE Cod_Libro = @Cod_Libro AND Estado = 'Prestado')
        DELETE FROM Libro
        WHERE Cod_Libro = @Cod_Libro
    ELSE
        RAISERROR('No se puede eliminar el libro porque tiene préstamos activos.', 16, 1)
END;
GO

/* Procedimiento para recuperar Libros */
IF OBJECT_ID('spu_LibrosSelect', 'P') IS NOT NULL
    DROP PROCEDURE spu_LibrosSelect;
GO

CREATE PROCEDURE spu_LibrosSelect 
    @Cod_Libro VARCHAR(10) = '*',
    @Disponibles BIT = 0
AS
BEGIN
    SELECT Cod_Libro, Titulo, Autor, Editorial, Anio_Publicacion, 
           ISBN, Categoria, Stock_Total, Stock_Disponible
    FROM Libro              
    WHERE (@Cod_Libro = '*' OR @Cod_Libro = Cod_Libro) AND
          (@Disponibles = 0 OR Stock_Disponible > 0)
    ORDER BY Titulo
END;
GO