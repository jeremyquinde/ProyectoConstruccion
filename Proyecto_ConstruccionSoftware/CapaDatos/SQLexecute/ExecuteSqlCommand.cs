using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaDatos.ConexionDB;
using CapaDatos.Interface;

namespace CapaDatos.SQLexecute
{
    internal class ExecuteSqlCommand
    {
        public bool ExecuteSpNonQuery(string nombre_sp, List<Parametros_sp> lista_parametros)
        {
            var conn = new Conexiondb();
            var conexion = conn.AbrirConexion();
            using (var comando = new SqlCommand(nombre_sp, conexion))
            {
                try
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    if (lista_parametros.Count > 0)
                    {
                        foreach (var parametro in lista_parametros)
                            comando.Parameters.Add(new SqlParameter(parametro.NombreParametro, parametro.TipoDato) 
                            { Value = parametro.ValorParametro });
                    }

                    var resultado = comando.ExecuteNonQuery();
                    return resultado > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al ejecutar el procedimiento almacenado: " + ex.Message);
                    throw;
                }
            }
        }

        public DataTable ExecuteSp(string nombre_sp, List<Parametros_sp> lista_parametros)
        {
            var conn = new Conexiondb();
            var conexion = conn.AbrirConexion();
            using (var comando = new SqlCommand(nombre_sp, conexion))
            {
                try
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    if (lista_parametros != null && lista_parametros.Count > 0)
                    {
                        foreach (var parametro in lista_parametros)
                            comando.Parameters.Add(new SqlParameter(parametro.NombreParametro, parametro.TipoDato) { Value = parametro.ValorParametro });
                    }

                    var adapter = new SqlDataAdapter(comando);
                    var dt = new DataTable();
                    adapter.Fill(dt);

                    return dt;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al ejecutar el procedimiento almacenado: " + ex.Message);
                    throw;
                }
            }
        }


    }
}
