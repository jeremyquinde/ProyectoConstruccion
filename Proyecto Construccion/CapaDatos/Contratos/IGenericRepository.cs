using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Contratos
{
    public interface IGenericRepository<Entity> where Entity : class
    {
        bool añadir(Entity entity);
        bool editar(Entity entity);
        bool eliminar(int id);
        IEnumerable<Entity> obtener();
    }
}
