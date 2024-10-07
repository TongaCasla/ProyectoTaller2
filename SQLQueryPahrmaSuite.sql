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

create table venta
(
	id_venta int not null identity(1,1),
	id_usuario int not null,
	cliente int constraint DF_venta_consFinal default 1,
	total float not null,
	fecha_vta datetime not null constraint DF_venta_fecha default getdate(),
	constraint PK_venta primary key (id_venta),
	constraint FK_venta_usuario foreign key (id_usuario) references usuario(id_usuario),
	--constraint FK_venta_cliente foreign key (cliente) references persona(id_persona),
);

create table forma_pago
(
	id_forma_pago int not null identity(1,1),
	forma varchar(50) not null,
	descuento float not null,
	constraint PK_forma_pago primary key (id_forma_pago),
);

create table venta_pago
(
	id_venta int not null,
	id_forma_pago int not null,
	monto float not null,
	constraint PK_venta_pago primary key (id_venta,id_forma_pago),
	constraint FK_venta_pago_venta foreign key (id_venta) references venta(id_venta),
	constraint FK_venta_pago_forma foreign key (id_forma_pago) references forma_pago(id_forma_pago),
);

-- hasta aca --

insert into perfil (descripcion) values ('Cliente'),('Empleado'),('Gerente'),('Administrador'),;


 /*
 alter table persona
 add constraint FK_persona_id_perfil FOREIGN KEY (id_perfil) REFERENCES Perfil(id_perfil);
 alter table usuario
 add constraint FK_usuario_id_persona Foreign key (id_persona) references persona(id_persona);
 */

