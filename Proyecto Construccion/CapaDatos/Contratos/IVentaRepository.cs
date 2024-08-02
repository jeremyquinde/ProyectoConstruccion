using CapaDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Contratos
{
    //Interface especifica para la entidad de usuario
    public interface IVentaRepository: IGenericRepository<Venta>
    {
        //Adicion del metodo a implementar obtener informes de ventas
        IEnumerable<Venta> ObtenerInformeVentas(DateTime fechaInicio, DateTime fechaFin);
    }
}
