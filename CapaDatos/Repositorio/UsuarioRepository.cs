using CapaDatos.Contratos;
using CapaDatos.Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Repositorio
{
    public class UsuarioRepository : MasterRepository, IUsuarioRepository
    {
        //implementacion de la IGenericRepository
        public bool añadir(Usuario entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@apellidos",       entity.apellidos    ));
            parameters.Add(new SqlParameter("@nombres",         entity.nombres      ));
            parameters.Add(new SqlParameter("@cedula",          entity.cedula       ));
            parameters.Add(new SqlParameter("@correo",          entity.correo       ));
            parameters.Add(new SqlParameter("@telefono",        entity.telefono     ));
            parameters.Add(new SqlParameter("@direccion",       entity.direccion    ));
            parameters.Add(new SqlParameter("@rol",             entity.rol          ));
            parameters.Add(new SqlParameter("@fecha_registro",  entity.fechaRegistro));
            parameters.Add(new SqlParameter("@contraseña",      entity.contraseña   ));

            return ExecuteSpNonQuery("sp_InsertarUsuario", parameters);
        }

        public bool editar(Usuario entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id_usuario",      entity.idUsuario    ));
            parameters.Add(new SqlParameter("@apellidos",       entity.apellidos    ));
            parameters.Add(new SqlParameter("@nombres",         entity.nombres      ));
            parameters.Add(new SqlParameter("@cedula",          entity.cedula       ));
            parameters.Add(new SqlParameter("@correo",          entity.correo       ));    
            parameters.Add(new SqlParameter("@telefono",        entity.telefono     ));
            parameters.Add(new SqlParameter("@direccion",       entity.direccion    ));
            parameters.Add(new SqlParameter("@rol",             entity.rol          ));
            parameters.Add(new SqlParameter("@fecha_registro",  entity.fechaRegistro));
            parameters.Add(new SqlParameter("@contraseña",      entity.contraseña   ));

            return ExecuteSpNonQuery("sp_ActualizarUsuario", parameters);
        }

        public bool eliminar(int id)

        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id_usuario", id));
            return ExecuteSpNonQuery("sp_EliminarUsuario", parameters);
        }

        public IEnumerable<Usuario> obtener()
        {
            var tableResult = ExecuteSpQuery("sp_MostrarUsuarios", parameters);
            var listUsuarios = new List<Usuario>();

            foreach (DataRow item in tableResult.Rows)
            {
                listUsuarios.Add(new Usuario
                {
                    idUsuario       = Convert.ToInt32(item[0]),
                    nombres         = item[1].ToString(),
                    apellidos       = item[2].ToString(),
                    cedula          = item[3].ToString(),
                    correo          = item[4].ToString(),
                    telefono        = item[5].ToString(),
                    direccion       = item[6].ToString(),
                    rol             = item[7].ToString(),
                    fechaRegistro   = Convert.ToDateTime(item[8]),
                    contraseña      = item[9].ToString(),

                });
            }
            return listUsuarios;
        }


        public Usuario AutenticarUsuario(string cedula, string contraseña)
        {
            parameters = new List<SqlParameter>
            {
                new SqlParameter("@cedula", cedula),
                new SqlParameter("@contraseña", contraseña)
            };

            var tableResult = ExecuteSpQuery("sp_AutenticarUsuario", parameters);

            if (tableResult.Rows.Count > 0)
            {
                var row = tableResult.Rows[0];
                return new Usuario
                {
                    idUsuario = Convert.ToInt32(row["id_Usuario"]),
                    nombres = row["nombres"].ToString(),
                    apellidos = row["apellidos"].ToString(),
                    cedula = row["cedula"].ToString(),
                    correo = row["correo"].ToString(),
                    telefono = row["telefono"].ToString(),
                    direccion = row["direccion"].ToString(),
                    rol = row["rol"].ToString(),
                    fechaRegistro = Convert.ToDateTime(row["fecha_Registro"]),
                    contraseña = row["contraseña"].ToString()
                };
            }
            else
            {
                return null;
            }
        }



    }
}
