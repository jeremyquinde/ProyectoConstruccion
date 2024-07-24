Create Database dbProyectoCS;
Use dbProyectoCS;
;
--======================================================================================--
--=============================== MODULO CLIENTES ======================================--
--======================================================================================--

CREATE TABLE tb_clientes (
    id_cliente INT IDENTITY(1,1) PRIMARY KEY,
    nombres VARCHAR(50) NOT NULL,
    apellidos VARCHAR(50) NOT NULL,
    cedula VARCHAR(10) NOT NULL,
    correo VARCHAR(100) NOT NULL,
    telefono VARCHAR(10) NOT NULL,
    direccion VARCHAR(100) NOT NULL
);

CREATE UNIQUE INDEX idx_unique_cedula ON tb_clientes (cedula);



-- SP PARA INSERTAR NUEVOS CLIENTES

GO
CREATE PROCEDURE sp_InsertarCliente
    @apellidos VARCHAR(50),
    @nombres VARCHAR(50),
    @cedula VARCHAR(10), 
    @correo VARCHAR(100),
    @telefono VARCHAR(10), 
    @direccion VARCHAR(100)
AS
BEGIN
    INSERT INTO tb_clientes (apellidos, nombres, cedula, correo, telefono, direccion)
    VALUES (@apellidos, @nombres, @cedula, @correo, @telefono, @direccion);
END;

-- SP PARA MOSTRAR DATOS DE CLIENTES

GO
CREATE PROCEDURE sp_MostrarClientes
AS
BEGIN
    SELECT * FROM tb_clientes;
END;

-- SP PARA ACTUALIZAR DATOS DE CLIENTES

GO
CREATE PROCEDURE sp_ActualizarCliente
    @id_cliente INT,
    @nombres VARCHAR(50),
    @apellidos VARCHAR(50),
    @cedula VARCHAR(10),
    @correo VARCHAR(100),
    @telefono VARCHAR(10),
    @direccion VARCHAR(100)
AS
BEGIN
    UPDATE tb_clientes
    SET nombres = @nombres, apellidos = @apellidos, cedula = @cedula, correo = @correo, telefono = @telefono, direccion = @direccion
    WHERE id_cliente = @id_cliente;
END;


-- SP PARA ELMINAR CLIENTE SEGUN ID DE CLIENTE

GO
CREATE PROCEDURE sp_EliminarCliente
    @id_cliente INT
AS
BEGIN
    DELETE FROM tb_clientes
    WHERE id_cliente = @id_cliente;
END;




--======================================================================================--
--=================================== MODULO USUARIOS ==================================--
--======================================================================================--

CREATE TABLE tb_usuarios (
    id_usuarios INT PRIMARY KEY IDENTITY(1,1),
	apellidos VARCHAR(50) NOT NULL,
    nombres VARCHAR(50) NOT NULL,
    cedula INT NOT NULL,
    correo VARCHAR(100) NOT NULL,
    telefono INT NOT NULL,
    direccion VARCHAR(100) NOT NULL,
	rol VARCHAR(20) NOT NULL,
	fecha_registro date NOT NULL,
	contraseña VARCHAR(50)NOT NULL
);


--SP PARA INSERTAR USUARIO

GO
CREATE PROCEDURE sp_InsertarUsuario
    @apellidos VARCHAR(50), 
    @nombres VARCHAR(50),
    @cedula VARCHAR(10),
    @correo VARCHAR(100),
    @telefono VARCHAR(10),
    @direccion VARCHAR(100),
    @rol VARCHAR(20),
    @fecha_registro DATE ,
    @contraseña VARCHAR(50)
AS
BEGIN
    INSERT INTO tb_usuarios (apellidos, nombres, cedula, correo, telefono, direccion, rol, fecha_registro, contraseña)
    VALUES (@apellidos, @nombres, @cedula, @correo, @telefono, @direccion, @rol, @fecha_registro, @contraseña);
END;
GO




-- SP PARA MOSTRAR USUARIO

GO
CREATE PROCEDURE sp_MostrarUsuarios
AS
BEGIN
    SELECT * FROM tb_usuarios;
END;



-- SP PARA ACTUALIZAR DATOS DE USUARIO


GO
CREATE PROCEDURE sp_ActualizarUsuario
    @id_usuario INT,
    @apellidos VARCHAR(50),
    @nombres VARCHAR(50),
    @cedula VARCHAR(10),
    @correo VARCHAR(100),
    @telefono VARCHAR(10),
    @direccion VARCHAR(100),
    @rol VARCHAR(20) ,
    @fecha_registro DATE,
    @contraseña VARCHAR(50)
AS
BEGIN
    UPDATE tb_usuarios
    SET apellidos = @apellidos, nombres = @nombres, cedula = @cedula, correo = @correo, telefono = @telefono, direccion = @direccion, 
		rol = @rol, fecha_registro = @fecha_registro, contraseña = @contraseña
    WHERE id_usuario = @id_usuario;
END;

-- SP PARA ELMINAR USUARIO SEGUN ID 

GO
CREATE PROCEDURE sp_EliminarUsuario
    @id_usuario INT
AS
BEGIN
    DELETE FROM tb_usuarios
    WHERE id_usuario = @id_usuario;
END;



--SP PARA AUTENTICAR EL USUARIO EN LOGIN

