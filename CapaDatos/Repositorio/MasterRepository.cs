using Microsoft.Data.SqlClient;
using System.Data;
using System.Diagnostics;

namespace CapaDatos.Repositorio
{
    public class MasterRepository : Repository
    {
        protected List<SqlParameter> parameters;
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
                        command.Parameters.AddRange(listParametros.ToArray());
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
