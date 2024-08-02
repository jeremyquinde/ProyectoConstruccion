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
    public class VentaRepository : MasterRepository, IVentaRepository
    {
        //implementacion de la IVentaRepository
        //Metodo para añadir los campos de la entidad venta a una lista
        public bool añadir(Venta entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@cedula", entity.cedula.cedula));
            parameters.Add(new SqlParameter("@id_producto", entity.idProducto.idProducto));
            parameters.Add(new SqlParameter("@cantidadDeProducto", entity.cantidadProducto));
            parameters.Add(new SqlParameter("@descuento", entity.descuento));
            parameters.Add(new SqlParameter("@precioFinal ", entity.precioFinal));

            return ExecuteSpNonQuery("sp_InsertarVenta", parameters);
        }

        //Metodo para añadir los campos de la entidad venta a una lista
        public bool editar(Venta entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id_venta", entity.idVenta));
            parameters.Add(new SqlParameter("@cedula", entity.cedula.cedula));
            parameters.Add(new SqlParameter("@id_producto", entity.idProducto.idProducto));
            parameters.Add(new SqlParameter("@cantidadDeProducto", entity.cantidadProducto));
            parameters.Add(new SqlParameter("@descuento", entity.descuento));
            parameters.Add(new SqlParameter("@precioFinal ", entity.precioFinal));

            return ExecuteSpNonQuery("sp_ActualizarVenta", parameters);
        }

        //Metodo para añadir los campos de la entidad venta a una lista
        public bool eliminar(int id)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id_venta", id         ));
            return ExecuteSpNonQuery("sp_EliminarVenta", parameters );
        }

        //Metodo para añadir los campos de la entidad venta, cliente y producto a una lista
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

        //Metodo para añadir los campos de la entidad venta a una lista
        public IEnumerable<Venta> ObtenerInformeVentas(DateTime fechaInicio, DateTime fechaFin)
        {
            parameters = new List<SqlParameter>
            {
                new SqlParameter("@fechaInicio", fechaInicio),
                new SqlParameter("@fechaFin", fechaFin)
            };

            var tableResult = ExecuteSpQuery("sp_InformeVentas", parameters);
            var listVentas = new List<Venta>();

            foreach (DataRow item in tableResult.Rows)
            {
                var producto = new Producto
                {
                    idProducto = Convert.ToInt32(item["id_producto"]),
                    precio = Convert.ToDecimal(item["precio"])
                };

                listVentas.Add(new Venta
                {
                    fechaVenta = Convert.ToDateTime(item["fechaVenta"]),
                    precioFinal = Convert.ToDecimal(item["precioFinal"]),
                    cantidadProducto = Convert.ToInt32(item["cantidadDeProducto"]),
                    descuento = Convert.ToInt32(item["descuento"]),
                    idProducto = producto
                });
            }
            return listVentas;
        }
    }
}
