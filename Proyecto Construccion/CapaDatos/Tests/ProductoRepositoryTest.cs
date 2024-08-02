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
    internal class ProductoRepositoryTest
    {
        private Productorepository _productoRepository;

        [SetUp]
        public void SetUp()
        {
            _productoRepository = new Productorepository();
        }

        [Test]
        public void Valida_AgregarProductoCorrectamente_DevuelveTrue()
        {
            var resultado = _productoRepository.añadir(new Producto()
            {
                nombre = "Camiseta",
                categoria = "Ropa",
                marca = "Adidas",
                cantidadStock = 50,
                precio = 45.99m
            });

            Assert.That(resultado, Is.True, "Si se agregó correctamente un producto, resultado debería de ser true.");
        }

        [Test]
        public void Valida_EditarProductoCorrectamente_DevuelveTrue()
        {
            var resultado = _productoRepository.editar(new Producto()
            {
                idProducto = 1,
                nombre = "Smartphone",
                categoria = "Electrónica",
                marca = "Samsung",
                cantidadStock = 20,
                precio = 1200.75m
            });

            Assert.That(resultado, Is.True, "Si se editó correctamente un producto, resultado debería de ser true.");
        }

        [Test]
        public void Valida_EliminarProductoCorrectamente_DevuelveTrue()
        {
            var resultado = _productoRepository.eliminar(1);

            Assert.That(resultado, Is.True, "Si se eliminó correctamente un producto, resultado debería de ser true.");
        }

        [Test]
        public void Valida_ObtenerProductosCorrectamente_DevuelveProductos()
        {
            var productos = _productoRepository.obtener();

            Assert.That(productos.Count, Is.Not.EqualTo(0), "Si se obtuvieron correctamente los productos, no debería de estar vacío.");
        }
    }
}
