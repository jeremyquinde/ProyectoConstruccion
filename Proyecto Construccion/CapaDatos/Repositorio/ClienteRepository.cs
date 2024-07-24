using CapaDatos.Contratos;
using CapaDatos.Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Repositorio
{
    public class ClienteRepository : MasterRepository, IGenericRepository<Cliente>
    {
        //implementacion de la IGenericRepository
        public bool añadir(Cliente entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@apellidos", entity.apellidos));
            parameters.Add(new SqlParameter("@nombres",   entity.nombres));
            parameters.Add(new SqlParameter("@cedula",    entity.cedula));
            parameters.Add(new SqlParameter("@correo",    entity.correo));
            parameters.Add(new SqlParameter("@telefono",  entity.telefono));
            parameters.Add(new SqlParameter("@direccion", entity.direccion));

            return ExecuteSpNonQuery("sp_InsertarCliente", parameters);
        }

        public bool editar(Cliente entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id_cliente", entity.idCliente));
            parameters.Add(new SqlParameter("@apellidos", entity.apellidos));
            parameters.Add(new SqlParameter("@nombres", entity.nombres));
            parameters.Add(new SqlParameter("@cedula", entity.cedula));
            parameters.Add(new SqlParameter("@correo", entity.correo));
            parameters.Add(new SqlParameter("@telefono", entity.telefono));
            parameters.Add(new SqlParameter("@direccion", entity.direccion));

            return ExecuteSpNonQuery("sp_ActualizarCliente", parameters);
        }

        public bool eliminar(int id)

        {
            parameters= new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id_cliente", id));
            return ExecuteSpNonQuery("sp_EliminarCliente", parameters);
        }

        public IEnumerable<Cliente> obtener()
        {
            var tableResult = ExecuteSpQuery("sp_MostrarClientes", parameters);
            var listClientes = new List<Cliente>();
            foreach (DataRow item in tableResult.Rows)
            {
                listClientes.Add(new Cliente
                {
                    idCliente = Convert.ToInt32(item[0]),
                    nombres   = item[1].ToString(),
                    apellidos = item[2].ToString(),
                    cedula    = item[3].ToString(),
                    correo    = item[4].ToString(),
                    telefono  = item[5].ToString(),
                    direccion = item[6].ToString(),

                });
            }
            return listClientes;
        }

    }
}
