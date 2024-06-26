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
        //Verifica si el m�todo devuelve true cuando se le pasan n�meros v�lidos.
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

        //Verifica si el m�todo devuelve false cuando no se le pasan numeros
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
      
        //Verifica si el m�todo devuelve false cuando se le pasa una cadena vac�a.
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


        //verifica si el m�todo devuelve true cuando se le pasan credenciales v�lidas.
        [Test]
        public void AutenticarUsuario_CredencialesValidas()
        {
            // Arrange
            string cedula = "0912345678";
            string contrase�a = "admincontrasena";

            // Act
            bool resultado = negocio.AutenticarUsuario(cedula, contrase�a);

            // Assert
            Assert.IsTrue(resultado);
        }
        //Verifica si el m�todo devuelve false cuando se le pasa una cedula inv�lida.
        [Test]
        public void AutenticarUsuario_CedulaInvalida()
        {
            // Arrange
            string cedulaInvalida = "9876543210";
            string contrase�a = "password";

            // Act
            bool resultado = negocio.AutenticarUsuario(cedulaInvalida, contrase�a);

            // Assert
            Assert.IsFalse(resultado);
        }
        //Verifica si el m�todo devuelve false cuando se le pasa una contrase�a incorrecta.
        [Test]
        public void AutenticarUsuario_Contrase�aIncorrecta()
        {
            // Arrange
            string cedula = "1234567890";
            string contrase�aIncorrecta = "wrongpassword";

            // Act
            bool resultado = negocio.AutenticarUsuario(cedula, contrase�aIncorrecta);

            // Assert
            Assert.IsFalse(resultado);
        }



        //Verifica si el m�todo devuelve true cuando se le pasan datos v�lidos.
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

        //Verifica si el m�todo devuelve false cuando se le pasan datos inv�lidos.
        [Test]
        public void GuardarCliente_DatosInvalidos()
        {
            // Arrange
            string nombre = ""; // Nombre vac�o
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



        //Verifica si el m�todo devuelve una tabla con datos.
        [Test]
        public void consultarClientes_DeberiaRetornarTablaConDatos()
        {
            // Arrange & Act
            DataTable resultado = negocio.consultarClientes();

            // Assert
            Assert.IsNotNull(resultado);
            Assert.Greater(resultado.Rows.Count, 0); // la tabla tendra al menos una fila
        }
        //Verifica si el m�todo devuelve una tabla vac�a.
        [Test]
        public void consultarClientes_DeberiaRetornarTablaVacia()
        {
            // Arrange & Act
            DataTable resultado = negocio.consultarClientes();

            // Assert
            Assert.IsNotNull(resultado);
            Assert.AreEqual(0, resultado.Rows.Count); // la tabla esta vac�a
        }
    }
}