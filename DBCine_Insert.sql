use DBCine

INSERT INTO Formas_Pago (id_forma_pago, forma_pago)
VALUES
    (1, 'Efectivo'),
    (2, 'Tarjeta de crédito'),
    (3, 'Tarjeta de débito'),
	(4, 'Transferencia');


INSERT INTO Clientes (nombre, apellido, telefono, fecha_nac)
VALUES
    ('Juan', 'Pérez', '3517343233', '1990-05-15'),
    ('María', 'Gómez', '3518239832', '1988-10-20'),
    ('Pedro', 'López', '3519023439', '1995-03-08');


INSERT INTO IdiomasAudio (id_audio, idioma)
VALUES
    (1, 'Español'),
    (2, 'Inglés'),
    (3, 'Italiano');


INSERT INTO IdiomasSubtitulos (id_subtitulos, idioma)
VALUES
    (1, 'Español'),
    (2, 'Inglés'),
    (3, 'Italiano'),
	(4,'Sin subtitulos');


insert into Peliculas (titulo, duracion, fecha_publicacion, genero, sinopsis, id_audio, id_subtitulos)
values
('Cuando acechaba la maldad', '01:40', '2023-11-24','Terror', 'Un grupo de amigos se reúne en una casa abandonada para celebrar un cumpleaños. Sin embargo, pronto descubrirán que la casa está habitada por un espíritu maligno que los acecha.' ,1, 4),
('Una cigüeña en apuros: La joya perdida', '01:30', '2023-11-24', 'Animación', 'Una cigüeña pierde su carga y se encuentra con un cachorro que se convierte en su mejor amigo. Juntos, emprenderán una aventura para encontrar a la familia del cachorro.',2, 1),
('Los juegos del hambre: Boss', '02:15', '2023-11-24','Acción', 'Cordelia, la hija de Coriolanus Snow, se presenta a la décima edición de los Juegos del Hambre. Con la ayuda de su mentor, mentora, y de un misterioso aliado, Cordelia intentará ganar los juegos y sobrevivir.',2, 1);


insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 1, 1, 1)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 2, 2, 2)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 3, 3, 3)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 1, 4, 2)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 2, 1, 3)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 3, 2, 1)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 1, 3, 3)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 2, 4, 1)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 3, 1, 2)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 1, 2, 1)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 2, 3, 2)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 3, 4, 3)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 1, 1, 2)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 2, 2, 3)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 3, 3, 1)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 1, 4, 3)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 2, 1, 1)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 3, 2, 2)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 1, 3, 1)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 2, 4, 2)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 3, 2, 3)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 3, 2, 2)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 3, 2, 3)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 3, 4, 1)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 2, 1, 3)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 1, 2, 1)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 1, 2, 3)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 3, 4, 1)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 3, 1, 2)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 1, 2, 1)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 2, 3, 2)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 2, 4, 3)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 2, 1, 2)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 3, 2, 3)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 1, 3, 1)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 2, 4, 3)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 1, 2, 3)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 3, 1, 2)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 1, 2, 1)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 2, 2, 3)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 3, 2, 1)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 3, 1, 2)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 3, 3, 3)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 1, 2, 2)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 1, 1, 3)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 3, 2, 1)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 1, 3, 3)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 3, 2, 1)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 3, 1, 2)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 1, 2, 1)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 1, 3, 2)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 3, 4, 3)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 1, 1, 2)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 3, 2, 3)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 3, 3, 1)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 1, 4, 3)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 2, 1, 1)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 3, 2, 2)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 1, 3, 1)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 1, 4, 2)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 3, 2, 3)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 3, 2, 2)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 3, 2, 3)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 3, 4, 1)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 1, 1, 3)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 2, 2, 1)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 2, 2, 3)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 1, 4, 1)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 1, 1, 2)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 2, 2, 1)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 1, 3, 2)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 1, 4, 3)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 2, 1, 2)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 3, 2, 3)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 3, 3, 1)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 3, 4, 3)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 3, 2, 3)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 2, 1, 2)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 1, 2, 1)

insert into Ventas (fecha, id_pelicula, id_forma_pago, id_cliente)
values('2023-11-24', 1, 2, 3)


INSERT INTO Butacas (fila, columna, estado)
VALUES (1, 1, 'Disponible');

INSERT INTO Butacas (fila, columna, estado)
VALUES (1, 2, 'Disponible');

INSERT INTO Butacas (fila, columna, estado)
VALUES (1, 3, 'Disponible');

INSERT INTO Butacas (fila, columna, estado)
VALUES (1, 4, 'Disponible');

INSERT INTO Butacas (fila, columna, estado)
VALUES (1, 5, 'Disponible');

INSERT INTO Butacas (fila, columna, estado)
VALUES (1, 6, 'Disponible');

INSERT INTO Butacas (fila, columna, estado)
VALUES (2, 1, 'Disponible');

INSERT INTO Butacas (fila, columna, estado)
VALUES (2, 2, 'Disponible');

INSERT INTO Butacas (fila, columna, estado)
VALUES (2, 3, 'Disponible');

INSERT INTO Butacas (fila, columna, estado)
VALUES (2, 4, 'Disponible');

INSERT INTO Butacas (fila, columna, estado)
VALUES (2, 5, 'Disponible');

INSERT INTO Butacas (fila, columna, estado)
VALUES (2, 6, 'Disponible');

INSERT INTO Butacas (fila, columna, estado)
VALUES (3, 1, 'Disponible');

INSERT INTO Butacas (fila, columna, estado)
VALUES (3, 2, 'Disponible');

INSERT INTO Butacas (fila, columna, estado)
VALUES (3, 3, 'Disponible');

INSERT INTO Butacas (fila, columna, estado)
VALUES (3, 4, 'Disponible');

INSERT INTO Butacas (fila, columna, estado)
VALUES (3, 5, 'Disponible');

INSERT INTO Butacas (fila, columna, estado)
VALUES (3, 6, 'Disponible');


insert into Detalles_Ventas (id_venta, precio, descuento, filaButaca, colButaca)
values (1, 2500, 0, 1, 1)