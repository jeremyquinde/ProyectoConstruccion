using System.Data;
using CapaDatos.Interface;

namespace CapaNegocio
{

    public class Cliente
    {
        private InterfaceNegocio obj_interface_Cliente = new InterfaceNegocio();

        private String apellidoCliente;
        private String nombreCliente;
        private int cedulaCliente;
        private String correoCliente;
        private int telefonoCliente;
        private String direccionCliente;

        public Cliente()
        {
            this.apellidoCliente = string.Empty;
            this.nombreCliente = string.Empty;
            this.cedulaCliente = 0;
            this.correoCliente = string.Empty;
            this.telefonoCliente = 0;
            this.direccionCliente = string.Empty;
        }

    }
}