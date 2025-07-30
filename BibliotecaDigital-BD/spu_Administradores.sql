/* Procedimiento para insertar/actualizar Administradores */
IF OBJECT_ID('spu_AdministradorInsertUpdate', 'P') IS NOT NULL
    DROP PROCEDURE spu_AdministradorInsertUpdate;
GO

CREATE PROCEDURE spu_AdministradorInsertUpdate 
    @Cod_Admin VARCHAR(8), 
    @Nombre VARCHAR(50),
    @Apellido VARCHAR(50),
    @Usuario VARCHAR(30),
    @Contrasena VARCHAR(100)
AS
BEGIN
    -- Verificar si código ya existe
    IF EXISTS (SELECT Cod_Admin FROM Administrador WHERE Cod_Admin = @Cod_Admin)
        -- Actualizar datos
        UPDATE Administrador
        SET Nombre = @Nombre,
            Apellido = @Apellido,
            Usuario = @Usuario,
            Contrasena = @Contrasena
        WHERE Cod_Admin = @Cod_Admin
    ELSE
        -- Insertar datos
        INSERT INTO Administrador
        VALUES(@Cod_Admin, @Nombre, @Apellido, @Usuario, @Contrasena);
END;
GO

/* Procedimiento para eliminar Administradores */
IF OBJECT_ID('spu_AdministradorDelete', 'P') IS NOT NULL
    DROP PROCEDURE spu_AdministradorDelete;
GO

CREATE PROCEDURE spu_AdministradorDelete @Cod_Admin VARCHAR(8)
AS
BEGIN
    DELETE FROM Administrador
    WHERE Cod_Admin = @Cod_Admin
END;
GO

/* Procedimiento para recuperar Administradores */
IF OBJECT_ID('spu_AdministradoresSelect', 'P') IS NOT NULL
    DROP PROCEDURE spu_AdministradoresSelect;
GO

CREATE PROCEDURE spu_AdministradoresSelect @Cod_Admin VARCHAR(8) = '*'
AS
BEGIN
    SELECT Cod_Admin, Nombre, Apellido, Usuario
    FROM Administrador              
    WHERE (@Cod_Admin = '*') OR (@Cod_Admin = Cod_Admin)
END;
GO

/* Procedimiento para login de Administrador */
IF OBJECT_ID('spu_AdministradorLogin', 'P') IS NOT NULL
    DROP PROCEDURE spu_AdministradorLogin;
GO

CREATE PROCEDURE spu_AdministradorLogin 
    @Usuario VARCHAR(30),
    @Contrasena VARCHAR(100)
AS
BEGIN
    SELECT Cod_Admin, Nombre, Apellido, Usuario
    FROM Administrador              
    WHERE Usuario = @Usuario AND Contrasena = @Contrasena
END;
GO