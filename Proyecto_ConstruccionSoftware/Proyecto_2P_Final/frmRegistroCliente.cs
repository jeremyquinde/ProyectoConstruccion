using System;
using System.Windows.Forms;
using CapaNegocio;
using CapaDatos.Interface;

namespace CapaPresentacion
{
    public partial class frmRegistroCliente : Form
    {
        public event Action<string> ClienteGuardado;

        public frmRegistroCliente()
        {
            InitializeComponent();
        }

        //Metodo para limpiar los campos al presionar el boton limpiar
        private void btnClienteLimpiar_Click(object sender, EventArgs e)
        {
            txtClienteNombre.Text = string.Empty;
            txtClienteApellido.Text = string.Empty;
            txtClienteCorreo.Text = string.Empty;
            txtClienteCedula.Text = string.Empty;
            txtClienteTelefono.Text = string.Empty;
            txtClienteDireccion.Text = string.Empty;
        }

        //Metodo para guardar los datos de clientes en la base de datos
        private void btnClienteGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //instancia de interfaceNegocio
                InterfaceNegocio negocio = new InterfaceNegocio();

                string nombre = txtClienteNombre.Text;
                string apellido = txtClienteApellido.Text;
                string correo = txtClienteCorreo.Text;
                string direccion = txtClienteDireccion.Text;
                string cedulaTexto = txtClienteCedula.Text;
                string telefonoTexto = txtClienteTelefono.Text;

                // Validación de los campos

                if (!negocio.campoNoVacio(nombre, apellido, cedulaTexto, telefonoTexto, correo, direccion))
                {
                    throw new Exception("Todos los campos son obligatorios");
                }

                if (!negocio.esLetra(nombre, apellido, direccion))
                {
                    throw new Exception("Los campos de nombre, apellido y dirección solo pueden contener letras y espacios");
                }

                if (!negocio.esNumero(cedulaTexto, telefonoTexto))
                {
                    throw new Exception("El campo de cédula solo puede contener números");
                }

                //Los campos cedula y telefono se vuelven a cambiar a tipo INT para su paso hacia la base de datos
                int cedula = int.Parse(cedulaTexto);
                int telefono = int.Parse(telefonoTexto);

                //Validacion para identificar que el cliente se haya guardado con exito
                if (negocio.GuardarCliente(nombre, apellido, cedula, correo, telefono, direccion))
                {
                    MessageBox.Show("Cliente guardado con éxito");
                    ClienteGuardado?.Invoke(nombre);
                }
                else
                {
                    throw new Exception("No se pudo guardar el cliente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
