using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Entidades
{
    public class Usuario
    {
        //representan los campos de la tabla usuario
        public int      idUsuario     { get; set; }
        public string   apellidos     { get; set; }
        public string   nombres       { get; set; }
        public string   cedula        { get; set; }
        public string   correo        { get; set; }
        public string   telefono      { get; set; }
        public string   direccion     { get; set; }
        public string   rol           { get; set; }
        public DateTime fechaRegistro { get; set; }
        public string   contraseña    { get; set; }
    }
}