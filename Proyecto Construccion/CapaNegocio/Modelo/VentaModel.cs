using CapaDatos.Contratos;
using CapaDatos.Entidades;
using CapaDatos.Repositorio;
using CapaNegocio.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Modelo
{
    public class VentaModel
    {

        //Atributos
        private int      _idVenta;
        private Cliente  _cedula;
        private Producto _idProducto;
        private int      _cantidadProducto;
        private int      _descuento;
        private decimal  _precioFinal;
        public DateTime FechaVenta { get; set; }


        //Propiedades
        public int      IdVenta          { get => _idVenta;          set => _idVenta          = value;  }
        public Cliente  Cedula           { get => _cedula;           set => _cedula           = value;  }
        public Producto IdProducto       { get => _idProducto;       set => _idProducto       = value;  }
        public int      CantidadProducto { get => _cantidadProducto; set => _cantidadProducto = value;  }
        public int      Descuento        { get => _descuento;        set => _descuento        = value;  }
        public decimal  PrecioFinal      { get => _precioFinal;      set => _precioFinal      = value;  }

        private IVentaRepository _ventaRepository;
        public EntityState State { private get; set; }

        // Métodos
        public VentaModel()
        {
            _ventaRepository = new VentaRepository();
        }

        //Metodo para calcular y mostrar el precio final
        public void CalcularPrecioFinal()
        {
            decimal descuentoDecimal = Descuento / 100m;
            PrecioFinal = CantidadProducto * IdProducto.precio * (1 - descuentoDecimal);
        }

        //Metodo para calcular los totales de ventas, y los precios con y sin descuentos
        public (int TotalVentas, decimal TotalIngresos, decimal TotalBeneficio) CalcularTotales(List<VentaModel> ventas)
        {
            int totalVentas = ventas.Count;
            decimal totalIngresos = ventas.Sum(v => v.PrecioFinal);
            decimal totalBeneficio = ventas.Sum(v => v.CantidadProducto * v.IdProducto.precio);

            return (totalVentas, totalIngresos, totalBeneficio);
        }

        //Metodo que usa entityState para guardar los cambios dependiendo del estado
        public string SaveChanges()
        {
            string message = "";
            try
            {
                var venta = new Venta();

                venta.idVenta             = IdVenta;
                venta.cedula              = Cedula;       
                venta.idProducto          = IdProducto;
                venta.cantidadProducto    = CantidadProducto;
                venta.descuento           = Descuento;
                venta.precioFinal         = PrecioFinal;

                switch (State)
                {
                    case EntityState.Added:
                        _ventaRepository.añadir(venta);
                        message = "Se registro correctamente";
                        break;
                    case EntityState.Modified:
                        _ventaRepository.editar(venta);
                        message = "Se edito correctamente";
                        break;
                    case EntityState.Deleted:
                        _ventaRepository.eliminar(IdVenta);
                        message = "Se elimino correctamente";
                        break;
                }
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }
            return message;
        }

        //Metodo para obtener los datos de la tabla
        public List<VentaModel> obtener()
        {
            var tablaVenta = _ventaRepository.obtener();
            var listVentas = new List<VentaModel>();
            foreach (var item in tablaVenta)
            {
                listVentas.Add(new VentaModel
                {
                    IdVenta             = item.idVenta,
                    Cedula              = item.cedula,
                    IdProducto          = item.idProducto,
                    CantidadProducto    = item.cantidadProducto,
                    Descuento           = item.descuento,
                    PrecioFinal         = item.precioFinal,
                });
            }
            return listVentas;
        }

        
        //Metodo apra obtener y asignar el informe de las ventas
        public List<VentaModel> ObtenerInformeVentas(DateTime fechaInicio, DateTime fechaFin)
        {
            var tablaVenta = _ventaRepository.ObtenerInformeVentas(fechaInicio, fechaFin);
            var listVentas = new List<VentaModel>();
            foreach (var item in tablaVenta)
            {
                listVentas.Add(new VentaModel
                {
                    FechaVenta = item.fechaVenta,
                    IdProducto = item.idProducto,
                    CantidadProducto = item.cantidadProducto,
                    Descuento = item.descuento,
                    PrecioFinal = item.precioFinal
                });
            }
            return listVentas;
        }


    }
}
