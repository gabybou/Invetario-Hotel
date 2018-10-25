use master
go


Create database Nomina_Pago3
go

Use Nomina_Pago3
go

create table empleado(
EmpleadoID varchar(5) NOT NULL,
Nombre VARCHAR(50),
Apellido VARCHAR(50),
Edad varchar(5),
Genero VARCHAR(10),
FechaIngreso varchar(15),
Dui VARCHAR(15) ,
Nit VARCHAR(17),
Direccion VARCHAR(250),
Email VARCHAR (50),
Sueldo_Base varchar(10),
Cargo varchar(20),
Telefono varchar(15)
)
alter table empleado add primary key(EmpleadoID);
go

create table Pago(
PagoID varchar(5) not null,
Año date not null,
Mes date not null,
Quincena float not null,
Fecha_Elaboracion date not null
)
alter table Pago add primary key(PagoID);
go

/*create table Cargo(
CargoID varchar(5)not null,
Cargo varchar(20) not null
)
alter table Cargo add primary key(CargoID);
go*/

create table Detalle_Empleado(
EmpleadoID varchar(5) not null,
Area varchar(20) not null,
Detalle_EmpleadoID varchar(5) not null,
Bonos float,
Descripcion varchar(250),
Fecha_AsignacionCargo date,
Estatus varchar(15))
alter table Detalle_Empleado add primary key(Detalle_EmpleadoID);
go


create table Detalle_Pago(
PagoEmpleadoID varchar(5)not null,
Alimentacion float not null,
AFP float not null,
ISSS float not null,
Prestamo float not null,
Total float not null,
PagoID varchar(5)not null,
EmpleadoID varchar(5) not null
)
alter table Detalle_Pago add primary key (PagoEmpleadoID)
go


ALTER TABLE Detalle_Pago 
ADD CONSTRAINT FK_PagoID FOREIGN KEY (PagoID) REFERENCES Pago (PagoID)   
ON DELETE CASCADE  
ON UPDATE CASCADE;

ALTER TABLE Detalle_Pago 
ADD CONSTRAINT FK_EmpleadoID FOREIGN KEY (EmpleadoID) REFERENCES Detalle_Empleado (Detalle_EmpleadoID)   
ON DELETE CASCADE  
ON UPDATE CASCADE
go

create table Prestamo(
PrestamoID varchar(5),
Fecha_Inicio date not null,
EmpleadoID varchar(5) not null,
Monto float not null,
Pago_Quincenal float not null,
Anticipo float not null,
Total_Pagos int not null,
Fecha_UltimoPago date
)
go

ALTER TABLE Prestamo 
ADD CONSTRAINT FK_PEmpleadoID FOREIGN KEY (EmpleadoID) REFERENCES empleado (EmpleadoID)   
ON DELETE CASCADE  
ON UPDATE CASCADE
go



/*ALTER TABLE Detalle_Empleado 
ADD CONSTRAINT FK_DECargoID FOREIGN KEY (CargoID) REFERENCES Cargo (CargoID)   
ON DELETE CASCADE  
ON UPDATE CASCADE
go*/

ALTER TABLE Detalle_Empleado 
ADD CONSTRAINT FK_DEEmpleadoID FOREIGN KEY (EmpleadoID) REFERENCES Empleado (EmpleadoID)   
ON DELETE CASCADE  
ON UPDATE CASCADE
go


create table Usuarios (
Usuario varchar(20) not null,
Clave varchar(8) not null)
go

create table Detalle_PagoEmpleado(
PagoEmpleadoID varchar(5),
EmpleadoID varchar(5)
)
go

ALTER TABLE Detalle_PagoEmpleado 
ADD CONSTRAINT FK_PagoEmpleadoID FOREIGN KEY (PagoEmpleadoID) REFERENCES Detalle_Pago (PagoEmpleadoID)   
ON DELETE CASCADE  
ON UPDATE CASCADE
go

ALTER TABLE Detalle_PagoEmpleado 
ADD CONSTRAINT FK_DPEmpleadoID FOREIGN KEY (EmpleadoID) REFERENCES empleado (EmpleadoID)   
ON DELETE CASCADE  
ON UPDATE CASCADE;
go


/*precedimientos*/

/*Ingresar datos empleados*/
create proc spingresar_empleado
@empleadoid varchar(5),
@nombre varchar(50),
@apellido varchar(50),
@edad varchar(5),
@genero varchar(10),
@fecha_ingreso varchar(15),
@dui varchar(15),
@nit varchar(17),
@direccion varchar(250),
@email varchar(50),
@sueldo_base varchar(10),
@cargo varchar (20),
@telefono varchar(15)
as
insert into empleado(EmpleadoID, Nombre, Apellido, Edad, Genero, FechaIngreso, Dui, Nit, Direccion, Email, Sueldo_Base, Cargo, Telefono)
values (@empleadoid, @nombre, @apellido, @edad, @genero, @fecha_ingreso, @dui, @nit, @direccion, @email, @sueldo_base, @cargo, @telefono)

/*Ingresar datos empleados*/
create proc speliminar_empleado
@empleadoid varchar(5) as
delete from empleado where EmpleadoID=@empleadoid


select * from empleado
go


delete from empleado where EmpleadoID='JAMC9';

create proc spusuario_clave
@usuario varchar(20),
@clave varchar(8)
as
insert into Usuarios(Usuario, Clave)
values (@usuario, @clave)

insert into Usuarios(Usuario, Clave)
values ('Admin', 'Pimiento')



select * from Usuarios
go