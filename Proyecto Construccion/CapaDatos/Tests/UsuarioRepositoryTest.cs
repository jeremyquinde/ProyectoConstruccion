using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Entidades;
using CapaDatos.Repositorio;
using NUnit.Framework;

namespace CapaDatos.Tests
{
    [TestFixture]
    internal class UsuarioRepositoryTest
    {
        private UsuarioRepository _usuarioRepository;

        [SetUp]
        public void SetUp()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        [Test]
        public void Valida_InicioDeSesionEquivocado_NoDevuelveUsuario()
        {
            var usuario = _usuarioRepository.AutenticarUsuario("2432423", "sdfsdfd");

            Assert.That(usuario, Is.Null, "Si las credenciales son incorrectas, no debería devolver un usuario.");
        }

        [Test]
        public void Valida_InicioDeSesionCorrecto_DevuelveUsuario()
        {
            var usuario = _usuarioRepository.AutenticarUsuario("123456789", "administrador");

            Assert.That(usuario, Is.Not.Null, "Si las credenciales son correctas, usuario no debería de ser null.");
            Assert.That(usuario.cedula, Is.EqualTo("123456789"), "Si las credenciales son correctas, el usuario debería tener la cédula 123456789.");
        }

        [Test]
        public void Valida_ObtenerUsuariosCorrectamente_DevuelveUsuarios()
        {
            var usuarios = _usuarioRepository.obtener();

            Assert.That(usuarios.Count, Is.Not.EqualTo(0), "Si se obtuvieron correctamente los usuarios, no debería de estar vacío.");
        }

        [Test]
        public void Valida_AgregarUsuarioCorrectamente_DevuelveTrue()
        {
            var resultado = _usuarioRepository.añadir(new Usuario()
            {
                apellidos = "Peralta",
                nombres = "Carlos",
                cedula = "34287",
                correo = "cperalet@gmail.com",
                telefono = "87843874",
                direccion = "Calle baja 123",
                rol = "administrador",
                fechaRegistro = DateTime.Now,
                contraseña = "administrador"
            });

            Assert.That(resultado, Is.True, "Si se agregó correctamente un usuario, resultado debería de ser true.");
        }

        [Test]
        public void Valida_EditarUsuarioCorrectamente_DevuelveTrue()
        {
            var resultado = _usuarioRepository.editar(new Usuario()
            {
                idUsuario = 1,
                apellidos = "Páez",
                nombres = "Carlos",
                cedula = "34287",
                correo = "cpaez@gmail.com",
                telefono = "87843874",
                direccion = "Calle baja 123",
                rol = "administrador",
                fechaRegistro = new DateTime(2024, 07, 24),
                contraseña = "administrador"
            });

            Assert.That(resultado, Is.True, "Si se editó correctamente un usuario, resultado debería de ser true.");
        }

        [Test]
        public void Valida_EliminarUsuarioCorrectamente_DevuelveTrue()
        {
            var resultado = _usuarioRepository.eliminar(4);

            Assert.That(resultado, Is.True, "Si se eliminó correctamente un usuario, resultado debería de ser true.");
        }
        
    }
}
