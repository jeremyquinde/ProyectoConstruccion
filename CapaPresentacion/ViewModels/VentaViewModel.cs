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

        public int IdVenta { get; set; }

        public string NombreCliente { get; set; }

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

        public int Descuento { get; set; }

        [Required(ErrorMessage = "El precio final es obligatorio")]
        [Range(0.01, double.MaxValue, ErrorMessage = "El precio final debe ser mayor a 0")]
        public decimal PrecioFinal { get; set; }

        public EntityState State { private get; set; }


        public List<ValidationResult> Validate()
        {
            var validationResults = new List<ValidationResult>();
            var validationContext = new ValidationContext(this, serviceProvider: null, items: null);
            Validator.TryValidateObject(this, validationContext, validationResults, validateAllProperties: true);
            return validationResults;
        }

        public string SaveChanges()
        {
            // Crear las instancias completas de Cliente y Producto
            var cliente = new Cliente
            {
                cedula = Cedula,
                nombres = NombreCliente, // Asumiendo que quieres utilizar NombreCliente también
                apellidos = ApellidoCliente // Asumiendo que quieres utilizar ApellidoCliente también
            };

            var producto = new Producto
            {
                idProducto = IdProducto,
                nombre = NombreProducto, // Asumiendo que quieres utilizar NombreProducto también
                marca = MarcaProducto, // Asumiendo que quieres utilizar MarcaProducto también
                precio = PrecioProducto // Asumiendo que quieres utilizar PrecioProducto también
            };

            // Asignar las instancias completas a VentaModel
            ventaModel.IdVenta = IdVenta;
            ventaModel.Cedula = cliente; // Asignar el objeto `Cliente` completo
            ventaModel.IdProducto = producto; // Asignar el objeto `Producto` completo
            ventaModel.CantidadProducto = CantidadProducto;
            ventaModel.Descuento = Convert.ToInt32(Descuento);
            ventaModel.PrecioFinal = PrecioFinal;
            ventaModel.State = State;

            return ventaModel.SaveChanges();
        }


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
