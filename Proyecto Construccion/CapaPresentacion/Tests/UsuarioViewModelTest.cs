using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Entidades;
using CapaPresentacion.ViewModels;
using Microsoft.Identity.Client.NativeInterop;
using NUnit.Framework;
using System.ComponentModel.DataAnnotations;

namespace CapaPresentacion.Tests
{
    [TestFixture]
    internal class UsuarioViewModelTest
    {
        [Test]
        public void ValidarDatosIncorrectos()
        {
            UsuarioViewModel usuarioViewModel = new UsuarioViewModel
            {
                Nombres = "Diego95",
                Apellidos = "Zambrano95",
                Cedula = "84328748abc",
                Correo = "correo-invalido",
                Telefono = "48394abc"
            };

            var listaResultados = usuarioViewModel.Validate();

            Assert.That(listaResultados, Is.Not.Empty, "Si los datos asignados al modelo no son validos, la lista de resultados debería contener mensajes de error.");
        }

        [Test]
        public void ValidarDatosCorrectos()
        {
            UsuarioViewModel usuarioViewModel = new UsuarioViewModel
            {
                Nombres = "Diego",
                Apellidos = "Zambrano",
                Cedula = "843287456",
                Correo = "diego@gmail.com",
                Telefono = "483942343"
            };

            var listaResultados = usuarioViewModel.Validate();

            Assert.That(listaResultados, Is.Empty, "Si los datos asignados al modelo son validos, la lista de resultados no debería contener mensajes de error.");
        }

        [Test]
        public void ValidarInicioDeSesionEquivocado()
        {
            UsuarioViewModel usuarioViewModel = new UsuarioViewModel();

            var usuario = usuarioViewModel.AutenticarUsuario("2432423", "sdfsdfd");

            Assert.That(usuario, Is.Null, "Si las credenciales son incorrectas, no debería devolver un usuario.");
        }

        [Test]
        public void ValidarInicioDeSesionCorrecto()
        {
            UsuarioViewModel usuarioViewModel = new UsuarioViewModel();

            var usuario = usuarioViewModel.AutenticarUsuario("123456789", "administrador");

            Assert.That(usuario, Is.Not.Null, "Si las credenciales son correctas, usuario no debería de ser null.");
            Assert.That(usuario.cedula, Is.EqualTo("123456789"), "Si las credenciales son correctas, el usuario debería tener la cédula 123456789.");
        }
    }
}
