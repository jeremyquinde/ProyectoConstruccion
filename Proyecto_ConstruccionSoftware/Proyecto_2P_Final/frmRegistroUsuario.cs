using System;
using System.Windows.Forms;
using CapaNegocio;
using CapaDatos.Interface;

namespace CapaPresentacion
{
    public partial class frmRegistroUsuario : Form
    {
        public frmRegistroUsuario()
        {
            InitializeComponent();
        }

        private void btnUsuarioLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar todos los campos
            txtUsuarioNombre.Text = string.Empty;
            txtUsuarioApellido.Text = string.Empty;
            txtUsuarioCorreo.Text = string.Empty;
            txtUsuarioCedula.Text = string.Empty;
            txtUsuarioTelefono.Text = string.Empty;
            txtUsuarioDireccion.Text = string.Empty;
            txtUsuarioRol.Text = string.Empty;
            txtUsuarioContraseña.Text = string.Empty;
        }

        private void btnUsuarioGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                InterfaceNegocio negocio = new InterfaceNegocio();

                string nombre = txtUsuarioNombre.Text;
                string apellido = txtUsuarioApellido.Text;
                string correo = txtUsuarioCorreo.Text;
                string direccion = txtUsuarioDireccion.Text;
                string cedulaTexto = txtUsuarioCedula.Text;
                string telefonoTexto = txtUsuarioTelefono.Text;
                string rol = txtUsuarioRol.Text;
                string contraseña = txtUsuarioContraseña.Text;

                // Validar los campos

                if (!negocio.campoNoVacio(nombre, apellido, cedulaTexto, telefonoTexto, correo, direccion, rol, contraseña))
                {
                    throw new Exception("Todos los campos son obligatorios");
                }

                if (!negocio.esLetra(nombre, apellido, direccion, rol))
                {
                    throw new Exception("Los campos de nombre, apellido, dirección y rol solo pueden contener letras y espacios");
                }

                if (!negocio.esNumero(cedulaTexto, telefonoTexto))
                {
                    throw new Exception("Los campos de cédula y teléfono solo pueden contener números");
                }

                int cedula = int.Parse(cedulaTexto);
                int telefono = int.Parse(telefonoTexto);

                if (negocio.GuardarUsuario(apellido, nombre, cedula, correo, telefono, direccion, rol, contraseña))
                {
                    MessageBox.Show("Usuario registrado con éxito");
                }
                else
                {
                    throw new Exception("No se pudo registrar el usuario");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
