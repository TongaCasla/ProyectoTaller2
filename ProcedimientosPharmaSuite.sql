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

--Ventas por empleado
CREATE PROCEDURE ListaVentasEmpleado
AS
BEGIN
    SELECT
	concat(p.nombre,' ',p.apellido) as 'Nombre Vendedor',
	concat(c.nombre,' ',c.apellido) as 'Nombre Cliente',
	FORMAT(v.total,'C','es-AR') as 'Total venta',
	FORMAT(v.fecha_vta, 'dd-MM-yyyy') as 'Fecha de venta'
    FROM persona p
	/*Traemos los datos del empleado que realizó la venta*/
	inner join usuario u on u.id_persona = p.id_persona
	/*Traemos los datos de la venta*/
	inner join venta v on v.id_usuario = u.id_usuario
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
	FORMAT(v.fecha_vta, 'dd-MM-yyyy') as 'Fecha de venta'
    FROM persona p
	/*Traemos los datos del empleado que realizó la venta*/
	inner join usuario u on u.id_persona = p.id_persona
	/*Traemos los datos de la venta*/
	inner join venta v on v.id_usuario = u.id_usuario
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
	FORMAT(v.fecha_vta, 'dd-MM-yyyy HH-mm') as 'Fecha de venta'
    FROM persona p
	/*Traemos los datos del empleado que realizó la venta*/
	inner join usuario u on u.id_persona = p.id_persona
	/*Traemos los datos de la venta*/
	inner join venta v on v.id_usuario = u.id_usuario
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
	FORMAT(v.fecha_vta, 'dd-MM-yyyy HH:mm') as 'Fecha de venta'
    FROM persona p
	/*Traemos los datos del empleado que realizó la venta*/
	inner join usuario u on u.id_persona = p.id_persona
	/*Traemos los datos de la venta*/
	inner join venta v on v.id_usuario = u.id_usuario
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
        FORMAT(ISNULL(SUM(v.total) - (SUM(v.total) * 0.21), 0), 'C', 'es-AR') AS 'Total'
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
