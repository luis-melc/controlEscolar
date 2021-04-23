use DB7CV23
go
 select * from Alumnos order by id_alu;

 create procedure sp_ActualizaDatos(
	@id_alu smallint,
	@bol_alu nvarchar(10),
	@nom_alu nvarchar(20),
	@apa_alu nvarchar(20),
	@ama_alu nvarchar(20),
	@sex_alu nvarchar(1),
	@fnac_alu date,
	@email_alu nvarchar(50),
	@tel_alu nvarchar(10),
	@tipsan_alu smallint,
	@car_alu smallint,
	@prom_alu decimal(4,2),
	@tipOper smallint

 )
 as
 begin 
	if @tipOper = 1
	begin
		insert into Alumnos values(@bol_alu, @nom_alu, @apa_alu, @ama_alu, @sex_alu, @fnac_alu, @email_alu, @tel_alu, @tipsan_alu, @car_alu, @prom_alu);
	end
	else
	begin
		if @tipOper = 2
		begin
			update Alumnos set boleta_alu = @bol_alu, nombre_alu = @nom_alu, apa_alu = @apa_alu, ama_alu = @ama_alu, sexo_alu = @sex_alu, fnac_alu = @fnac_alu, correoe_alu = @email_alu, telcel_alu = @tel_alu, tiposan_alu = @tipsan_alu, carrera_alu = @car_alu, PROM_ALU = @prom_alu where id_alu = @id_alu;
		end
		else
		begin
			delete from Alumnos where id_alu = @id_alu;
		end
	end
end;