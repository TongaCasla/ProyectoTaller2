create database db_PharmaSuite
go
use db_PharmaSuite
go

CREATE TABLE perfil
(
  id_perfil INT NOT NULL identity(1,1),
  descripcion VARCHAR(50) NOT NULL,
  constraint PK_perfil_id PRIMARY KEY (id_perfil)
);

CREATE TABLE persona
(
  id_persona INT NOT NULL identity(1,1),
  nombre VARCHAR(50) NOT NULL,
  apellido VARCHAR(50) NOT NULL,
  DNI INT NOT NULL,
  fechaNac DATE NOT NULL,
  telefono VARCHAR(50) NOT NULL,
  email VARCHAR(100) NOT NULL,
  sexo varchar(10) not null,
  activo varchar(2) not null constraint DF_persona_activo DEFAULT 'si',
  id_perfil INT NOT NULL,
  constraint PK_persona_id PRIMARY KEY (id_persona),
  constraint FK_persona_id_perfil FOREIGN KEY (id_perfil) REFERENCES Perfil(id_perfil),
  constraint UQ_persona_dni UNIQUE (dni),
  constraint UQ_persona_telefono UNIQUE (telefono),
  constraint UQ_persona_email UNIQUE (email),
  
);

create table usuario
(
  id_usuario int not null identity(1,1),
  nombre varchar(50) not null,
  pass varchar(50) not null,
  id_persona int not null,
  constraint PK_usuario_id PRIMARY KEY (id_usuario),
  constraint FK_usuario_id_persona Foreign key (id_persona) references persona(id_persona),
  constraint UQ_persona_usuario UNIQUE (nombre),
);


create table categoria
(
	id_categoria int not null identity(1,1),
	descripcion varchar(50) not null ,
	activo varchar(2) not null constraint DF_categoria_activo DEFAULT 'si',
	constraint PK_categoria_id primary key(id_categoria),
);


--Tablas nuevas
create table medida(
id_medida int not null identity(1,1),
unidad_medida varchar(50) not null,
constraint PK_medida_id PRIMARY KEY(id_medida)
);

create table producto(
codBarra int not null,
id_categoria int not null,
nombre_prod varchar(50) not null,
precio_lista float not null,
precio_venta float not null,
stock int not null,
stock_min int not null,
fecha_vencimiento date not null,
activo varchar(2) not null constraint DF_producto_activo default 'si',
venta_libre varchar(2) not null constraint DF_producto_venta_libre default 'si',
constraint PK_codbarra primary key(codbarra),
constraint FK_producto_categoria foreign key(id_categoria) references categoria(id_categoria),
);


create table presentacion_prod(
id_prod int not null,
id_medida int not null,
cantidad int not null,
forma_presentacion varchar(50) null,
Constraint PK_presentacion primary key(id_prod,id_medida),
constraint FK_presentacion_producto FOREIGN KEY(id_prod) references producto(codBarra),
constraint FK_presentacion_medida FOREIGN KEY(id_medida) references medida(id_medida),
);

create table forma_pago
(
	id_forma_pago int not null identity(1,1),
	forma varchar(50) not null,
	constraint PK_forma_pago primary key (id_forma_pago),
);


create table venta
(
	id_venta int not null identity(1,1),
	id_usuario int not null,
	id_formapago int not null,
	cliente int,
	total float not null,
	fecha_vta datetime not null constraint DF_venta_fecha default getdate(),
	constraint PK_venta primary key (id_venta),
	constraint FK_venta_usuario foreign key (id_usuario) references usuario(id_usuario),
	constraint FK_venta_cliente foreign key (cliente) references persona(id_persona),
	constraint FK_venta_formapago foreign key (id_formapago) references forma_pago(id_forma_pago)
);

create table venta_detalle
(
	id_venta_detalle int not null identity(1,1),
	id_venta int not null,
	codBarra int not null,
	cantidad int not null,
	subtotal float not null,
	constraint PK_venta_detalle primary key (id_venta_detalle),
	constraint FK_venta_detalle_producto foreign key (codBarra) references producto(codBarra),
	constraint FK_venta_detalle_venta foreign key (id_venta) references venta(id_venta),
);

create table registro_buckup
(
	id_registro_backup int identity(1,1),
	id_usuario int not null,
	ruta_guardado varchar(300)not null,
	fecha_guardado datetime not null constraint DF_backup_fecha default getdate()
	constraint PK_registro_backup primary key (id_registro_backup),
	constraint FK_backup_usuario foreign key (id_usuario) references usuario(id_usuario)
);