GO
CREATE PROCEDURE sp_AutenticarUsuario
    @cedula NVARCHAR(50),
    @contraseña NVARCHAR(50)
AS
BEGIN
    SELECT *
    FROM tb_usuarios
    WHERE cedula = @cedula AND contraseña = @contraseña;
END;





--======================================================================================--
--=================================== MODULO PRODUCTOS =================================--
--======================================================================================--

CREATE TABLE Productos (
    id_Producto INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
    Categoria NVARCHAR(100) NOT NULL,
    Marca NVARCHAR(100) NOT NULL,
    CantidadStock INT NOT NULL,
    Precio DECIMAL(10, 2) NOT NULL
);


---- SP para Registrar Producto
GO
CREATE PROCEDURE sp_InsertarProducto
    @Nombre NVARCHAR(100),
    @Categoria NVARCHAR(100),
    @Marca NVARCHAR(100),
    @CantidadStock INT,
    @Precio DECIMAL(10, 2)
AS
BEGIN
    INSERT INTO Productos (Nombre, Categoria, Marca, CantidadStock, Precio)
    VALUES (@Nombre, @Categoria, @Marca, @CantidadStock, @Precio);
END;

-- SP para Mostrar Todos los Productos
GO
CREATE PROCEDURE sp_MostrarProductos
AS
BEGIN
    SELECT id_Producto, Nombre, Categoria, Marca, CantidadStock, Precio
    FROM Productos;
END;

-- SP para Actualizar Producto
GO
CREATE PROCEDURE sp_ActualizarProducto
    @id_Producto INT,
    @Nombre NVARCHAR(100),
    @Categoria NVARCHAR(100),
    @Marca NVARCHAR(100),
    @CantidadStock INT,
    @Precio DECIMAL(10, 2)
AS
BEGIN
    UPDATE Productos
    SET Nombre = @Nombre,
        Categoria = @Categoria,
        Marca = @Marca,
        CantidadStock = @CantidadStock,
        Precio = @Precio
    WHERE id_Producto = @id_Producto;
END;


-- SP para Eliminar Producto
GO
CREATE PROCEDURE sp_EliminarProducto
    @id_Producto INT
AS
BEGIN
    DELETE FROM Productos
    WHERE id_Producto = @id_Producto;
END;





--======================================================================================--
--=================================== MODULO VENTAS ====================================--
--======================================================================================--

CREATE TABLE tb_Ventas (
    id_venta INT IDENTITY(1,1) PRIMARY KEY,
    cedula VARCHAR(10) NOT NULL,
    id_producto INT NOT NULL,
    cantidadDeProducto INT NOT NULL,
    descuento Varchar(5) NOT NULL,
    precioFinal DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (cedula) REFERENCES tb_clientes(cedula),
    FOREIGN KEY (id_producto) REFERENCES Productos(id_Producto)
);

--SP para insertar ventas

GO
CREATE PROCEDURE sp_InsertarVenta
    @cedula VARCHAR(10),
    @id_producto INT,
    @cantidadDeProducto INT,
    @descuento VARCHAR(5),
    @precioFinal DECIMAL(10, 2)
AS
BEGIN
    INSERT INTO tb_Ventas (cedula, id_producto, cantidadDeProducto, descuento, precioFinal)
    VALUES (@cedula, @id_producto, @cantidadDeProducto, @descuento, @precioFinal);
END
GO

--SP para Mostrar Ventas

GO
CREATE PROCEDURE sp_MostrarVentas
AS
BEGIN
    SELECT 
        v.id_venta,
        c.cedula,
        c.nombres,
        c.apellidos,
		p.id_Producto AS id_Producto,
        p.Nombre AS nombreProducto,
        p.Marca AS marcaProducto,
		p.precio AS precioProducto,
        v.cantidadDeProducto,
        v.descuento,
        v.precioFinal
    FROM tb_Ventas v
    INNER JOIN tb_clientes c ON v.cedula = c.cedula
    INNER JOIN Productos p ON v.id_producto = p.id_Producto
END


---SP para Actualizar Ventas
GO
CREATE PROCEDURE sp_ActualizarVenta
    @id_venta INT,
    @cedula VARCHAR(10),
    @id_producto INT,
    @cantidadDeProducto INT,
    @descuento VARCHAR(5),
    @precioFinal DECIMAL(10, 2)
AS
BEGIN
    UPDATE tb_Ventas
    SET 
        cedula = @cedula,
        id_producto = @id_producto,
        cantidadDeProducto = @cantidadDeProducto,
        descuento = @descuento,
        precioFinal = @precioFinal
    WHERE id_venta = @id_venta;
END
GO



--sp para elimnar venta
GO
CREATE PROCEDURE sp_EliminarVenta
    @id_venta INT
AS
BEGIN
    DELETE FROM tb_Ventas
    WHERE id_venta = @id_venta;
END





EXEC sp_InsertarVenta 
    @cedula = '098',
    @id_producto = 1,
    @cantidadDeProducto = 2,
    @descuento = '10',
    @precioFinal = 2700.00;


	-- Mostrar detalles de una venta
EXEC sp_MostrarVentas;


-----------------------------------------INSERTAR VALORES--------------------------------------------------------

--INSERTAR USUARIO PARA INICIAR SESION
INSERT INTO tb_usuarios VALUES ('grupo', 'cuatro', 'correo@correo.com');
select * from tb_usuarios



