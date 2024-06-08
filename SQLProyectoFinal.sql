Create Database [PROYECTO_CONSTRUCCION];
Use [PROYECTO_CONSTRUCCION];

------------------------------------CLIENTES---------------------------------------
-- Create tb_clientes
CREATE TABLE tb_clientes (
    id_cliente INT IDENTITY(1,1) PRIMARY KEY,
    apellidos VARCHAR(50) NOT NULL,
    nombres VARCHAR(50) NOT NULL,
    cedula INT NOT NULL,
    correo VARCHAR(100) NOT NULL,
    telefono INT NOT NULL,
    direccion VARCHAR(100) NOT NULL,
);

-- SP PARA INSERTAR NUEVOS CLIENTES
GO
CREATE PROCEDURE sp_InsertarCliente
    @apellidos VARCHAR(100),
    @nombres VARCHAR(100),
    @cedula INT,
    @correo VARCHAR(100),
    @telefono INT,
    @direccion VARCHAR(20)
AS
BEGIN
    INSERT INTO tb_clientes (apellidos, nombres, cedula, correo, telefono, direccion)
    VALUES (@apellidos, @nombres, @cedula, @correo, @telefono, @direccion);
END;

-- SP PARA MOSTRAR CLIENTES
GO
CREATE PROCEDURE sp_SeleccionarClientes
AS
BEGIN
    SELECT nombres FROM tb_clientes;
END;

-- SP PARA ACTUALIZAR DATOS DE CLIENTES


-- SP PARA ELMINAR CLIENTE SEGUN ID DE CLIENTE
GO
CREATE PROCEDURE sp_Vehiculo_Cliente
    @NombreCliente NVARCHAR(100)
AS
BEGIN
    SELECT
        c.marca,
        c.modelo
    FROM
        tb_clientes c
    WHERE
        c.nombres = @NombreCliente;
END;


----------------------------------------------USUARIOS--------------------------------------------------

--TABLA USUARIOS
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


--SP PARA INSERTAR USUARIO
GO
CREATE PROCEDURE sp_InsertarUsuario
    @apellidos VARCHAR(50) NOT NULL,
    @nombres VARCHAR(50) NOT NULL,
    @cedula INT NOT NULL,
    @correo VARCHAR(100) NOT NULL,
    @telefono INT NOT NULL,
    @direccion VARCHAR(100) NOT NULL,
	@rol VARCHAR(20) NOT NULL,
	@fecha_registro date NOT NULL,
	@contraseña VARCHAR(50)NOT NULL
AS
BEGIN
    INSERT INTO tb_usuarios (apellidos,nombres,cedula,correo,telefono,direccion,rol,fecha_registro,contraseña)
    VALUES (@apellidos,@nombres,@cedula,@correo,@telefono,@direccion,@rol,@fecha_registro,@contraseña)
END


-- SP PARA MOSTRAR USUARIO
GO
CREATE PROCEDURE sp_SeleccionarClientes
AS
BEGIN
    SELECT nombres FROM tb_clientes;
END;

-- SP PARA ACTUALIZAR DATOS DE USUARIO


-- SP PARA ELMINAR CLIENTE SEGUN ID DE USUARIO
GO
CREATE PROCEDURE sp_Vehiculo_Cliente
    @NombreCliente NVARCHAR(100)
AS
BEGIN
    SELECT
        c.marca,
        c.modelo
    FROM
        tb_clientes c
    WHERE
        c.nombres = @NombreCliente;
END;




-----------------------------------------INSERTAR VALORES--------------------------------------------------------

--INSERTAR USUARIO PARA INICIAR SESION
INSERT INTO tb_usuarios VALUES ('grupo', 'cuatro', 'correo@correo.com');
select * from tb_usuarios
