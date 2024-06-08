using CapaDatos.Interface;
using System.Data;

namespace TestProjecto
{
    [TestFixture]
    public class InterfaceNegocioTests
    {
        private InterfaceNegocio negocio;

        [SetUp]
        public void SetUp()
        {
            negocio = new InterfaceNegocio();
        }
        //Verifica si el método devuelve true cuando se le pasan números válidos.
        [Test]
        public void EsNumero_NumerosValidos()
        {
            // Arrange
            string[] numerosValidos = { "123", "456", "789" };

            // Act
            bool resultado = negocio.esNumero(numerosValidos);

            // Assert
            Assert.IsTrue(resultado);
        }

        //Verifica si el método devuelve false cuando no se le pasan numeros
        [Test]
        public void EsNumero_NoNumeros()
        {
            // Arrange
            string[] cadenasNoNumericas = { "abc", "def", "ghi" };

            // Act
            bool resultado = negocio.esNumero(cadenasNoNumericas);

            // Assert
            Assert.IsFalse(resultado);
        }
      
        //Verifica si el método devuelve false cuando se le pasa una cadena vacía.
        [Test]
        public void EsNumero_ConString()
        {
            // Arrange
            string[] numerosYUnaCadenaVacia = { "123", "456", "" };

            // Act
            bool resultado = negocio.esNumero(numerosYUnaCadenaVacia);

            // Assert
            Assert.IsTrue(resultado);
        }


        //verifica si el método devuelve true cuando se le pasan credenciales válidas.
        [Test]
        public void AutenticarUsuario_CredencialesValidas()
        {
            // Arrange
            string cedula = "0912345678";
            string contraseña = "admincontrasena";

            // Act
            bool resultado = negocio.AutenticarUsuario(cedula, contraseña);

            // Assert
            Assert.IsTrue(resultado);
        }
        //Verifica si el método devuelve false cuando se le pasa una cedula inválida.
        [Test]
        public void AutenticarUsuario_CedulaInvalida()
        {
            // Arrange
            string cedulaInvalida = "9876543210";
            string contraseña = "password";

            // Act
            bool resultado = negocio.AutenticarUsuario(cedulaInvalida, contraseña);

            // Assert
            Assert.IsFalse(resultado);
        }
        //Verifica si el método devuelve false cuando se le pasa una contraseña incorrecta.
        [Test]
        public void AutenticarUsuario_ContraseñaIncorrecta()
        {
            // Arrange
            string cedula = "1234567890";
            string contraseñaIncorrecta = "wrongpassword";

            // Act
            bool resultado = negocio.AutenticarUsuario(cedula, contraseñaIncorrecta);

            // Assert
            Assert.IsFalse(resultado);
        }



        //Verifica si el método devuelve true cuando se le pasan datos válidos.
        [Test]
        public void GuardarCliente_DatosValidos()
        {
            // Arrange
            string nombre = "John";
            string apellido = "Doe";
            int cedula = 1234567890;
            string correo = "john@example.com";
            int telefono = 123456789;
            string direccion = "123 Main St";

            // Act
            bool resultado = negocio.GuardarCliente(nombre, apellido, cedula, correo, telefono, direccion);

            // Assert
            Assert.IsTrue(resultado);
        }

        //Verifica si el método devuelve false cuando se le pasan datos inválidos.
        [Test]
        public void GuardarCliente_DatosInvalidos()
        {
            // Arrange
            string nombre = ""; // Nombre vacío
            string apellido = "Doe";
            int cedula = 1234567890;
            string correo = "john@example.com";
            int telefono = 123456789;
            string direccion = "123 Main St";

            // Act
            bool resultado = negocio.GuardarCliente(nombre, apellido, cedula, correo, telefono, direccion);

            // Assert
            Assert.IsFalse(resultado);
        }



        //Verifica si el método devuelve una tabla con datos.
        [Test]
        public void consultarClientes_DeberiaRetornarTablaConDatos()
        {
            // Arrange & Act
            DataTable resultado = negocio.consultarClientes();

            // Assert
            Assert.IsNotNull(resultado);
            Assert.Greater(resultado.Rows.Count, 0); // la tabla tendra al menos una fila
        }
        //Verifica si el método devuelve una tabla vacía.
        [Test]
        public void consultarClientes_DeberiaRetornarTablaVacia()
        {
            // Arrange & Act
            DataTable resultado = negocio.consultarClientes();

            // Assert
            Assert.IsNotNull(resultado);
            Assert.AreEqual(0, resultado.Rows.Count); // la tabla esta vacía
        }
    }
}