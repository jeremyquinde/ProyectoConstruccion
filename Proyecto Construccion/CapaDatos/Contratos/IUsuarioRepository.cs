﻿using CapaDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Contratos
{
    //Interface especifica para la entidad de usuario
    public interface IUsuarioRepository : IGenericRepository<Usuario>
    {
        //Adicion del metodo a implementar autenticar usuario
        Usuario AutenticarUsuario(string cedula, string contraseña);
    }
}
