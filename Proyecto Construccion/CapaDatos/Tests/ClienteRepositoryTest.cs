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
    internal class ClienteRepositoryTest
    {
        private ClienteRepository _clienteRepository;

        [SetUp]
        public void SetUp()
        {
            _clienteRepository = new ClienteRepository();
        }

        [Test]
        public void Valida_AgregarClienteCorrectamente_DevuelveTrue()
        {
            var resultado = _clienteRepository.añadir(new Cliente()
            {
                apellidos = "Sanchez",
                nombres = "Maria",
                cedula = "34223423",
                correo = "smaria@gmail.com",
                telefono = "87323874",
                direccion = "Calle baja 123"
            });

            Assert.That(resultado, Is.True, "Si se agregó correctamente un cliente, resultado debería de ser true.");
        }

        [Test]
        public void Valida_EditarClienteCorrectamente_DevuelveTrue()
        {
            var resultado = _clienteRepository.editar(new Cliente()
            {
                idCliente = 1,
                apellidos = "Páez",
                nombres = "Carlos",
                cedula = "34287",
                correo = "cpaez@gmail.com",
                telefono = "87843874",
                direccion = "Calle baja 123"
            });

            Assert.That(resultado, Is.True, "Si se editó correctamente un cliente, resultado debería de ser true.");
        }

        [Test]
        public void Valida_EliminarClienteCorrectamente_DevuelveTrue()
        {
            var resultado = _clienteRepository.eliminar(1);

            Assert.That(resultado, Is.True, "Si se eliminó correctamente un cliente, resultado debería de ser true.");
        }

        [Test]
        public void Valida_ObtenerClientesCorrectamente_DevuelveClientes()
        {
            var clientes = _clienteRepository.obtener();

            Assert.That(clientes.Count, Is.Not.EqualTo(0), "Si se obtuvieron correctamente los clientes, no debería de estar vacío.");
        }
    }
}