------------------------------------------------------------------------------------------------------------
------------------------------------PROCEDIMIENTOS----------------------------------------------------------
------------------------------------------------------------------------------------------------------------
--lista de clientes
CREATE PROCEDURE ListaClientes
AS
BEGIN
    SELECT DNI, concat(nombre,' ', apellido) as 'Nombre completo', telefono, email,sexo,datediff(year,fechaNac,GETDATE()) as edad
    FROM persona 
    --WHERE id_persona !=2 and id_perfil=1; --Quitamos el consumidor final
END;

--lista de empleados
CREATE PROCEDURE ListaEmpleadosActivos
AS
BEGIN
    SELECT  
	p.DNI,
	concat(p.nombre,' ', p.apellido) as 'Nombre completo',
	u.nombre as Usuario, 
	telefono as 'Teléfono',
	email as 'Email',
	sexo as 'Sexo',
	datediff(year,fechaNac,GETDATE()) as 'Edad'
    FROM persona p
	inner join usuario u on u.id_persona = p.id_persona
    WHERE p.id_persona !=1; --ocultamos el admin
END;

--lista de productos por categoria
CREATE PROCEDURE ListaProductosPorCategoria
AS
BEGIN
	SELECT 
	p.codBarra as 'Código de producto',
	p.nombre_prod as 'Nombre de producto',
	c.descripcion as 'Categoría',
	p.stock as 'Stock'
	FROM producto p
	inner join categoria c on p.id_categoria = c.id_categoria
END;

--Listado de ventas
CREATE PROCEDURE ListadoTodasVentas
AS
BEGIN
	SELECT
	v.id_venta as 'Nro Venta',
	concat(p.nombre,' ',p.apellido) as 'Nombre Vendedor',
	concat(c.nombre,' ',c.apellido) as 'Nombre Cliente',
	FORMAT(v.total,'C','es-AR') as 'Total venta',
	f.forma as 'Forma de pago',
	FORMAT(v.fecha_vta, 'dd-MM-yyyy HH:mm') as 'Fecha de venta'
	FROM persona p
	/*Traemos los datos del empleado que realizó la venta*/
	inner join usuario u on u.id_persona = p.id_persona
	/*Traemos los datos de la venta*/
	inner join venta v on v.id_usuario = u.id_usuario
	/*Traemos la forma de pago*/
	inner join forma_pago f on v.id_formapago = f.id_forma_pago
	/*Traemos los datos del cliente que realizó la compra*/
	inner join persona c on v.cliente = c.id_persona
END;

--Ventas por empleado
CREATE PROCEDURE ListaVentasEmpleado
AS
BEGIN
    SELECT
	concat(p.nombre,' ',p.apellido) as 'Nombre Vendedor',
	concat(c.nombre,' ',c.apellido) as 'Nombre Cliente',
	FORMAT(v.total,'C','es-AR') as 'Total venta',
	f.forma as 'Forma de pago',
	FORMAT(v.fecha_vta, 'dd-MM-yyyy') as 'Fecha de venta'
    FROM persona p
	/*Traemos los datos del empleado que realizó la venta*/
	inner join usuario u on u.id_persona = p.id_persona
	/*Traemos los datos de la venta*/
	inner join venta v on v.id_usuario = u.id_usuario
	/*Traemos la forma de pago*/
	inner join forma_pago f on v.id_formapago = f.id_forma_pago
	/*Traemos los datos del cliente que realizó la compra*/
	inner join persona c on v.cliente = c.id_persona
END;

--Ventas individuales (perfil empleado)
CREATE PROCEDURE ListaVentasIndividual
    @id_empleado int
AS
BEGIN
    SELECT
	concat(p.nombre,' ',p.apellido) as 'Nombre Vendedor',
	concat(c.nombre,' ',c.apellido) as 'Nombre Cliente',
	FORMAT(v.total,'C','es-AR') as 'Total venta',
	f.forma as 'Forma de pago',
	FORMAT(v.fecha_vta, 'dd-MM-yyyy') as 'Fecha de venta'
    FROM persona p
	/*Traemos los datos del empleado que realizó la venta*/
	inner join usuario u on u.id_persona = p.id_persona
	/*Traemos los datos de la venta*/
	inner join venta v on v.id_usuario = u.id_usuario
	/*Traemos la forma de pago*/
	inner join forma_pago f on v.id_formapago = f.id_forma_pago
	/*Traemos los datos del cliente que realizó la compra*/
	inner join persona c on v.cliente = c.id_persona
	/*Recibimos por parametro el id del empleado que queremos consultar*/
    WHERE v.id_usuario = @id_empleado;
