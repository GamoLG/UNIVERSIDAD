/* Procedimiento para insertar/actualizar Asignaturas */
IF OBJECT_ID('spu_AsignaturaInsertUpdate', 'P') IS NOT NULL
    DROP PROCEDURE spu_AsignaturaInsertUpdate;
go

create procedure spu_AsignaturaInsertUpdate @Cod_Asignatura varchar(8), 
                                            @Nombre_Asignatura varchar(40),
                                            @Categoria varchar(4), @Creditos int
as
begin
  -- Verificar si código ya existe
  if Exists (select Cod_Asignatura from Asignatura where Cod_Asignatura = @Cod_Asignatura)
    -- Actualizar datos
	update Asignatura
	  set Cod_Asignatura = @Cod_Asignatura,
	      Nombre_Asignatura = @Nombre_Asignatura,
		  Categoria = @Categoria,
		  Creditos = @Creditos		  
	  where Cod_Asignatura = @Cod_Asignatura
  else
    -- Insertar datos
	insert into Asignatura
      values(@Cod_Asignatura, @Nombre_Asignatura, @Categoria, @Creditos);
end;
go

/* Procedimiento para elimnar Asignaturas */
IF OBJECT_ID('spu_AsignaturaDelete', 'P') IS NOT NULL
    DROP PROCEDURE spu_AsignaturaDelete;
go

create procedure spu_AsignaturaDelete @Cod_Asignatura varchar(8)
as
begin
  -- Actualizar datos
  delete from Asignatura
    where Cod_Asignatura = @Cod_Asignatura
end;
go

/* Procedimiento para recuperar Asignaturas */
IF OBJECT_ID('spu_AsignaturasSelect', 'P') IS NOT NULL
    DROP PROCEDURE spu_AsignaturasSelect;
go

create procedure spu_AsignaturasSelect @Cod_Asignatura varchar(8) = '*'
as
begin
  select Cod_Asignatura, Nombre_Asignatura, Categoria, Creditos
    from Asignatura              
	where (@Cod_Asignatura = '*') or (@Cod_Asignatura = Cod_Asignatura)
end;
go

