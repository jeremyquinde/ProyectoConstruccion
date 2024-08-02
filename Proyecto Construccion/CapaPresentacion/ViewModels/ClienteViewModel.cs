using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CapaNegocio.Modelo;
using CapaNegocio.ValueObjects;
using static System.Windows.Forms.AxHost;

namespace CapaPresentacion.ViewModels
{
    public class ClienteViewModel
    {
        private ClienteModel clienteModel;

        public ClienteViewModel()
        {
            clienteModel = new ClienteModel();
        }

        //Atributos mas validaciones de entrada de cada atributo
        public int IdCliente { get; set; }
        public EntityState State { private get; set; } 

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "El nombre debe contener solo letras")]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "El apellido es obligatorio")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "El apellido debe contener solo letras")]
        public string Apellidos { get; set; }

        [Required(ErrorMessage = "La cédula es obligatoria")]
        [RegularExpression(@"^\d+$", ErrorMessage = "La cédula debe contener solo números")]
        public string Cedula { get; set; }

        [Required(ErrorMessage = "El correo es obligatorio")]
        [EmailAddress(ErrorMessage = "Formato de correo inválido")]
        public string Correo { get; set; }

        [Required(ErrorMessage = "El teléfono es obligatorio")]
        [RegularExpression(@"^\d+$", ErrorMessage = "El teléfono debe contener solo números")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "La direccion es obligatorio")]
        public string Direccion { get; set; }

        //Metodo para recoger los mensajes de error en validaciones y retornarlos como lista
        public List<ValidationResult> Validate()
        {
            var validationResults = new List<ValidationResult>();
            var validationContext = new ValidationContext(this, serviceProvider: null, items: null);
            Validator.TryValidateObject(this, validationContext, validationResults, validateAllProperties: true);
            return validationResults;
        }

        //Metodo para mapear los datos hacia cliente model
        public string SaveChanges()
        {
            clienteModel.IdCliente  = IdCliente;
            clienteModel.Nombres    = Nombres;
            clienteModel.Apellidos  = Apellidos;
            clienteModel.Cedula     = Cedula;
            clienteModel.Correo     = Correo;
            clienteModel.Telefono   = Telefono;
            clienteModel.Direccion  = Direccion;
            clienteModel.State      = State;

            return clienteModel.SaveChanges();
        }

        //Metodo para Mapear los datos desde cliente model a viewmodel
        public List<ClienteViewModel> Obtener()
        {
            var clientes = clienteModel.obtener();
            var listViewModel = new List<ClienteViewModel>();

            foreach (var cliente in clientes)
            {
                listViewModel.Add(new ClienteViewModel
                {
                    IdCliente   = cliente.IdCliente,
                    Nombres     = cliente.Nombres,
                    Apellidos   = cliente.Apellidos,
                    Cedula      = cliente.Cedula,
                    Correo      = cliente.Correo,
                    Telefono    = cliente.Telefono,
                    Direccion   = cliente.Direccion
                });
            }

            return listViewModel;
        }


    }

}
