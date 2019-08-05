create database BD_QG
go
use BD_QG
go

create table Persona(
codigo int identity primary key,
nombres varchar(100),
apellidos varchar(100),
edad int,
fecha datetime,
direccion varchar(100)
);


go
insert into Persona(nombres,apellidos,edad,fecha,direccion)values('Francis','Velazco',21,08/12/2019,'Av Peru')
insert into Persona(nombres,apellidos,edad,fecha,direccion)values('Steven','Lizarzaburu',21,08/12/2019,'Av Marañon')
insert into Persona(nombres,apellidos,edad,fecha,direccion)values('Esteban','Valencia',23,08/12/2019,'Av Tupac Amaru')
insert into Persona(nombres,apellidos,edad,fecha,direccion)values('Raul','Villanueva',23,08/12/2019,'Av Tupac Amaru')
go 

go
select * from Persona