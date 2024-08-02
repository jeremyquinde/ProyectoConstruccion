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
    internal class VentaRepositoryTest
    {
        private VentaRepository _ventaRepository;

        [SetUp]
        public void SetUp()
        {
            _ventaRepository = new VentaRepository();
        }

        [Test]
        public void AgregarVentaCorrectamente()
        {
            var resultado = _ventaRepository.añadir(new Venta()
            {
                cedula = new Cliente { cedula = "34287" },
                idProducto = new Producto { idProducto = 1 },
                cantidadProducto = 5,
                descuento = 10,
                precioFinal = 100.00m
            });

            Assert.That(resultado, Is.True, "Si se agregó correctamente una venta, resultado debería de ser true.");
        }

        [Test]
        public void EditarVentaCorrectamente()
        {
            var resultado = _ventaRepository.editar(new Venta()
            {
                idVenta = 2,
                cedula = new Cliente { cedula = "34287" },
                idProducto = new Producto { idProducto = 1 },
                cantidadProducto = 3,
                descuento = 15,
                precioFinal = 200.00m
            });

            Assert.That(resultado, Is.True, "Si se editó correctamente una venta, resultado debería de ser true.");
        }

        [Test]
        public void EliminarVentaCorrectamente()
        {
            var resultado = _ventaRepository.eliminar(2);

            Assert.That(resultado, Is.True, "Si se eliminó correctamente una venta, resultado debería de ser true.");
        }

        [Test]
        public void ObtenerVentasCorrectamente()
        {
            var ventas = _ventaRepository.obtener();

            Assert.That(ventas.Count, Is.Not.EqualTo(0), "Si se obtuvieron correctamente los ventas, no debería de estar vacío.");
        }
    }
}
