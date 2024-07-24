using CapaNegocio.ValueObjects;
using CapaPresentacion.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Forms
{
    public partial class frmRegistroUsuario : Form
    {
        UsuarioViewModel usuarioViewModel = new UsuarioViewModel();

        public frmRegistroUsuario()
        {
            InitializeComponent();
            cargarRol();
        }

        private void cargarRol()
        {
            List<string> listaRol = new List<string>();
            listaRol.Add("ADMINISTRADOR");
            listaRol.Add("VENDEDOR");
            listaRol.Add("GERENTE");

            selectRol.Items.AddRange(listaRol.ToArray());
        }


        private void btnUsuarioGuardar_Click(object sender, EventArgs e)
        {
            usuarioViewModel.Nombres = txtUsuarioNombre.Text;
            usuarioViewModel.Apellidos = txtUsuarioApellido.Text;
            usuarioViewModel.Cedula = txtUsuarioCedula.Text;
            usuarioViewModel.Telefono = txtUsuarioTelefono.Text;
            usuarioViewModel.Correo = txtUsuarioCorreo.Text;
            usuarioViewModel.Direccion = txtUsuarioDireccion.Text;
            usuarioViewModel.Contraseña = txtUsuarioContraseña.Text;
            usuarioViewModel.Rol = selectRol.Text;
            usuarioViewModel.FechaRegistro = Convert.ToDateTime(fechaRegistroUsuario.Text);
            usuarioViewModel.State = EntityState.Added;

            var validationResults = usuarioViewModel.Validate();

            if (validationResults.Count == 0)
            {
                var result = usuarioViewModel.SaveChanges();
                MessageBox.Show(result);
            }
            else
            {
                string listaErrores = string.Join("\n", validationResults.Select(errores => errores.ErrorMessage));
                MessageBox.Show(listaErrores, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUsuarioLimpiar_Click(object sender, EventArgs e)
        {
            txtUsuarioNombre.Text = string.Empty;
            txtUsuarioApellido.Text = string.Empty;
            txtUsuarioCedula.Text = string.Empty;
            txtUsuarioTelefono.Text = string.Empty;
            txtUsuarioCorreo.Text = string.Empty;
            txtUsuarioDireccion.Text = string.Empty;
            txtUsuarioContraseña.Text = string.Empty;
            fechaRegistroUsuario.Text = string.Empty;
            selectRol.Text = string.Empty;

        }
    }
}
