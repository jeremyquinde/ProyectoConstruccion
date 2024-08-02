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
    internal class ProductoViewModelTest
    {
        [Test]
        public void Valida_AsignacionDeDatosIncorrectos_DevuelveMensajesDeError()
        {
            ProductoViewModel productoViewModel = new ProductoViewModel
            {
                Nombre = "",
                Categoria = "",
                Marca = "",
                CantidadStock = -1,
                Precio = 0
            };

            var listaResultados = productoViewModel.Validate();

            Assert.That(listaResultados, Is.Not.Empty, "Si los datos asignados al modelo no son validos, la lista de resultados debería contener mensajes de error.");
        }

        [Test]
        public void Valida_AsignacionDeDatosCorrectos_NoDevuelveMensajesDeError()
        {
            ProductoViewModel productoViewModel = new ProductoViewModel
            {
                Nombre = "Camiseta",
                Categoria = "Ropa",
                Marca = "Adidas",
                CantidadStock = 54,
                Precio = 45
            };

            var listaResultados = productoViewModel.Validate();

            Assert.That(listaResultados, Is.Empty, "Si los datos asignados al modelo son validos, la lista de resultados no debería contener mensajes de error.");
        }
    }
}
