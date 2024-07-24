using CapaDatos.Entidades;
using CapaNegocio.Modelo;
using CapaNegocio.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CapaPresentacion.ViewModels
{
    public class ProductoViewModel
    {
        private ProductoModel _productoModel;

        public ProductoViewModel()
        {
            _productoModel = new ProductoModel();
        }

        public int IdProducto { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La categoría es obligatoria")]
        public string Categoria { get; set; }

        [Required(ErrorMessage = "La marca es obligatoria")]
        public string Marca { get; set; }

        [Required(ErrorMessage = "La cantidad en stock es obligatoria")]
        [Range(0, int.MaxValue, ErrorMessage = "La cantidad debe ser mayor o igual a 0")]
        public int CantidadStock { get; set; }

        [Required(ErrorMessage = "El precio es obligatorio")]
        [Range(0.01, double.MaxValue, ErrorMessage = "El precio debe ser mayor que 0")]
        public decimal Precio { get; set; }

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
            _productoModel.IdProducto = IdProducto;
            _productoModel.Nombre = Nombre;
            _productoModel.Categoria = Categoria;
            _productoModel.Marca = Marca;
            _productoModel.CantidadStock = CantidadStock;
            _productoModel.Precio = Precio;
            _productoModel.State = State;

            return _productoModel.SaveChanges();
        }

        public List<ProductoViewModel> Obtener()
        {
            var productos = _productoModel.obtener();
            var listViewModel = new List<ProductoViewModel>();

            foreach (var producto in productos)
            {
                listViewModel.Add(new ProductoViewModel
                {
                    IdProducto = producto.IdProducto,
                    Nombre = producto.Nombre,
                    Categoria = producto.Categoria,
                    Marca = producto.Marca,
                    CantidadStock = producto.CantidadStock,
                    Precio = producto.Precio
                });
            }

            return listViewModel;
        }
    }
}
