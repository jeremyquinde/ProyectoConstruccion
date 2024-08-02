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

        //Atributos mas validaciones de entrada de cada atributo
        public int IdProducto { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "El nombre debe contener solo letras")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La categoría es obligatoria")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "La categoria debe contener solo letras")]
        public string Categoria { get; set; }

        [Required(ErrorMessage = "La marca es obligatoria")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "La marca debe contener solo letras")]
        public string Marca { get; set; }

        [Required(ErrorMessage = "La cantidad en stock es obligatoria")]
        [Range(0, int.MaxValue, ErrorMessage = "La cantidad debe ser mayor o igual a 0")]
        public int CantidadStock { get; set; }

        [Required(ErrorMessage = "El precio es obligatorio")]
        [Range(0.01, double.MaxValue, ErrorMessage = "El precio debe ser mayor que 0")]
        public decimal Precio { get; set; }

        public EntityState State { private get; set; }

        //Metodo para recoger los mensajes de error en validaciones y retornarlos como lista
        public List<ValidationResult> Validate()
        {
            var validationResults = new List<ValidationResult>();
            var validationContext = new ValidationContext(this, serviceProvider: null, items: null);
            Validator.TryValidateObject(this, validationContext, validationResults, validateAllProperties: true);
            return validationResults;
        }

        //Metodo para mapear los datos hacia producto model
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

        //Metodo para Mapear los datos desde producto model a viewmodel
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
