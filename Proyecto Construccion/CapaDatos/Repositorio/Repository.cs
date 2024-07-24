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
    public abstract class Repository
    {
        private readonly string connectionString;
        public Repository(){
            connectionString = ConfigurationManager.ConnectionStrings["dbProyectoCS"].ToString();
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
