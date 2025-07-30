/* Procedimiento para insertar/actualizar Matriculas */
IF OBJECT_ID('spu_MatriculaInsertUpdate', 'P') IS NOT NULL
    DROP PROCEDURE spu_MatriculaInsertUpdate;
go

create procedure spu_MatriculaInsertUpdate @Semestre varchar(7), @Cod_Asignatura varchar(8),
                                           @Cod_Alumno varchar(6), @Nota varchar(3)
as
begin
  -- Verificar si código ya existe
  if Exists (select Semestre, Cod_Asignatura, Cod_Alumno 
               from Matricula 
			   where Semestre = @Semestre and Cod_Asignatura = @Cod_Asignatura and Cod_Alumno = @Cod_Alumno)
    -- Actualizar datos
	update Matricula
	  set Nota = @Nota
	  where Semestre = @Semestre and Cod_Asignatura = @Cod_Asignatura and Cod_Alumno = @Cod_Alumno
  else
    -- Insertar datos
	insert into Matricula
      values(@Semestre, @Cod_Asignatura, @Cod_Alumno, @Nota);
end;
go

/* Procedimiento para elimnar Matriculas */
IF OBJECT_ID('spu_MatriculaDelete', 'P') IS NOT NULL
    DROP PROCEDURE spu_MatriculaDelete;
go

create procedure spu_MatriculaDelete @Semestre varchar(7), @Cod_Alumno varchar(6)
as
begin
  -- Actualizar datos
  delete from Matricula
    where Semestre = @Semestre and Cod_Alumno = @Cod_Alumno
end;
go

/* Procedimiento para recuperar Matriculas */
/* Relación de asignaturas que cursa o cursó un alumno en un semestre */
IF OBJECT_ID('spu_MatriculasSelect', 'P') IS NOT NULL
    DROP PROCEDURE spu_MatriculasSelect;
go

create procedure spu_MatriculasSelect @Semestre varchar(7) = '*', @Cod_Alumno varchar(6) = '*'
as
begin
  select Semestre, Cod_Asignatura, Cod_Alumno, Nota
    from Matricula              
	where ((@Semestre = '*') or (@Semestre = Semestre)) and 
	      ((@Cod_Alumno = '*') or (@Cod_Alumno = Cod_Alumno))
end;
go

/* Procedimiento para recuperar Matriculas */
/* Relación de alumnos que cursan o cursaron una asignatura en un semestre */
IF OBJECT_ID('spu_MatriculasAsignaturaSelect', 'P') IS NOT NULL
    DROP PROCEDURE spu_MatriculasAsignaturaSelect;
go

create procedure spu_MatriculasAsignaturaSelect @Semestre varchar(7) = '*', @Cod_Asignatura varchar(8) = '*'
as
begin
  select Semestre, Cod_Asignatura, Cod_Alumno, Nota
    from Matricula              
	where ((@Semestre = '*') or (@Semestre = Semestre)) and 
	      ((@Cod_Asignatura = '*') or (@Cod_Asignatura = Cod_Alumno))
end;
go

