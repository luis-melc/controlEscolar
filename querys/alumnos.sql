use DB7CV23
go

create table Alumnos(
	id_alu smallint identity(1,1),
	boleta_alu nvarchar(10) primary key,
	nombre_alu nvarchar(30) not null,
	apa_alu nvarchar(20) not null,
	ama_alu nvarchar(20) not null,
	sexo_alu nvarchar(1) not null,
	fnac_alu date not null,
	correoe_alu nvarchar(50),
	telcel_alu nvarchar(10) not null,
	tiposan_alu smallint not null,
	carrera_alu smallint not null,
	constraint "fk_sangre" foreign key (tiposan_alu)
	references tiposangre(id_ts),
	constraint "fk_carrera" foreign key (carrera_alu)
	references carreras(id_car)
);

create table tiposangre(
	id_ts smallint identity(1,1) primary key,
	desc_ts nvarchar(3) not null
);

create table carreras(
	id_car smallint identity(1,1) primary key,
	nom_car nvarchar(70) not null
);


insert into carreras values ('Ingenieria en Sistemas');
insert into carreras values ('Licenciatura en Informatica');
insert into carreras values ('Licenciatura en Turismo');
insert into carreras values ('Ingenieria en Sistemas');

update carreras set nom_car = 'Ingenieria Botanica' where id_car = 4


insert into tiposangre values ('A+');
insert into tiposangre values ('B+');
insert into tiposangre values ('A-');
insert into tiposangre values ('B-');
insert into tiposangre values ('AB+');
insert into tiposangre values ('AB-');
insert into tiposangre values ('O+');
insert into tiposangre values ('O-');


insert into Alumnos values(
	'2000123456','JUANITO','PEREZ','GOMEZ','M','1990-02-15','juanito3@gmail.com','55565811',6,2
);

insert into Alumnos values(
	'2000123457','JUANITA','PEREIRA','GONZALES','F','1989-05-05','juanita1@hotmail.com','55565812',1,4
);

insert into Alumnos values(
	'2000123458','LUPITA','FERREIRA','GONZALES','F','2005-12-07','lupis18@gmail.com','55565813',4,3
);





insert into alumnos values (
'2017350043', 'Luna', 'Madrid', 'Zarate', 'F', '1997-01-19', 'luna@gmail.com', '5655483191', 3, 3
);

insert into Alumnos values (
'2010151213', 'MANOLITO','LOPEZ','PESCADOR','M','2001-12-01','migelitoelkiller8@gmail.com','5556158019', 4, 3
);

INSERT INTO ALUMNOS VALUES ('2015130450','SANTIAGO','GONZALEZ','SANITESTEBAN','M','1999-07-09','GONZALEZ.S@GMAIL.COM','5548798932',8,1)

insert ALUMNOS values (
'2000122542', 'MAURICIO','PEREZ', 'VILLEGAZ' ,'M', '1999-04-04','MAU_VIL@GMAIL.COM','55325423',2,1
);

INSERT INTO ALUMNOS
VALUES
(
'2013030297',
'KAKAROTO',
'FENIX',
'LOPEZ',
'M',
'1996-11-04',
'KAKAROTO@alumno.ipn.mx',
'5533112244',1,3
);

insert into Alumnos values ('2015070211','Raul', 'Celis','Mira','M','1999-05-24','raulmira@gmail.com','5429164223',1,2);

INSERT INTO ALUMNOS VALUES ('2013081313','Kevin','Ramirez','Ramirez','M','1997-07-07','keb@GMAIL.COM','5512345678',8,1)

INSERT INTO ALUMNOS
VALUES
(
'2018351121',
'YESID FERNANDO',
'GARCÍA',
'GARCÍA',
'M',
'06-07-1997',
'Ygarciag17@alumno.ipn.mx',
'5528658269',4,3
);


insert into Alumnos values('2010324535','Rafael','Perez','Quintana','M','1996-10-1','Rafa@gmail.com','554634643',2,2);

INSERT INTO ALUMNOS
VALUES ( '2018350262', 'JESSICA', 'GUZMAN', 'OLVERA', 'F', '1995-02-25', 'jguzman25@alumno.ipn.mx', '5500550055',7,3 );

insert into Alumnos values ( '2009230224', 'JUAN', 'FERRAS', 'GOMES', 'M', '1995-09-12', 'juani95@hotmail.com', '5524698742', 3, 4);


