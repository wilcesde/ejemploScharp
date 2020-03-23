use ejinstitucion

create table tipo_personas_test(
	id int primary key,
	nombre_tipo varchar(10) not null
)

/*---------------------------------------------------*/
create proc regTipoPersonasTest(
	@id int,
	@nombre_tipo varchar(10)
)
as insert into tipo_personas_test values (@id, @nombre_tipo)

exec regTipoPersonasTest '1','Estudent'
exec regTipoPersonasTest '2','Teacher'

select * from tipo_personas_test


/*-----------------------------------------------*/
create proc ActTipoPersonasTest(
	@id int,
	@nombre_tipo varchar(10)
)
as Update tipo_personas_test set nombre_tipo=@nombre_tipo where id=@id

exec ActTipoPersonasTest '2','Profesor'


/*----------------------------------------------------*/
create proc DelTipoPersonasTest(
	@id int
)
as delete from tipo_personas_test where id=@id

exec DelTipoPersonasTest 1


/*---------------------------------------------------------*/
/*---------------------------------------------------------*/
/*---------------------------------------------------------*/

