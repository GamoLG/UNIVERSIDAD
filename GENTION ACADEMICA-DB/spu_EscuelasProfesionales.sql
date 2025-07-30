/* Procedimiento para insertar/actualizar Escuelas */
IF OBJECT_ID('spu_EscuelaInsertUpdate', 'P') IS NOT NULL
    DROP PROCEDURE spu_EscuelaInsertUpdate;
go

create procedure spu_EscuelaInsertUpdate @Cod_EP varchar(2), @Nombre_EP varchar(40)
as
begin
  -- Verificar si código ya existe
  if Exists (select Cod_EP from Escuela_Profesional where Cod_EP = @Cod_EP)
    -- Actualizar datos
	update Escuela_Profesional
	  set Cod_EP = @Cod_EP,
	      Nombre_EP = @Nombre_EP
	  where Cod_EP = @Cod_EP
  else
    -- Insertar datos
	insert into Escuela_Profesional
      values(@Cod_EP, @Nombre_EP);
end;
go
-- exec spu_EscuelaInsertUpdate 'CC', 'CC'

/* Procedimiento para elimnar Escuelas */
IF OBJECT_ID('spu_EscuelaDelete', 'P') IS NOT NULL
    DROP PROCEDURE spu_EscuelaDelete;
go

create procedure spu_EscuelaDelete @Cod_EP varchar(2)
as
begin
  -- Actualizar datos
  delete from Escuela_Profesional
    where Cod_EP = @Cod_EP
end;
go

/* Procedimiento para recuperar Escuelas */
IF OBJECT_ID('spu_EscuelasSelect', 'P') IS NOT NULL
    DROP PROCEDURE spu_EscuelasSelect;
go

create procedure spu_EscuelasSelect @Cod_EP varchar(2) = '*'
as
begin
  select Cod_EP, Nombre_EP
    from Escuela_Profesional              
	where (@Cod_EP = '*') or (@Cod_EP = Cod_EP)
end;
go