INSERT INTO ALUMNOS
VALUES
(
'2014351160',
'Oscar Osvaldo',
'Torres',
'Lopez',
'M',
'1987-04-05',
'otorresl1300@alumno.ipn.mx',
'5525439298',1,2
);

INSERT INTO Alumnos VALUES (
'2000251420', 'JUAN', 'PEREZ', 'MIRA', 'M', '1998-05-30', 'jperezm@live.com', '5555443322', 1, 2
)
INSERT INTO Alumnos VALUES (
'2000251421', 'JUAN', 'HERNANDEZ', 'HERNANDEZ', 'M', '1998-05-30', 'jhernandezh@live.com', '5555403020', 1, 2
)
INSERT INTO Alumnos VALUES (
'2000251422', 'PEDRO', 'PEREZ', 'PEREZ', 'M', '1998-05-30', 'pperezp@live.com', '5554493325', 1, 2
)
INSERT INTO Alumnos VALUES (
'2000251423', 'MARIA', 'PEREZ', 'VAZQUEZ', 'F', '1998-05-30', 'mperezv@live.com', '5550203040', 1, 2
)
INSERT INTO Alumnos VALUES (
'2000251424', 'ANA', 'VAZQUEZ', 'MORA', 'F', '1998-05-30', 'avazquezm@live.com', '5555443322', 1, 2
)
INSERT INTO Alumnos VALUES (
'2000251425', 'MARCO', 'LOPEZ', 'PEREZ', 'M', '1998-05-30', 'mlopezp@live.com', '5555493723', 1, 2
)
INSERT INTO Alumnos VALUES (
'2000251426', 'MARCOS', 'VEGA', 'HERNANDEZ', 'M', '1998-05-30', 'mvegah@live.com', '5556473891', 1, 2
)
INSERT INTO Alumnos VALUES (
'2000251427', 'PAOLA', 'HERNANDEZ', 'VELAZQUEZ', 'F', '1998-05-30', 'phernandezv@live.com', '5555918375', 1, 2
)
INSERT INTO Alumnos VALUES (
'2000251428', 'ENRIQUE', 'PEREZ', 'JIMENEZ', 'M', '1998-05-30', 'eperezj@live.com', '5555441565', 1, 2
)
INSERT INTO Alumnos VALUES (
'2000251429', 'VICTOR', 'SANCHEZ', 'JIMENEZ', 'M', '1998-05-30', 'vsanchezj@live.com', '5555164616', 1, 2
)

alter table Alumnos add PROM_ALU decimal(4,2)

update Alumnos set prom_alu = 9.5 where id_alu =1;
update Alumnos set prom_alu = 5 where id_alu = 2;
update Alumnos set prom_alu = 7.4 where id_alu = 4;
update Alumnos set prom_alu = 8.5 where id_alu = 5;
update Alumnos set prom_alu = 9.1 where id_alu = 6;
update Alumnos set prom_alu = 5.5 where id_alu = 7;
update Alumnos set prom_alu = 3.2 where id_alu = 8;
update Alumnos set prom_alu = 4.5 where id_alu = 9;
update Alumnos set prom_alu = 7.5 where id_alu = 10;
update Alumnos set prom_alu = 9.4 where id_alu = 11;
update Alumnos set prom_alu = 8.5 where id_alu = 12;
update Alumnos set prom_alu = 3.5 where id_alu = 13;
update Alumnos set prom_alu = 7.5 where id_alu = 14;
update Alumnos set prom_alu = 8.5 where id_alu = 18;
update Alumnos set prom_alu = 9.5 where id_alu = 29;
update Alumnos set prom_alu = 3.5 where id_alu = 21;
update Alumnos set prom_alu = 5.5 where id_alu = 26;
update Alumnos set prom_alu = 6.5 where id_alu = 23;
update Alumnos set prom_alu = 9.5 where id_alu = 17;
update Alumnos set prom_alu = 1.5 where id_alu = 24;
update Alumnos set prom_alu = 2.5 where id_alu = 28;
update Alumnos set prom_alu = 6.5 where id_alu = 30;
update Alumnos set prom_alu = 5.5 where id_alu = 20;
update Alumnos set prom_alu = 8.5 where id_alu = 22;
update Alumnos set prom_alu = 9.5 where id_alu = 27;


select * from carreras
select * from Alumnos