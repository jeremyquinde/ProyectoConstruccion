using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.Data.SqlClient;
using Microsoft.Data;


namespace CapaDatos.Repositorio
{
    //Repositorio para crear y obtener la cadena de conexion hacia la base de datos
    public abstract class Repository
    {
        private readonly string connectionString;
        public Repository(){
            //String de conexion hacia la base de datos
            //Cambiar el string asignado en Data Source por el nombre del servidor de base de datos para conexion a la base de datos local
            connectionString = "Data Source=localhost; Initial Catalog=dbProyectoCS; Integrated Security=True; Encrypt=True; TrustServerCertificate=True";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
