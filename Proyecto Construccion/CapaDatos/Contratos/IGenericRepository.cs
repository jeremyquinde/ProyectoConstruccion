using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Contratos
{
    //Interface generica que recibe una clase entidad como parametro
    public interface IGenericRepository<Entity> where Entity : class
    {
        //Metodos a implementar en los repositorios
        //Si es necesario añadir otros metodos a una entidad especifica, crear una interface para añadirlos
        //Caso contrario solo se necesite añadir, crear, borrar, leer, usar esta inerface
        bool añadir(Entity entity);
        bool editar(Entity entity);
        bool eliminar(int id);
        IEnumerable<Entity> obtener();
    }
}
