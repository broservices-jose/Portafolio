use DocumentosDB

go
select * from Empleado
--update Usuario set empleado = 5 where empleado = 1
select * from Usuario right join Empleado on Usuario.empleado = Empleado.id

--insert into EnvioInterno(remitente, destinatario, mensajero, enviado, asunto) values

--insert into Usuarios (empleado, cuenta, contraseña) values (4, 'mortiz', '123')
--insert into Empleado(nombre, apellido, cedula, departamento, tipo) values ('Ramon', 'Llano', '121232133', 1, 4)

select * from Documento
update EnvioInterno set documento = 2 where destinatario = 4
select * from EnvioInterno
select * from EnvioExterno