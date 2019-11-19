use master
DECLARE @dbname nvarchar(128)
SET @dbname = N'TP_WEB'

IF (EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE ('[' + name + ']' = @dbname 
OR name = @dbname)))
drop database TP_WEB

use master
go
CREATE DATABASE TP_WEB
GO
USE TP_WEB
Go
CREATE TABLE Productos(
    Id BIGINT NOT NULL IDENTITY (1, 1) PRIMARY KEY,
    Titulo VARCHAR(50) NOT NULL CHECK (LEN(Titulo) > 0),
    Descripcion VARCHAR(250) NOT NULL CHECK (LEN(Descripcion) > 0),
    URLImagen VARCHAR(1000) NOT NULL CHECK (LEN(URLImagen) > 0)
);

CREATE TABLE Clientes(
    Id BIGINT NOT NULL IDENTITY (1, 1) PRIMARY KEY,
    Dni BIGINT NOT NULL CHECK (LEN(Dni) > 0),
    Nombre VARCHAR(50) NOT NULL CHECK (LEN(Nombre) > 0),
    Apellido VARCHAR(50) NOT NULL CHECK (LEN(Apellido) > 0),
	Email VARCHAR(50) NOT NULL CHECK (LEN(Email) > 0),
	Domicilio VARCHAR(50) NOT NULL CHECK (LEN(Domicilio) > 0),
	Ciudad VARCHAR(50) NOT NULL CHECK (LEN(Ciudad) > 0),
	CodigoPostal VARCHAR(8) NOT NULL CHECK (LEN(CodigoPostal) > 0)
);

CREATE TABLE Vouchers(
    CodigoVoucher VARCHAR(32) NOT NULL UNIQUE CHECK (LEN(CodigoVoucher) = 4)
);