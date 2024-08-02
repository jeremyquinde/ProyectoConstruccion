using Microsoft.Data.SqlClient;
using System.Data;
using System.Diagnostics;

namespace CapaDatos.Repositorio
{
    //Repositorio maestro para ejecutar los stored procedures de tipo Query y nonQuery
    public class MasterRepository : Repository
    {
        protected List<SqlParameter> parameters;
        //Metodo que recibe lista de parametros y el nombre del stored procedure
        //para ejecutar los stored procedures de tipo nonQuery de la base de datos
        protected bool ExecuteSpNonQuery(string nombreSP, List<SqlParameter> listParametros)
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                using (var command = new SqlCommand(nombreSP, connection))
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;

                    if (listParametros.Count > 0)
                    {
                        foreach (SqlParameter parametro in listParametros)
                        {
                            command.Parameters.Add(parametro);
                        }
                    }

                    int resultado = command.ExecuteNonQuery();
                    parameters.Clear();
                    return resultado > 0;
                }
            }
        }

        //Metodo que recibe lista de parametros y el nombre del stored procedure
        //para ejecutar los stored procedures de tipo Query de la base de datos
        protected DataTable ExecuteSpQuery(string nombreSP, List<SqlParameter> listParametros)
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                using (var command = new SqlCommand(nombreSP, connection))
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;

                    if (listParametros != null)
                    {
                        var parametrosCopia = listParametros.Select(p => new SqlParameter(p.ParameterName, p.Value)).ToArray();

                        command.Parameters.AddRange(parametrosCopia);
                    }

                    SqlDataReader reader = command.ExecuteReader();
                    using (var table = new DataTable())
                    {
                        table.Load(reader);
                        reader.Dispose();
                        return table;
                    }
                }
            }
        }



    }
}
