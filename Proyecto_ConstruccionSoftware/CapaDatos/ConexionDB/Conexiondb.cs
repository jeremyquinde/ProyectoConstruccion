using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos.ConexionDB
{
    public class Conexiondb
    {
        private readonly SqlConnection conexion = new SqlConnection("server=DESKTOP-9HVD4MR; database=PROYECTO_CONSTRUCCION; Integrated Security=true");

        public SqlConnection AbrirConexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                    Console.WriteLine("Conexión abierta correctamente");
                }

                return conexion;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir conexión: " + ex.Message);
                throw;
            }
        }

        public SqlConnection CerrarConexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                    Console.WriteLine("Conexión cerrada correctamente");
                }

                return conexion;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cerrar conexión: " + ex.Message);
                throw;
            }
        }
    }
}
