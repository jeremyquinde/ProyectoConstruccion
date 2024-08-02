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
    internal class VentaViewModelTest
    {
        [Test]
        public void Valida_AsignacionDeDatosIncorrectos_DevuelveMensajesDeError()
        {
            VentaViewModel ventaViewModel = new VentaViewModel
            {
                Cedula = "343748abc",
                CantidadProducto = 0,
                PrecioFinal = 0
            };

            var listaResultados = ventaViewModel.Validate();

            Assert.That(listaResultados, Is.Not.Empty, "Si los datos asignados al modelo no son validos, la lista de resultados debería contener mensajes de error.");
        }

        [Test]
        public void Valida_AsignacionDeDatosCorrectos_NoDevuelveMensajesDeError()
        {
            VentaViewModel ventaViewModel = new VentaViewModel
            {
                Cedula = "32423434",
                CantidadProducto = 54,
                PrecioFinal = 15
            };

            var listaResultados = ventaViewModel.Validate();

            Assert.That(listaResultados, Is.Empty, "Si los datos asignados al modelo son validos, la lista de resultados no debería contener mensajes de error.");
        }
    }
}
