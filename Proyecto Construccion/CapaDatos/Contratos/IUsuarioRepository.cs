using CapaDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Contratos
{
    public interface IUsuarioRepository : IGenericRepository<Usuario>
    {
        //Si es necesario añadir otros metodos a una entidad especifica, crear una interface para añadirlos
        //caso contrario solo se necesite añadir, crear, borrar, leer, usar el generico
        Usuario AutenticarUsuario(string cedula, string contraseña);
    }
}
