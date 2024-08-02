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
    public class Productorepository : MasterRepository, IGenericRepository<Producto>
    {
        //implementacion de la IGenericRepository
        //Metodo para añadir los campos de la entidad producto a una lista
        public bool añadir(Producto entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@nombre",          entity.nombre           ));
            parameters.Add(new SqlParameter("@categoria",       entity.categoria        ));
            parameters.Add(new SqlParameter("@marca",           entity.marca            ));
            parameters.Add(new SqlParameter("@cantidadStock",   entity.cantidadStock    ));
            parameters.Add(new SqlParameter("@precio",          entity.precio           ));

            return ExecuteSpNonQuery("sp_InsertarProducto", parameters);
        }

        //Metodo para añadir los campos de la entidad producto a una lista
        public bool editar(Producto entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id_Producto",     entity.idProducto       ));
            parameters.Add(new SqlParameter("@nombre",          entity.nombre           ));
            parameters.Add(new SqlParameter("@categoria",       entity.categoria        ));
            parameters.Add(new SqlParameter("@marca",           entity.marca            ));
            parameters.Add(new SqlParameter("@cantidadStock",   entity.cantidadStock    ));
            parameters.Add(new SqlParameter("@precio",          entity.precio           ));      

            return ExecuteSpNonQuery("sp_ActualizarProducto", parameters);
        }

        //Metodo para añadir los campos de la entidad producto a una lista
        public bool eliminar(int id)

        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id_Producto", id));
            return ExecuteSpNonQuery("sp_EliminarProducto", parameters);
        }

        //Metodo para añadir los campos de la entidad producto a una lista
        public IEnumerable<Producto> obtener()
        {
            var parameters = new List<SqlParameter>();
            var tableResult = ExecuteSpQuery("sp_MostrarProductos", parameters);
            var listProductos = new List<Producto>();
            foreach (DataRow item in tableResult.Rows)
            {
                listProductos.Add(new Producto
                {
                    idProducto      = Convert.ToInt32(item[0]),
                    nombre          = item[1].ToString(),
                    categoria       = item[2].ToString(),
                    marca           = item[3].ToString(),
                    cantidadStock   = Convert.ToInt32(item[4].ToString()),
                    precio          = Convert.ToDecimal(item[5].ToString()),

                });
            }
            return listProductos;
        }




    }
}
