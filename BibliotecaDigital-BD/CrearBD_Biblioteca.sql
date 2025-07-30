/* 
** CrearBD_Biblioteca.sql
** Script para crear la base de datos de la biblioteca digital
*/

/* ********************************************************************
                    CREACION DE LA BASE DE DATOS
   ******************************************************************** */
CREATE DATABASE BD_Biblioteca_Digital   
  ON
  (NAME = Biblioteca_Digital,           -- Primary data file
  FILENAME = 'C:\Data\Biblioteca_Digital.mdf',
  SIZE = 5MB,
  MAXSIZE = 20MB,
  FILEGROWTH = 5MB
  )  
  LOG ON
  (NAME = Biblioteca_Digital_Log,       -- Log file
  FILENAME = 'C:\Data\Biblioteca_Digital.ldf',
  SIZE = 5MB,
  MAXSIZE = 20MB,
  FILEGROWTH = 2MB
  )
GO

/* ********************************************************************
                    CREACION DE TIPOS
   ******************************************************************** */
USE BD_Biblioteca_Digital   

EXEC  sp_addtype  TCod_Lector,      'varchar(6)', 'not null'
EXEC  sp_addtype  TCod_Admin,       'varchar(8)', 'not null'
EXEC  sp_addtype  TCod_Libro,       'varchar(10)', 'not null'
EXEC  sp_addtype  TFecha,           'date', 'not null'

GO

/* ********************************************************************
                    CREACION DE TABLAS
   ******************************************************************** */
-- Tabla para administradores
CREATE TABLE Administrador
(
    Cod_Admin         TCod_Admin,
    Nombre            VARCHAR(50)     NOT NULL,
    Apellido          VARCHAR(50)     NOT NULL,
    Usuario           VARCHAR(30)     NOT NULL UNIQUE,
    Contrasena        VARCHAR(100)    NOT NULL,
    PRIMARY KEY (Cod_Admin)
)

-- Tabla para lectores
CREATE TABLE Lector
(
    Cod_Lector        TCod_Lector,
    Nombre            VARCHAR(50)     NOT NULL,
    Apellido          VARCHAR(50)     NOT NULL,
    DNI               VARCHAR(8)      NOT NULL UNIQUE,
    Telefono          VARCHAR(15)     NULL,
    Email             VARCHAR(100)    NULL,
    Fecha_Registro    TFecha          DEFAULT GETDATE(),
    Estado            VARCHAR(10)     DEFAULT 'Activo' 
                      CHECK (Estado IN ('Activo', 'Inactivo', 'Suspendido')),
    PRIMARY KEY (Cod_Lector)
)

-- Tabla para libros
CREATE TABLE Libro
(
    Cod_Libro         TCod_Libro,
    Titulo            VARCHAR(100)    NOT NULL,
    Autor             VARCHAR(100)    NOT NULL,
    Editorial         VARCHAR(50)     NULL,
    Anio_Publicacion  INT             NULL,
    ISBN              VARCHAR(20)     NULL UNIQUE,
    Categoria         VARCHAR(30)     NULL,
    Stock_Total       INT             NOT NULL DEFAULT 1,
    Stock_Disponible  INT             NOT NULL DEFAULT 1,
    PRIMARY KEY (Cod_Libro)
)

-- Tabla para préstamos
CREATE TABLE Prestamo
(
    Id_Prestamo       INT             IDENTITY(1,1),
    Cod_Lector        TCod_Lector     NOT NULL,
    Cod_Libro         TCod_Libro      NOT NULL,
    Cod_Admin         TCod_Admin      NOT NULL,
    Fecha_Prestamo    TFecha          DEFAULT GETDATE(),
    Fecha_Devolucion  TFecha          NULL,
    Estado            VARCHAR(15)     DEFAULT 'Prestado' 
                      CHECK (Estado IN ('Prestado', 'Devuelto', 'Retrasado', 'Perdido')),
    PRIMARY KEY (Id_Prestamo),
    FOREIGN KEY (Cod_Lector) REFERENCES Lector(Cod_Lector),
    FOREIGN KEY (Cod_Libro) REFERENCES Libro(Cod_Libro),
    FOREIGN KEY (Cod_Admin) REFERENCES Administrador(Cod_Admin)
)

-- Tabla para historial de préstamos (podría ser una vista también)
CREATE TABLE Historial_Prestamos
(
    Id_Historial      INT             IDENTITY(1,1),
    Cod_Lector        TCod_Lector     NOT NULL,
    Cod_Libro         TCod_Libro      NOT NULL,
    Fecha_Prestamo    TFecha          NOT NULL,
    Fecha_Devolucion  TFecha          NULL,
    Estado            VARCHAR(15)     NOT NULL,
    PRIMARY KEY (Id_Historial),
    FOREIGN KEY (Cod_Lector) REFERENCES Lector(Cod_Lector),
    FOREIGN KEY (Cod_Libro) REFERENCES Libro(Cod_Libro)
)

GO