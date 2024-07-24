using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CapaNegocio.Modelo;
using CapaNegocio.ValueObjects;
using CapaPresentacion.ViewModels;

namespace CapaPresentacion
{
    public partial class frmRegistroCliente : Form
    {
        private ClienteViewModel clienteViewModel = new ClienteViewModel();


        public frmRegistroCliente()
        {
            InitializeComponent();
        }

        private void btnClienteLimpiar_Click(object sender, EventArgs e)
        {
            txtClienteNombre.Text = string.Empty;
            txtClienteApellido.Text = string.Empty;
            txtClienteCorreo.Text = string.Empty;
            txtClienteCedula.Text = string.Empty;
            txtClienteTelefono.Text = string.Empty;
            txtClienteDireccion.Text = string.Empty;
        }

        private void btnClienteGuardar_Click(object sender, EventArgs e)
        {
            clienteViewModel.Nombres = txtClienteNombre.Text;
            clienteViewModel.Apellidos = txtClienteApellido.Text;
            clienteViewModel.Correo = txtClienteCorreo.Text;
            clienteViewModel.Direccion = txtClienteDireccion.Text;
            clienteViewModel.Cedula = txtClienteCedula.Text;
            clienteViewModel.Telefono = txtClienteTelefono.Text;
            clienteViewModel.State = EntityState.Added;

            var validationResults = clienteViewModel.Validate();
            if (validationResults.Count == 0)
            {
                var result = clienteViewModel.SaveChanges();
                MessageBox.Show(result);
            }
            else
            {
                string listaErrores = string.Join("\n", validationResults.Select(errores => errores.ErrorMessage));
                MessageBox.Show(listaErrores, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
