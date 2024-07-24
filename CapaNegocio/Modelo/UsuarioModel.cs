using CapaDatos.Contratos;
using CapaDatos.Entidades;
using CapaDatos.Repositorio;
using CapaNegocio.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Modelo
{
    public class UsuarioModel
    {
        private int      _idUsuario;
        private string   _apellidos;
        private string   _nombres;
        private string   _cedula;
        private string   _correo;
        private string   _telefono;
        private string   _direccion;
        private string   _rol;
        private DateTime _fechaRegistro;
        private string   _contraseña;


        //Propiedades
        public int    IdUsuario         { get => _idUsuario;     set => _idUsuario = value;     }
        public string Apellidos         { get => _apellidos;     set => _apellidos = value;     }
        public string Nombres           { get => _nombres;       set => _nombres = value;       }
        public string Cedula            { get => _cedula;        set => _cedula = value;        }
        public string Correo            { get => _correo;        set => _correo = value;        }
        public string Telefono          { get => _telefono;      set => _telefono = value;      }
        public string Direccion         { get => _direccion;     set => _direccion = value;     }
        public string Rol               { get => _rol;           set => _rol = value;           }
        public DateTime FechaRegistro   { get => _fechaRegistro; set => _fechaRegistro = value; }
        public string Contraseña        { get => _contraseña;    set => _contraseña = value;    }

        private IUsuarioRepository _usuarioRepository;
        public EntityState State { private get; set; }

        //Metodos

        public UsuarioModel()
        {
            _usuarioRepository = new UsuarioRepository();
        }


        public string SaveChanges()
        {
            string message = "";
            try
            {
                var usuario = new Usuario();

                usuario.idUsuario       = IdUsuario;
                usuario.nombres         = Nombres;
                usuario.apellidos       = Apellidos;
                usuario.cedula          = Cedula;
                usuario.correo          = Correo;
                usuario.telefono        = Telefono;
                usuario.direccion       = Direccion;
                usuario.rol             = Rol;
                usuario.fechaRegistro   = FechaRegistro;
                usuario.contraseña      = Contraseña;

                switch (State)
                {
                    case EntityState.Added:
                        _usuarioRepository.añadir(usuario);
                        message = "Se registro correctamente";
                        break;
                    case EntityState.Modified:
                        _usuarioRepository.editar(usuario);
                        message = "Se edito correctamente";
                        break;
                    case EntityState.Deleted:
                        _usuarioRepository.eliminar(IdUsuario);
                        message = "Se elimino correctamente";
                        break;
                }

            }
            catch (Exception ex)
            {
                message = ex.Message;
            }
            return message;
        }


        public List<UsuarioModel> obtener()
        {
            var tablaUsuarios = _usuarioRepository.obtener();
            var listUsuarios = new List<UsuarioModel>();

            foreach (var item in tablaUsuarios)
            {
                listUsuarios.Add(new UsuarioModel
                {
                    IdUsuario       = item.idUsuario,
                    Nombres         = item.nombres,
                    Apellidos       = item.apellidos,
                    Cedula          = item.cedula,
                    Correo          = item.correo,
                    Telefono        = item.telefono,
                    Direccion       = item.direccion,
                    Rol             = item.rol,
                    FechaRegistro   = item.fechaRegistro,
                    Contraseña      = item.contraseña,

                });
            }
            return listUsuarios;
        }


        public Usuario AutenticarUsuario(string cedula, string contraseña)
        {
            return _usuarioRepository.AutenticarUsuario(cedula, contraseña);
        }


    }
}
