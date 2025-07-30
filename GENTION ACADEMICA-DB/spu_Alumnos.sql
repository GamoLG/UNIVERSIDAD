/* Procedimiento para insertar/actualizar Alumnos */
IF OBJECT_ID('spu_AlumnoInsertUpdate', 'P') IS NOT NULL
    DROP PROCEDURE spu_AlumnoInsertUpdate;
go

create procedure spu_AlumnoInsertUpdate @Cod_Alumno varchar(6), @Paterno varchar(15),
                                        @Materno varchar(15), @Nombres varchar(15),
										@Cod_EP varchar(2)
as
begin
  -- Verificar si código ya existe
  if Exists (select Cod_Alumno from Alumno where Cod_Alumno = @Cod_Alumno)
    -- Actualizar datos
	update Alumno
	  set Cod_Alumno = @Cod_Alumno,
	      Paterno = @Paterno,
		  Materno = @Materno,
		  Nombres = @Nombres,
		  Cod_EP = @Cod_EP
	  where Cod_Alumno = @Cod_Alumno
  else
    -- Insertar datos
	insert into Alumno
      values(@Cod_Alumno, @Paterno, @Materno, @Nombres, @Cod_EP);
end;
go

/* Procedimiento para elimnar Alumnos */
IF OBJECT_ID('spu_AlumnoDelete', 'P') IS NOT NULL
    DROP PROCEDURE spu_AlumnoDelete;
go

create procedure spu_AlumnoDelete @Cod_Alumno varchar(6)
as
begin
  -- Actualizar datos
  delete from Alumno
    where Cod_Alumno = @Cod_Alumno
end;
go

/* Procedimiento para recuperar Alumnos */
IF OBJECT_ID('spu_AlumnosSelect', 'P') IS NOT NULL
    DROP PROCEDURE spu_AlumnosSelect;
go

create procedure spu_AlumnosSelect @Cod_Alumno varchar(6) = '*'
as
begin
  select Cod_Alumno, Paterno, Materno, Nombres, Cod_EP
    from Alumno              
	where (@Cod_Alumno = '*') or (@Cod_Alumno = Cod_Alumno)
end;
go

