/* 
** CREABASE.SQL
**

*/

/* ********************************************************************
                        CREACION DE LA BASE DE DATOS
   ******************************************************************** */
CREATE DATABASE BD_Gestion_Academica   
  ON
  (NAME = Gestion_Academica,           -- Primary data file
  FILENAME = 'D:\Data\Gestion_Academica.mdf',
  SIZE = 5MB,
  MAXSIZE = 20MB,
  FILEGROWTH = 5MB
  )  
  LOG ON
  (NAME = Gestion_Academica_Log,       -- Log file
  FILENAME = 'D:\Data\Gestion_Academica.ldf',
  SIZE = 5MB,
  MAXSIZE = 20MB,
  FILEGROWTH = 2MB
  )
GO

/* ********************************************************************
                        CREACION DE TIPOS
   ******************************************************************** */
USE BD_Gestion_Academica   

EXEC  sp_addtype  TCod_EP,         'varchar(2)', 'not null'
EXEC  sp_addtype  TCod_Alumno,     'varchar(6)', 'not null'
EXEC  sp_addtype  TCod_Asignatura, 'varchar(8)', 'not null'
EXEC  sp_addtype  TSemestre,       'varchar(7)', 'not null'

GO

/* ********************************************************************
                        CREACION DE TABLAS
   ******************************************************************** */
create table Escuela_Profesional
  (
    Cod_EP              TCod_EP,
    Nombre_EP           varchar(40)         null,
    Primary key (Cod_EP)
  )

create table Alumno
  (
    Cod_Alumno          TCod_Alumno,
    Paterno             Varchar(15)       not null,
    Materno             Varchar(15)       not null,
    Nombres             Varchar(15)       not null,
    Cod_EP              TCod_EP,
    Primary key (Cod_Alumno),
    Foreign key (Cod_EP) references Escuela_Profesional(Cod_EP)
  )

create table Asignatura
  (
    Cod_Asignatura      TCod_Asignatura,    
    Nombre_Asignatura   Varchar(80)       not null,
    Categoria           Varchar(4)        default 'OE'
                        Check (Categoria in ('OE','EE','EG','PPP','SEM')),
    Creditos            Integer           default 4
                        Check (Creditos > 0),
    Primary key (Cod_Asignatura)
  )

create table Matricula
  (
    Semestre            TSemestre,
    Cod_Asignatura      TCod_Asignatura,
    Cod_Alumno          TCod_Alumno,
    Nota                Varchar(3)        default 'NSP'
                        Check (Nota in ('NSP','00',
                                        '01','02','03','04','05','06','07','08','09','10',
                                        '11','12','13','14','15','16','17','18','19','20')),
    Primary key (Semestre,Cod_Asignatura,Cod_Alumno),
    Foreign key (Cod_Asignatura) references Asignatura(Cod_Asignatura),
    Foreign key (Cod_Alumno) references Alumno(Cod_Alumno)
  )

GO
