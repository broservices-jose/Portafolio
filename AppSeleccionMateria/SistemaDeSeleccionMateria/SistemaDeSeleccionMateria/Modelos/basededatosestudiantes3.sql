drop table if exists usuarios;
drop table if exists estudiantes;
drop table if exists imagenes;
drop table if exists carreras;

create user if not exists "root"@"localhost" identified by "2222";
grant all privileges on *.* to "root"@"localhost";
flush privileges;

CREATE TABLE if not exists usuarios (
  id_usuario 			varchar(15) NOT NULL,
  nombre 				varchar(25) DEFAULT NULL,
  apellido 				varchar(25) DEFAULT NULL,
  sexo 					varchar(20) DEFAULT NULL,
  cuenta 				varchar(25) DEFAULT NULL,
  clave 				varchar(25) DEFAULT NULL,
  estado 				varchar(15) DEFAULT NULL,
  tipo 					varchar(15) DEFAULT NULL,
  registro 				date 		DEFAULT NULL,

  PRIMARY KEY (id_usuario)

);


CREATE TABLE if not exists estudiantes (
  id_estudiante 		varchar(15) DEFAULT NULL,
  carrera 				int(5)		DEFAULT NULL, 
  CONSTRAINT estudiantes FOREIGN KEY (id_estudiante) REFERENCES usuarios (id_usuario)
);

create table if not exists imagenes(
	id_imagen 			int auto_increment primary key,
	id_propietario 		varchar(25) not null,
	tipo_propietario 	varchar(25),
	url 				text,
	registro 			date
);


create table if not exists carreras(
	id_carrera 			int not null auto_increment primary key,
	nombre				varchar(25),
	estado 				varchar(20),
	registro 			date
);

create table materias(
	id_materia 			int auto_increment primary key,
	nombre 				varchar(25),
	carrera 			int,
	requisito			int,
	estado				varchar(15)
	registro date,  
    foreign key(carrera) references carreras(id_carrera) on delete cascade on update cascade
);



create table if not exists entidad(
	id_entidad			varchar(25),
	nombre 				varchar(25)	unique,
	representante 	 	varchar(25)	unique,
	direccion 		 	varchar(100)	unique,
	telefono		 	varchar(15)	unique,
	registro 	 	 	date
);