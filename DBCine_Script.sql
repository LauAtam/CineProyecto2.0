use master
go

drop database DBCine
go

create database DBCine
go 

use DBCine
go

create table Formas_Pago(
id_forma_pago int,
forma_pago varchar(50),
constraint pk_fp primary key(id_forma_pago)
)

create table Clientes(
id_cliente int identity,
nombre varchar(50),
apellido varchar(50),
telefono varchar(11),
fecha_nac date,
constraint pk_c primary key(id_cliente),
)

create table IdiomasAudio(
id_audio int,
idioma varchar(50),
constraint pk_ia primary key (id_audio)
)

create table IdiomasSubtitulos(
id_subtitulos int,
idioma varchar(50),
constraint pk_is primary key (id_subtitulos)
)

create table Peliculas(
id_pelicula int identity,
titulo varchar(50),
duracion time,
fecha_publicacion date,
genero varchar(50), 
sinopsis varchar(400),
id_audio int,
id_subtitulos int,
constraint pk_p primary key(id_pelicula),
constraint fk_e_a foreign key(id_audio)
	references IdiomasAudio(id_audio),
constraint fk_e_s foreign key(id_subtitulos)
	references IdiomasSubtitulos(id_subtitulos)
)

create table Ventas(
id_venta int identity,
fecha date,
id_pelicula int,
id_forma_pago int,
id_cliente int,
constraint pk_v primary key(id_venta),
constraint fk_v_c foreign key(id_cliente)
	references Clientes(id_cliente),
constraint fk_v_fp foreign key(id_forma_pago)
	references Formas_pago(id_forma_pago),
constraint fk_v_p foreign key(id_pelicula)
	references Peliculas(id_pelicula)
)

create table Butacas(
fila int,
columna int,
estado varchar(50),
constraint pk_b primary key (fila,columna)
)

create table Detalles_Ventas(
id_detalle_venta int identity,
id_venta int,
precio money,
descuento int,
filaButaca int,
colButaca int,
constraint pk_dv primary key(id_detalle_venta),
constraint fk_dv_v foreign key(id_venta)
	references Ventas(id_venta),
constraint fk_dv_b foreign key(filaButaca,colButaca)
	references Butacas(fila,columna)
)


CREATE PROCEDURE SP_PROXIMO_ID
@next int OUTPUT
AS
BEGIN
	SET @next = (SELECT MAX(id_venta)+1  FROM Ventas);
END
go


CREATE PROCEDURE SP_INSERTAR_VENTA
	@fecha date,
	@id_pelicula int,
	@id_forma_pago int,
	@id_cliente int
AS
BEGIN
	DECLARE @id_venta int
    SET @id_venta = SCOPE_IDENTITY();
	INSERT INTO Ventas(fecha,id_pelicula,id_forma_pago,id_cliente)
    VALUES (GETDATE(),@id_pelicula,@id_forma_pago, @id_cliente);
END
GO

CREATE PROCEDURE SP_INSERTAR_DETALLEVENTA
	@id_venta int,
	@precio money,
	@descuento int,
	@filaButaca int,
	@colButaca int
AS
BEGIN
	DECLARE @id_detalle_venta int
    SET @id_detalle_venta = SCOPE_IDENTITY();
	INSERT INTO Detalles_Ventas(id_venta,precio,descuento,filaButaca,colButaca)
    VALUES (@id_venta,@precio,@descuento,@filaButaca,@colButaca);
END
GO

CREATE PROCEDURE SP_PELICULASMASVISTAS
AS
BEGIN
    DECLARE @FechaInicio date, @FechaFin date

    SET @FechaFin = GETDATE()
    SET @FechaInicio = DATEADD(MONTH, -3, @FechaFin)

    SELECT TOP 5 P.titulo, COUNT(v.id_pelicula) AS TotalVistas
    FROM Peliculas P
    INNER JOIN Ventas V ON P.id_pelicula = V.id_pelicula
    WHERE V.fecha BETWEEN @FechaInicio AND @FechaFin
    GROUP BY P.titulo
    ORDER BY TotalVistas DESC
END
go

CREATE PROC SP_INSERTAR_CLIENTE
@nombre	varchar(50),
@apellido varchar(50),
@telefono varchar(11),
@fecha_nac date
AS
BEGIN
	declare @id_cliente int
    SET @id_cliente = SCOPE_IDENTITY();
	insert into Clientes(nombre, apellido, telefono, fecha_nac)
	VALUES (@nombre, @apellido, @telefono, @fecha_nac);
END
GO

CREATE PROC SP_ACTUALIZAR_CLIENTE

@id_cliente int,
@nombre	varchar(50) = null,
@apellido varchar(50) = null,
@telefono varchar(11) = null,
@fecha_nac date = null
AS
BEGIN
	update clientes
	set
		nombre=isNull(@nombre, nombre),
		apellido=isNull(@apellido, apellido),
		telefono=isNull(@telefono,telefono),
		fecha_nac = isNull(@fecha_nac, fecha_nac)
	where id_cliente = @id_cliente
END
GO

CREATE PROC SP_CONSULTAR_CLIENTES
AS
BEGIN
	SELECT
		id_cliente 'ID',
		nombre 'Nombre',
		apellido 'Apellido',
		fecha_nac 'Nacimiento',
		telefono 'Telefono'
	FROM Clientes
END
GO

CREATE PROC SP_BORRAR_CLIENTE
@id_cliente int
AS
BEGIN
	DELETE FROM Clientes
	WHERE id_cliente = @id_cliente
END
GO

CREATE PROC SP_CONSULTAR_FORMASPAGO
AS
BEGIN
	SELECT id_forma_pago, forma_pago
	FROM Formas_Pago
END
GO

create proc SP_CONSULTAR_PELICULAS_DESDE_HASTA
@desde int,
@hasta int
as
begin
	select
		id_pelicula,
		titulo, 
		year(fecha_publicacion) año,
		genero,
		iaud.idioma 'Audio',
		isub.idioma 'Subtitulos',
		sinopsis
	from Peliculas p
	join IdiomasAudio iaud on p.id_audio=iaud.id_audio
	join IdiomasSubtitulos isub on p.id_audio=isub.id_subtitulos
	where YEAR(fecha_publicacion) between @desde and @hasta
end
go

create proc SP_CONSULTAR_PELICULAS_DETALLES
as
begin
	select
		id_pelicula,
		titulo, 
		fecha_publicacion,
		genero,
		iaud.idioma 'Audio',
		isub.idioma 'Subtitulos',
		sinopsis
	from Peliculas p
	join IdiomasAudio iaud on p.id_audio=iaud.id_audio
	join IdiomasSubtitulos isub on p.id_audio=isub.id_subtitulos
end
go

