CREATE DATABASE PROYECTO;
Go

USE PROYECTO;
Go

CREATE TABLE Registros(
	Id_Registro int not null identity Primary key,
	Nombre varchar(25) not null,
	Apellido varchar(25) not null,
	Dui varchar(15) not null unique,
	Contrasena varchar(30) not null,
	Posicion varchar(10),
	horaIngreso datetime,
	horaSalida datetime,
	pagar int not null,
	monto float 
);
Go

Create procedure nuevo_cliente
	@Nombre varchar(25),
	@Apellido varchar(25),
	@Dui varchar(15),
	@Contrasena varchar(30)
As
	Insert into Registros(Nombre, Apellido, Dui, Contrasena , pagar) values(@Nombre, @Apellido, @Dui, @Contrasena, 0);
Go

Exec nuevo_cliente 'Yahir', 'Sibrian', '032930398-2', '123456';
Go

Create function tiempo_cliente(@id int)
Returns int
Begin
	Declare @tiempo int
	select @tiempo = (select DATEDIFF(MINUTE, horaIngreso, horaSalida) From Registros Where @id = Id_Registro)
	if(@tiempo > 30)
		select @tiempo = (select DATEDIFF(HOUR, horaIngreso, horaSalida) From Registros Where @id = Id_Registro);
	else
		select @tiempo = 0;
	return @tiempo
End
Go



Create procedure salida_cliente
	@id int
As
	Update Registros Set horaSalida = GETDATE() Where Id_Registro = @id;
	
	Select (Select dbo.tiempo_cliente(@id)) * 0.75 as "Cantidad";
Go

Exec salida_cliente 1;
Go

Create procedure inicioSesion
	@DUI varchar(15),
	@Contrasena varchar(30)
AS
	Select * From Registros WHERE Dui = @DUI AND Contrasena = @Contrasena;
GO

Exec inicioSesion '12345678-9', '123';
Go

Create procedure otorgarEspacio
	@Posicion varchar(15),
	@Id int
As
	Update Registros Set Posicion = @Posicion, horaIngreso = getdate() Where Id_Registro = @Id;
GO

Exec otorgarEspacio 'A1', 6;
Go

Select Id_Registro , Posicion From Registros
Go

DELETE FROM Registros WHERE Id_Registro = '18'

Select * From Registros