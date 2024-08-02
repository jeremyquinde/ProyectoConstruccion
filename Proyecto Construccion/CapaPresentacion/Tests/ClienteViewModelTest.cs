using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CapaPresentacion.ViewModels;

namespace CapaPresentacion.Tests
{
    [TestFixture]
    internal class ClienteViewModelTest
    {
        [Test]
        public void ValidacionDatosIncorrectos()
        {
            ClienteViewModel clienteViewModel = new ClienteViewModel
            {
                Nombres = "Diego95",
                Apellidos = "Zambrano95",
                Cedula = "84328748abc",
                Correo = "correo-invalido",
                Telefono = "48394abc"
            };

            var listaResultados = clienteViewModel.Validate();

            Assert.That(listaResultados, Is.Not.Empty, "Si los datos asignados al modelo no son validos, la lista de resultados debería contener mensajes de error.");
        }

        [Test]
        public void ValidaDatosCorrectos()
        {
            ClienteViewModel clienteViewModel = new ClienteViewModel
            {
                Nombres = "Diego",
                Apellidos = "Zambrano",
                Cedula = "843287456",
                Correo = "diego@gmail.com",
                Telefono = "483942343"
            };

            var listaResultados = clienteViewModel.Validate();

            Assert.That(listaResultados, Is.Empty, "Si los datos asignados al modelo son validos, la lista de resultados no debería contener mensajes de error.");
        }
    }
}