END;

--Ventas por tiempo
CREATE PROCEDURE ListaVentasPorFecha
	@fecha_inicio VARCHAR(10),
    @fecha_fin VARCHAR(10)
AS
BEGIN
	--Convertimos en fecha 
	DECLARE @fecha_inicio_convertida DATE;
    DECLARE @fecha_fin_convertida DATE;
    -- Convertir las fechas de entrada al formato DATE
    SET @fecha_inicio_convertida = CONVERT(DATE, @fecha_inicio, 103); 
	-- 103 es el estilo para dd/MM/yyyy
    SET @fecha_fin_convertida = CONVERT(DATE, @fecha_fin, 103);
	SELECT
	concat(p.nombre,' ',p.apellido) as 'Nombre Vendedor',
	concat(c.nombre,' ',c.apellido) as 'Nombre Cliente',
	FORMAT(v.total,'C','es-AR') as 'Total venta',
	f.forma as 'Forma de pago',
	FORMAT(v.fecha_vta, 'dd-MM-yyyy HH-mm') as 'Fecha de venta'
    FROM persona p
	/*Traemos los datos del empleado que realizó la venta*/
	inner join usuario u on u.id_persona = p.id_persona
	/*Traemos los datos de la venta*/
	inner join venta v on v.id_usuario = u.id_usuario
	/*Traemos la forma de pago*/
	inner join forma_pago f on v.id_formapago = f.id_forma_pago
	/*Traemos los datos del cliente que realizó la compra*/
	inner join persona c on v.cliente = c.id_persona
	/*Recibimos por parametro las fechas que queremos consultar*/
	WHERE fecha_vta BETWEEN @fecha_inicio_convertida AND @fecha_fin_convertida;
END;

--Cierre de caja (solo empleado)
CREATE PROCEDURE CierreCaja
	@id_empleado int
AS
BEGIN
	SELECT
	concat(p.nombre,' ',p.apellido) as 'Nombre Vendedor',
	concat(c.nombre,' ',c.apellido) as 'Nombre Cliente',
	FORMAT(v.total,'C','es-AR') as 'Total venta',
	f.forma as 'Forma de pago',
	FORMAT(v.fecha_vta, 'dd-MM-yyyy HH:mm') as 'Fecha de venta'
    FROM persona p
	/*Traemos los datos del empleado que realizó la venta*/
	inner join usuario u on u.id_persona = p.id_persona
	/*Traemos los datos de la venta*/
	inner join venta v on v.id_usuario = u.id_usuario
	/*Traemos la forma de pago*/
	inner join forma_pago f on v.id_formapago = f.id_forma_pago
	/*Traemos los datos del cliente que realizó la compra*/
	inner join persona c on v.cliente = c.id_persona
	/*Recibimos por parametro el id del empleado que está loggeado*/
	WHERE CONVERT(DATE, fecha_vta) = CONVERT(DATE, GETDATE()) and v.id_usuario=@id_empleado;
END;

--Recaudacion (total ventas)
CREATE PROCEDURE Recaudacion
    @fecha_inicio VARCHAR(10),
	@fecha_fin VARCHAR(10)
AS
BEGIN
    -- Convertir las fechas de entrada a DATE
    DECLARE @fecha_inicio_date DATE = CONVERT(DATE, @fecha_inicio, 103);
    DECLARE @fecha_fin_date DATE = CONVERT(DATE, @fecha_fin, 103);

    -- Crear una tabla temporal para almacenar los meses entre las dos fechas
    ;WITH Meses AS (
        SELECT 
            DATEADD(MONTH, 0, @fecha_inicio_date) AS FechaMes
        UNION ALL
        SELECT 
            DATEADD(MONTH, 1, FechaMes)
        FROM Meses
        WHERE DATEADD(MONTH, 1, FechaMes) <= @fecha_fin_date
    )
    -- Hacer un LEFT JOIN entre los meses y las ventas para asegurar que todos los meses se muestran
    SELECT
        COUNT(v.id_venta) AS 'Ventas realizadas',
        FORMAT(m.FechaMes, 'MM/yyyy') AS 'Periodo',
        FORMAT(ISNULL(SUM(v.total), 0), 'C', 'es-AR') AS 'Sub total',
        FORMAT(ISNULL(SUM(v.total) * 0.21, 0), 'C', 'es-AR') AS 'IVA',
        FORMAT(ISNULL(SUM(v.total) + (SUM(v.total) * 0.21), 0), 'C', 'es-AR') AS 'Total'
    FROM Meses m
    LEFT JOIN venta v
        ON MONTH(v.fecha_vta) = MONTH(m.FechaMes)
        AND YEAR(v.fecha_vta) = YEAR(m.FechaMes)
    GROUP BY MONTH(m.FechaMes), YEAR(m.FechaMes), m.FechaMes
    ORDER BY YEAR(m.FechaMes), MONTH(m.FechaMes);
