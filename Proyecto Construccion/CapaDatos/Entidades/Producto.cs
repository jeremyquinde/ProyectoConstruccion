using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Entidades
{
    public class Producto
    {
        //representan los campos de la tabla producto
        public int      idProducto      { get; set; }
        public string   nombre          { get; set; }
        public string   categoria       { get; set; }
        public string   marca           { get; set; }
        public int      cantidadStock   { get; set; }
        public decimal  precio          { get; set; }
    }
}

