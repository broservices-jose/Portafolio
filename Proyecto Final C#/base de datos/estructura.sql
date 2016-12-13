use DocumentosDB

go 

create table Documento(
id int identity(1,1) primary key,
numero varchar(25) not null
)

create table Departamento(
id int identity(1,1) primary key,
nombre varchar(40) not null
)

create table Empleado(
id int identity(1,1) primary key,
departamento int foreign key references Departamento (id),
nombre varchar(20) not null,
apellido varchar(20) not null,
cedula varchar(20) not null,
tipo int not null
)

create table Usuario(
empleado int foreign key references Empleado (id),
cuenta varchar(30),
contraseña varchar (30)
)

create table Buzon(
empleado int foreign key references Empleado (id),
documento int foreign key references Documento (id),
estado bit default 1
)

create table EnvioInterno(
id int identity(1,1) primary key,
mensajero int foreign key references Empleado (id),
remitente int foreign key references Empleado (id),
destinatario int foreign key references Empleado (id),
asunto varchar(50),
enviado datetime,
recibido datetime,
completado bit default 0
)

create table EnvioExterno(
id int identity(1,1) primary key,
mensajero int foreign key references Empleado (id),
remitente int foreign key references Empleado (id),
destinatario varchar(50),
asunto varchar(50),
telefono varchar(14),
direccion varchar(50),
enviado datetime,
recibido datetime,
completado bit default 0
)