END;

--Productos con stock bajo
CREATE PROCEDURE ListaProductosStockBajo
AS
BEGIN
	SELECT 
	codBarra as 'Código de barra', 
	nombre_prod as 'Nombre de producto', 
	stock as 'Stock actual', 
	stock_min as 'Stock mínimo'
	FROM producto p
	WHERE stock < stock_min;
END;

--Ganancia por producto
CREATE PROCEDURE GananciaPorProducto
AS
BEGIN
	SELECT 
		nombre_prod AS 'Producto',
		FORMAT(precio_lista, 'C', 'es-AR') AS 'Precio de Lista',
		FORMAT(precio_venta, 'C', 'es-AR') AS 'Precio de Venta',
		/*Calculamos el margen de ganancia*/
		FORMAT(precio_venta - precio_lista, 'C', 'es-AR') AS 'Margen de Ganancia',
		/*Calculamos el porcentaje de ganancia*/
		CONCAT(ROUND(((precio_venta - precio_lista) / precio_lista) * 100, 2),' %') AS 'Porcentaje de Ganancia'
	FROM producto;
END;
--Productos proximos a vencer
CREATE PROCEDURE ProductosProximosAVencer
AS
BEGIN
	SELECT 
		codBarra as 'Código',
		nombre_prod AS 'Producto',
		FORMAT(fecha_vencimiento, 'dd-MM-yyyy') AS 'Fecha de Vencimiento',
		DATEDIFF(DAY, GETDATE(), fecha_vencimiento) AS 'Días Restantes'
	FROM producto
	WHERE 
		fecha_vencimiento > GETDATE()
	ORDER BY fecha_vencimiento ASC;
END;


----------------------------------------------------------------------------------------------
-----------------------------LOTE DE DATOS----------------------------------------------------
----------------------------------------------------------------------------------------------
-- Perfiles--
insert into perfil (descripcion) values ('Cliente'),('Empleado'),('Gerente'),('Administrador');
--Categorias--
insert into categoria (descripcion) values ('Shampú'),('Higiene'),('Limpieza'),('Bebida');
--Ingreso de administrador
INSERT INTO PERSONA VALUES('Admin','Sistema',00000000,'1900-01-01','123456789','admin@gmail.com','otro','si',4);
--Usuario: admin contraseña: admin (Todo minusculas)
insert into usuario values ('admin','admin',1);
--Ingreso de gerente
INSERT INTO PERSONA VALUES('Consumidor','Final',00000001,'1900-01-01','123456780','cf@gmail.com','otro','si',3);
--Usuario: gerente contraseña: gerente (Todo minusculas)
insert into usuario values ('gerente','gerente',2);
--Ingreso de formas de pago
INSERT INTO forma_pago VALUES ('Efectivo'),('Débito'), ('Transferencia');
---Insert medida
insert into medida values ('ud'),('gr'),('mg'),('lt'),('ml');
----Producto proximo a vencer p/ test
insert into producto values(316306900,1,'Hilo dental',2300,5000,30,15,'2024-11-30','si','si');
--Producto con stock bajo p/ test
insert into producto values(316306912,3,'Enjuague Sedal',2800,3200,10,20,GETDATE(),'si','si');
--Cliente p/ test
INSERT INTO PERSONA VALUES('Juan','Perez',44567834,'2001-11-09','12345667','juanperez@gmail.com','otro','si',1);
--Ventas p/ test
insert into venta (id_usuario,id_formapago,cliente,total,fecha_vta) values(2,1,3,1000,GETDATE());
insert into venta (id_usuario,id_formapago,cliente,total,fecha_vta) values(2,1,3,10000,'2024-03-11');
