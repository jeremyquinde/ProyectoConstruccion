using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CapaDatos.Entidades;
using CapaNegocio.Modelo;
using CapaNegocio.ValueObjects;

namespace CapaPresentacion.ViewModels
{
    public class VentaViewModel
    {
        private VentaModel ventaModel;

        public VentaViewModel()
        {
            ventaModel = new VentaModel();
        }

        //Atributos mas validaciones de entrada de cada atributo
        public int IdVenta { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "El nombre debe contener solo letras")]
        public string NombreCliente { get; set; }

        [Required(ErrorMessage = "El apellido es obligatorio")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "El apellido debe contener solo letras")]
        public string ApellidoCliente { get; set; }

        [Required(ErrorMessage = "La cédula es obligatoria")]
        [RegularExpression(@"^\d+$", ErrorMessage = "La cédula debe contener solo números")]
        public string Cedula { get; set; }

        [Required(ErrorMessage = "El ID del producto es obligatorio")]
        public int IdProducto { get; set; }

        public string NombreProducto { get; set; }

        public string MarcaProducto { get; set; }

        public decimal PrecioProducto { get; set; }

        [Required(ErrorMessage = "La cantidad de producto es obligatoria")]
        [Range(1, int.MaxValue, ErrorMessage = "La cantidad debe ser mayor a 0")]
        public int CantidadProducto { get; set; }

        [Required(ErrorMessage = "El descuento es obligatorio")]
        public int Descuento { get; set; }

        [Required(ErrorMessage = "El precio final es obligatorio")]
        [Range(0.01, double.MaxValue, ErrorMessage = "El precio final debe ser mayor a 0")]
        public decimal PrecioFinal { get; set; }
        public DateTime FechaVenta { get; set; }
        public EntityState State { private get; set; }

        //Metodo para mostrar el precio final en formulario
        public void CalcularPrecioFinal()
        {
            ventaModel.IdProducto = new Producto { precio = PrecioProducto };
            ventaModel.CantidadProducto = CantidadProducto;
            ventaModel.Descuento = Descuento;
            ventaModel.CalcularPrecioFinal();
            PrecioFinal = ventaModel.PrecioFinal;
        }

        //Metodo para mostrar los calculos totales en formulario
        public (int TotalVentas, decimal TotalIngresos, decimal TotalBeneficio) CalcularTotales(List<VentaViewModel> ventas)
        {
            var ventasModel = ventas.Select(v => new VentaModel
            {
                IdProducto = new Producto { precio = v.PrecioProducto },
                CantidadProducto = v.CantidadProducto,
                PrecioFinal = v.PrecioFinal
            }).ToList();

            return ventaModel.CalcularTotales(ventasModel);
        }


        //Metodo para Obtener para mapear los campos de ventaModel
        public List<VentaViewModel> ObtenerInformeVentas(DateTime fechaInicio, DateTime fechaFin)
        {
            var ventas = ventaModel.ObtenerInformeVentas(fechaInicio, fechaFin);
            var listViewModel = new List<VentaViewModel>();

            foreach (var venta in ventas)
            {
                listViewModel.Add(new VentaViewModel
                {
                    FechaVenta = venta.FechaVenta,
                    IdProducto = venta.IdProducto.idProducto,
                    CantidadProducto = venta.CantidadProducto,
                    Descuento = venta.Descuento,
                    PrecioFinal = venta.PrecioFinal,
                    PrecioProducto = venta.IdProducto.precio
                });
            }

            return listViewModel;
        }

        //Metodo para recoger los mensajes de error en validaciones y retornarlos como lista
        public List<ValidationResult> Validate()
        {
            var validationResults = new List<ValidationResult>();
            var validationContext = new ValidationContext(this, serviceProvider: null, items: null);
            Validator.TryValidateObject(this, validationContext, validationResults, validateAllProperties: true);
            return validationResults;
        }

        //Metodo para mapear los datos hacia venta model
        public string SaveChanges()
        {
            var cliente = new Cliente
            {
                cedula = Cedula,
                nombres = NombreCliente,
                apellidos = ApellidoCliente
            };

            var producto = new Producto
            {
                idProducto = IdProducto,
                nombre = NombreProducto, 
                marca = MarcaProducto, 
                precio = PrecioProducto 
            };

            ventaModel.IdVenta = IdVenta;
            ventaModel.Cedula = cliente; 
            ventaModel.IdProducto = producto; 
            ventaModel.CantidadProducto = CantidadProducto;
            ventaModel.Descuento = Convert.ToInt32(Descuento);
            ventaModel.PrecioFinal = PrecioFinal;
            ventaModel.State = State;

            return ventaModel.SaveChanges();
        }

        //Metodo para Mapear los datos desde venta model a viewmodel
        public List<VentaViewModel> Obtener()
        {
            var ventas = ventaModel.obtener();
            var listViewModel = new List<VentaViewModel>();

            foreach (var venta in ventas)
            {
                listViewModel.Add(new VentaViewModel
                {
                    IdVenta = venta.IdVenta,
                    Cedula = venta.Cedula.cedula,
                    NombreCliente = venta.Cedula.nombres,
                    ApellidoCliente = venta.Cedula.apellidos,
                    IdProducto = venta.IdProducto.idProducto,
                    NombreProducto = venta.IdProducto.nombre,
                    MarcaProducto = venta.IdProducto.marca,
                    PrecioProducto = venta.IdProducto.precio,
                    CantidadProducto = venta.CantidadProducto,
                    Descuento = venta.Descuento,
                    PrecioFinal = venta.PrecioFinal
                });
            }

            return listViewModel;
        }


    }
}
