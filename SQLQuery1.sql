create database BD_QG
go
use BD_QG
go

create table Persona(
codigo int identity primary key,
nombres varchar(100),
apellidos varchar(100),
edad int,
direccion varchar(100),
fecha datetime
);


go
insert into Persona(nombres,apellidos,edad,fecha,direccion)values('Francis','Velazco',21,2019/12/08 ,'Av Peru')
insert into Persona(nombres,apellidos,edad,fecha,direccion)values('Steven','Lizarzaburu',21,2019/12/08,'Av Mara�on')
insert into Persona(nombres,apellidos,edad,fecha,direccion)values('Esteban','Valencia',23,2019/12/08,'Av Tupac Amaru')
insert into Persona(nombres,apellidos,edad,fecha,direccion)values('Raul','Villanueva',23,2019/12/08,'Av Tupac Amaru')
go 

go
select * from Persona