

create database ReactLogin


create table Usuario(
	id int not null primary key,
	nombreUsuario varchar(20) not null,
	contraseña varchar(20) not null
);

insert into Usuario values(1,'fernando','123')