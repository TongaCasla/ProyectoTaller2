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


-- Perfiles--

insert into perfil (descripcion) values ('Cliente'),('Empleado'),('Gerente'),('Administrador');

--Ingreso de administrador
INSERT INTO PERSONA VALUES('Admin','Sistema',00000000,'1900-01-01','123456789','admin@gmail.com','otro','si',4);
--Usuario: admin contraseña: admin (Todo minusculas)
insert into usuario values ('admin','admin',1);
--Ingreso de gerente
INSERT INTO PERSONA VALUES('Consumidor','Final',00000001,'1900-01-01','123456780','cf@gmail.com','otro','si',3);
--Usuario: admin contraseña: admin (Todo minusculas)
insert into usuario values ('gerente','gerente',2);

--Ingreso de formas de pago
INSERT INTO forma_pago VALUES ('Efectivo');
INSERT INTO forma_pago VALUES ('Debito');
INSERT INTO forma_pago VALUES ('Transferencia');


---Insert medida
insert into medida values ('ud'),('gr'),('mg'),('lt'),('ml');
----Producto proximo a vencer p/ test
insert into producto values(316306900,1,'Hilo dental',2300,5000,30,15,'2024-11-30','si','si');
--Producto con stock bajo p/ test
insert into producto values(316306912,3,'Enjuague Sedal',2800,3200,10,20,GETDATE(),'si','si');
--Ventas p/ test
insert into venta (id_usuario,cliente,total,fecha_vta) values(2,4,1000,GETDATE());
insert into venta (id_usuario,cliente,total,fecha_vta) values(2,4,10000,'2024-03-11');


 /*
 alter table persona
 add constraint FK_persona_id_perfil FOREIGN KEY (id_perfil) REFERENCES Perfil(id_perfil);
 alter table usuario
 add constraint FK_usuario_id_persona Foreign key (id_persona) references persona(id_persona);
 */
  select * from venta
 select * from venta_detalle
 select * from registro_buckup
