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

--Ingreso de los perfiles 
insert into perfil (descripcion) values ('Cliente'),('Empleado'),('Gerente'),('Administrador');

--Ingreso de cliente
INSERT INTO PERSONA VALUES('Carlos','Pineda',95963784,'2000-03-31','3795152229','carlosdaniel313@gmail.com','Hombre','si',1);

--Ingreso de administrador
INSERT INTO PERSONA VALUES('Admin','Sistema',00000000,'1999-03-31','123456789','admin@gmail.com','Hombre','si',4);
--Usuario: admin contraseña: admin (Todo minusculas)
insert into usuario values ('admin','admin',2);