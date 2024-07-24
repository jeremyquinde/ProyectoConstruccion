using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Entidades
{
    public class Producto
    {
        public int      idProducto      { get; set; }
        public string   nombre          { get; set; }
        public string   categoria       { get; set; }
        public string   marca           { get; set; }
        public int      cantidadStock   { get; set; }
        public decimal  precio          { get; set; }
    }
}


//id_Producto INT PRIMARY KEY IDENTITY(1,1),
//Nombre NVARCHAR(100) NOT NULL,
//Categoria NVARCHAR(100) NOT NULL,
//Marca NVARCHAR(100) NOT NULL,
//CantidadStock INT NOT NULL,
//Precio DECIMAL(10, 2) NOT NULL