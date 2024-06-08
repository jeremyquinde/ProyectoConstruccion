using System;
using System.Collections.Generic;
using System.Data;
using CapaDatos.SQLexecute;
using System.Windows;
using System.Text.RegularExpressions;

namespace CapaDatos.Interface
{
    public class InterfaceNegocio
    {
        private readonly ExecuteSqlCommand obj_db = new ExecuteSqlCommand();

        //Metodo para identificar que el texto sea un numero o no mediante el uso de arrays para el traspaso de varios parametros

        public bool esNumero(params string[] textos)
        {
            foreach (string texto in textos)
            {
                if (!int.TryParse(texto, out _))
                {
                    return false;
                }
            }
            return true;
        }

        public bool esLetra(params string[] textos)
        {
            foreach (string texto in textos)
            {
                if (!Regex.IsMatch(texto, @"^[a-zA-Z]+$"))
                {
                    return false;
                }
            }
            return true;
        }

        public bool campoNoVacio(params string[] campos)
        {
            return campos.All(campo => !string.IsNullOrWhiteSpace(campo));
        }


        //METODO para autenticar usuario, devuelve verdadero si existe una fila con el dato enviado por parametro o falso si no existen filas con ese dato
        public bool AutenticarUsuario(string cedula, string contraseña)
        {
            List<Parametros_sp> parametros = new List<Parametros_sp>
                {
                    new Parametros_sp("@cedula", cedula, SqlDbType.VarChar),
                    new Parametros_sp("@contraseña", contraseña, SqlDbType.NVarChar)
                };

            DataTable dt = obj_db.ExecuteSp("sp_AutenticarUsuario", parametros);

            return dt.Rows.Count > 0;
        }



        // Método para guardar cliente pasando como lista 
        public bool GuardarCliente(string nombre, string apellido, int cedula, string correo, int telefono, string direccion)
        {
                List<Parametros_sp> lista_parametros = new List<Parametros_sp>
                {
                    new Parametros_sp("@nombres", nombre, SqlDbType.VarChar),
                    new Parametros_sp("@apellidos", apellido, SqlDbType.VarChar),
                    new Parametros_sp("@cedula", cedula, SqlDbType.Int),
                    new Parametros_sp("@correo", correo, SqlDbType.VarChar),
                    new Parametros_sp("@telefono", telefono, SqlDbType.Int),
                    new Parametros_sp("@direccion", direccion, SqlDbType.VarChar)
                };

                return obj_db.ExecuteSpNonQuery("sp_InsertarCliente", lista_parametros);
        }


        public DataTable consultarClientes()
        {
            try
            {
                return obj_db.ExecuteSp("sp_MostrarClientes", null);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al mostrar clientes: " + ex.Message);
                throw;
            }
        }


        public bool GuardarUsuario(string apellidos, string nombres, int cedula, string correo, int telefono, string direccion, string rol, string contraseña)
        {
            DateTime fechaRegistro = DateTime.Now.Date;

            List<Parametros_sp> lista_parametros = new List<Parametros_sp>
            {
                new Parametros_sp("@apellidos", apellidos, SqlDbType.VarChar),
                new Parametros_sp("@nombres", nombres, SqlDbType.VarChar),
                new Parametros_sp("@cedula", cedula, SqlDbType.Int),
                new Parametros_sp("@correo", correo, SqlDbType.VarChar),
                new Parametros_sp("@telefono", telefono, SqlDbType.Int),
                new Parametros_sp("@direccion", direccion, SqlDbType.VarChar),
                new Parametros_sp("@rol", rol, SqlDbType.VarChar),
                new Parametros_sp("@contraseña", contraseña, SqlDbType.VarChar),
                new Parametros_sp("@fecha_registro", fechaRegistro, SqlDbType.Date)
            };

            return obj_db.ExecuteSpNonQuery("sp_InsertarUsuario", lista_parametros);
        }

        public DataTable MostrarUsuarios()
        {
            try
            {
                return obj_db.ExecuteSp("sp_MostrarUsuarios", null);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al mostrar usuarios: " + ex.Message);
                throw;
            }
        }

    }
}
