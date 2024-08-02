using CapaDatos.Entidades;
using CapaNegocio.Modelo;
using CapaNegocio.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion.ViewModels
{
    public class UsuarioViewModel
    {
        private UsuarioModel _usuarioModel;

        public UsuarioViewModel()
        {
            _usuarioModel = new UsuarioModel();
        }

        //Atributos mas validaciones de entrada de cada atributo
        public int  IdUsuario           { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "El nombre debe contener solo letras")]
        public string   Nombres         { get; set; }

        [Required(ErrorMessage = "El apellido es obligatorio")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "El apellido debe contener solo letras")]
        public string   Apellidos       { get; set; }

        [Required(ErrorMessage = "La cédula es obligatoria")]
        [RegularExpression(@"^\d+$", ErrorMessage = "La cédula debe contener solo números")]
        public string   Cedula          { get; set; }

        [Required(ErrorMessage = "El correo es obligatorio")]
        [EmailAddress(ErrorMessage = "Formato de correo inválido")]
        public string   Correo          { get; set; }

        [Required(ErrorMessage = "El teléfono es obligatorio")]
        [RegularExpression(@"^\d+$", ErrorMessage = "El teléfono debe contener solo números")]
        public string   Telefono        { get; set; }

        [Required(ErrorMessage = "La direccion es obligatorio")]
        public string   Direccion       { get; set; }

        [Required(ErrorMessage = "La rol es obligatorio")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "El rol debe contener solo letras")]
        public string   Rol             { get ; set; }

        public DateTime FechaRegistro   { get ; set ; }
        
        [Required(ErrorMessage = "La contraseña es obligatoria")]
        public string   Contraseña      { get; set; }

        public EntityState State        { private get; set; }


        //Metodo para recoger los mensajes de error en validaciones y retornarlos como lista
        public List<ValidationResult> Validate()
        {
            var validationResults = new List<ValidationResult>();
            var validationContext = new ValidationContext(this, serviceProvider: null, items: null);
            Validator.TryValidateObject(this, validationContext, validationResults, validateAllProperties: true);
            return validationResults;
        }

        //Metodo para mapear los datos hacia usuario model
        public string SaveChanges()
        {
            _usuarioModel.IdUsuario     = IdUsuario;
            _usuarioModel.Nombres       = Nombres;
            _usuarioModel.Apellidos     = Apellidos;
            _usuarioModel.Cedula        = Cedula;
            _usuarioModel.Correo        = Correo;
            _usuarioModel.Telefono      = Telefono;
            _usuarioModel.Direccion     = Direccion;
            _usuarioModel.Rol           = Rol;
            _usuarioModel.FechaRegistro = FechaRegistro;
            _usuarioModel.Contraseña    = Contraseña;
            _usuarioModel.State         = State;

            return _usuarioModel.SaveChanges();
        }

        //Metodo para Mapear los datos desde usuario model a viewmodel
        public List<UsuarioViewModel> Obtener()
        {
            var usuarios = _usuarioModel.obtener();
            var listViewModel = new List<UsuarioViewModel>();

            foreach (var usuario in usuarios)
            {
                listViewModel.Add(new UsuarioViewModel
                {
                    IdUsuario       = usuario.IdUsuario,
                    Nombres         = usuario.Nombres,
                    Apellidos       = usuario.Apellidos,
                    Cedula          = usuario.Cedula,
                    Correo          = usuario.Correo,
                    Telefono        = usuario.Telefono,
                    Direccion       = usuario.Direccion,
                    Rol             = usuario.Rol,
                    FechaRegistro   = usuario.FechaRegistro,
                    Contraseña      = usuario.Contraseña,
                });
            }

            return listViewModel;
        }


        public Usuario AutenticarUsuario(string cedula, string contraseña)
        {
            return _usuarioModel.AutenticarUsuario(cedula, contraseña);
        }



    }
}
