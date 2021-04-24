use DB7CV23
go 

create procedure sp_RegresarDatos(@id_alu smallint, @tipOper smallint)
as
begin
	if @tipOper = 1
	begin 
		select * from Alumnos where id_alu = @id_alu; 
	end
	else
	begin
		select * from Alumnos;
	end
end;