using CapaDatos.Contratos;
using CapaDatos.Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Repositorio
{
    public class VentaRepository : MasterRepository, IGenericRepository<Venta>
    {
        public bool añadir(Venta entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@cedula",              entity.cedula.cedula         ));
            parameters.Add(new SqlParameter("@id_producto",         entity.idProducto.idProducto ));
            parameters.Add(new SqlParameter("@cantidadDeProducto",  entity.cantidadProducto      ));
            parameters.Add(new SqlParameter("@descuento",           entity.descuento             ));
            parameters.Add(new SqlParameter("@precioFinal ",        entity.precioFinal           ));
        
            return ExecuteSpNonQuery("sp_InsertarVenta", parameters);
        }
        
        public bool editar(Venta entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id_venta",            entity.idVenta               ));
            parameters.Add(new SqlParameter("@cedula",              entity.cedula.cedula         ));
            parameters.Add(new SqlParameter("@id_producto",         entity.idProducto.idProducto ));
            parameters.Add(new SqlParameter("@cantidadDeProducto",  entity.cantidadProducto      ));
            parameters.Add(new SqlParameter("@descuento",           entity.descuento             )); 
            parameters.Add(new SqlParameter("@precioFinal ",        entity.precioFinal           ));
        
            return ExecuteSpNonQuery("sp_ActualizarVenta", parameters);
        }

        public bool eliminar(int id)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id_venta", id         ));
            return ExecuteSpNonQuery("sp_EliminarVenta", parameters );
        }

        public IEnumerable<Venta> obtener()
        {

            var tableResult = ExecuteSpQuery("sp_MostrarVentas", parameters);
            var listVentas = new List<Venta>();

            foreach (DataRow item in tableResult.Rows)
            {
                var cliente = new Cliente
                {
                    cedula      = item[1].ToString(),
                    nombres     = item[2].ToString(),
                    apellidos   = item[3].ToString(),
                };

                var producto = new Producto
                {
                    idProducto  = Convert.ToInt32(item[4]),
                    nombre      = item[5].ToString(),
                    marca       = item[6].ToString(),
                    precio      = Convert.ToDecimal(item[7])
                };

                listVentas.Add(new Venta
                {
                    idVenta          = Convert.ToInt32(item[0]),
                    cedula           = cliente,
                    idProducto       = producto,
                    cantidadProducto = Convert.ToInt32(item[8]),
                    descuento        = Convert.ToInt32(item[9]),
                    precioFinal      = Convert.ToDecimal(item[10]),

                });
            }
            return listVentas;
        }


    }
}
