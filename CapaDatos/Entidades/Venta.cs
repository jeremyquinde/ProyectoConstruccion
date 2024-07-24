using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Entidades
{
    public class Venta
    {
        public int      idVenta          {  get; set; }
        public Cliente  cedula           { get; set; }
        public Producto idProducto       { get; set; }
        public int      cantidadProducto {  get; set; }
        public int      descuento        { get; set; }
        public decimal  precioFinal      {  get; set; }
    }
}
