using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Contratos;
using CapaDatos.Entidades;
using CapaDatos.Repositorio;
using CapaNegocio.ValueObjects;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;

namespace CapaNegocio.Modelo
{
    public class ClienteModel
    {
        //Atributos
        private int     _idCliente;
        private string  _apellidos;
        private string  _nombres;
        private string  _cedula;
        private string  _correo;
        private string  _telefono;
        private string  _direccion;


        //Propiedades
        public int    IdCliente { get => _idCliente; set => _idCliente = value; }
        public string Apellidos { get => _apellidos; set => _apellidos = value; }
        public string Nombres   { get => _nombres;   set => _nombres = value;   }
        public string Cedula    { get => _cedula;    set => _cedula = value;    }
        public string Correo    { get => _correo;    set => _correo = value;    }
        public string Telefono  { get => _telefono;  set => _telefono = value;  }
        public string Direccion { get => _direccion; set => _direccion = value; }

        private IGenericRepository<Cliente> _clienteRepository;
        public EntityState State { private get; set; }

        //Metodos

        public ClienteModel()
        {
            _clienteRepository = new ClienteRepository();
        }

        //Metodo que usa entityState para guardar los cambios dependiendo del estado

        public string SaveChanges()
        {
            string message = "";
            try
            {
                var cliente = new Cliente();

                cliente.idCliente  = IdCliente;
                cliente.nombres    = Nombres;
                cliente.apellidos  = Apellidos;
                cliente.cedula     = Cedula;
                cliente.correo     = Correo;
                cliente.telefono   = Telefono;
                cliente.direccion  = Direccion;

                switch (State)
                {
                    case EntityState.Added:
                        _clienteRepository.añadir(cliente);
                        message = "Se registro correctamente";
                        break;
                    case EntityState.Modified:
                        _clienteRepository.editar(cliente);
                        message = "Se edito correctamente";
                        break;
                    case EntityState.Deleted:
                        _clienteRepository.eliminar(IdCliente);
                        message = "Se elimino correctamente";
                        break;
                }

            }
            catch (SqlException ex)
            {
                if (ex.Number == 547) 
                {
                    message = "Primero deben borrarse las ventas asignadas a este cliente.";
                }
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }
            return message;
        }

        //Metodo para obtener los datos de la tabla y devovlerlos como lsita
        public List<ClienteModel> obtener()
        {
            var tablaCliente = _clienteRepository.obtener();
            var listClientes     = new List<ClienteModel>();
            foreach (var item in tablaCliente)
            {
                listClientes.Add(new ClienteModel
                {
                    IdCliente = item.idCliente,
                    Nombres   = item.nombres,
                    Apellidos = item.apellidos,
                    Cedula    = item.cedula,
                    Correo    = item.correo,
                    Telefono  = item.telefono,
                    Direccion = item.direccion,
                });
            }
            return listClientes;
        }



    }
}
