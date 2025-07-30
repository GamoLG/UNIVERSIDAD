/* Procedimiento para insertar/actualizar Lectores */
IF OBJECT_ID('spu_LectorInsertUpdate', 'P') IS NOT NULL
    DROP PROCEDURE spu_LectorInsertUpdate;
GO

CREATE PROCEDURE spu_LectorInsertUpdate 
    @Cod_Lector VARCHAR(6), 
    @Nombre VARCHAR(50),
    @Apellido VARCHAR(50),
    @DNI VARCHAR(8),
    @Telefono VARCHAR(15) = NULL,
    @Email VARCHAR(100) = NULL,
    @Estado VARCHAR(10) = 'Activo'
AS
BEGIN
    -- Verificar si código ya existe
    IF EXISTS (SELECT Cod_Lector FROM Lector WHERE Cod_Lector = @Cod_Lector)
        -- Actualizar datos
        UPDATE Lector
        SET Nombre = @Nombre,
            Apellido = @Apellido,
            DNI = @DNI,
            Telefono = @Telefono,
            Email = @Email,
            Estado = @Estado
        WHERE Cod_Lector = @Cod_Lector
    ELSE
        -- Insertar datos
        INSERT INTO Lector (Cod_Lector, Nombre, Apellido, DNI, Telefono, Email, Estado)
        VALUES(@Cod_Lector, @Nombre, @Apellido, @DNI, @Telefono, @Email, @Estado);
END;
GO

/* Procedimiento para eliminar Lectores */
IF OBJECT_ID('spu_LectorDelete', 'P') IS NOT NULL
    DROP PROCEDURE spu_LectorDelete;
GO

CREATE PROCEDURE spu_LectorDelete @Cod_Lector VARCHAR(6)
AS
BEGIN
    -- No eliminamos físicamente, cambiamos el estado
    UPDATE Lector
    SET Estado = 'Inactivo'
    WHERE Cod_Lector = @Cod_Lector
END;
GO

/* Procedimiento para recuperar Lectores */
IF OBJECT_ID('spu_LectoresSelect', 'P') IS NOT NULL
    DROP PROCEDURE spu_LectoresSelect;
GO

CREATE PROCEDURE spu_LectoresSelect @Cod_Lector VARCHAR(6) = '*'
AS
BEGIN
    SELECT Cod_Lector, Nombre, Apellido, DNI, Telefono, Email, 
           CONVERT(VARCHAR, Fecha_Registro, 103) AS Fecha_Registro, Estado
    FROM Lector              
    WHERE (@Cod_Lector = '*') OR (@Cod_Lector = Cod_Lector)
    ORDER BY Apellido, Nombre
END;
GO