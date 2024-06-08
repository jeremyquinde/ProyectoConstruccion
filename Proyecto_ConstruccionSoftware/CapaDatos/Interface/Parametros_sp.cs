using System;
using System.Data;

namespace CapaDatos.Interface
{
    public class Parametros_sp
    {
        public string NombreParametro { get; set; }
        public object ValorParametro { get; set; }
        public SqlDbType TipoDato { get; set; }

        public Parametros_sp(string nombre_parametro, object valor_parametro, SqlDbType tipo_dato)
        {
            NombreParametro = nombre_parametro;
            ValorParametro = valor_parametro;
            TipoDato = tipo_dato;
        }
    }
}
