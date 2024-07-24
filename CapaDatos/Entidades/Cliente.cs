using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Entidades
{
    public class Cliente
    {
        //representan las entidades de la base de datos
        public int     idCliente { get; set; }
        public string  nombres   { get; set; }
        public string  apellidos { get; set; }
        public string  cedula    { get; set; }
        public string  correo    { get; set; }
        public string  telefono  { get; set; }
        public string  direccion {  get; set; }
    }
}
