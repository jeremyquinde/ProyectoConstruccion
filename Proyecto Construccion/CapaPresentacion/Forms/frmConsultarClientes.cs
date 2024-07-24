using System;
using System.Windows.Forms;
using CapaDatos.Entidades;
using CapaNegocio.Modelo;
using CapaNegocio.ValueObjects;
using CapaPresentacion.ViewModels;

namespace CapaPresentacion
{
    public partial class frmConsultarClientes : Form
    {
        private ClienteViewModel clienteViewModel = new ClienteViewModel();

        public frmConsultarClientes()
        {
            InitializeComponent();
        }

        private void frmConsultarClientes_Load(object sender, EventArgs e)
        {
            cargarClientes();
        }

        private void dgvConsultarClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var column = dgvConsultarClientes.Columns[e.ColumnIndex].Name;
            if (column == "columnEditar")
            {
                var cliente = (ClienteViewModel)dgvConsultarClientes.CurrentRow.DataBoundItem;
                mostrarDetallesCliente(cliente);
            }

            if (column == "columnEliminar")
            {
                var cliente = (ClienteViewModel)dgvConsultarClientes.CurrentRow.DataBoundItem;
                clienteViewModel.IdCliente = cliente.IdCliente;
                clienteViewModel.State = EntityState.Deleted;
                var result = clienteViewModel.SaveChanges();
                MessageBox.Show(result);
                cargarClientes();
            }
        }


        private void cargarClientes()
        {
            var clientes = clienteViewModel.Obtener();
            dgvConsultarClientes.DataSource = clientes;
        }

        private void mostrarDetallesCliente(ClienteViewModel cliente)
        {
            txtId.Text              = cliente.IdCliente.ToString();
            txtEditarNombre.Text    = cliente.Nombres;
            txtEditarApellido.Text  = cliente.Apellidos;
            txtEditarCedula.Text    = cliente.Cedula;
            txtEditarCorreo.Text    = cliente.Correo;
            txtEditarTelefono.Text  = cliente.Telefono;
            txtEditarDireccion.Text = cliente.Direccion;
            pnlEditar.Visible       = true;
        }


        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            clienteViewModel.IdCliente  = int.Parse(txtId.Text);
            clienteViewModel.Nombres    = txtEditarNombre.Text;
            clienteViewModel.Apellidos  = txtEditarApellido.Text;
            clienteViewModel.Cedula     = txtEditarCedula.Text;
            clienteViewModel.Correo     = txtEditarCorreo.Text;
            clienteViewModel.Telefono   = txtEditarTelefono.Text;
            clienteViewModel.Direccion  = txtEditarDireccion.Text;
            clienteViewModel.State      = EntityState.Modified;

            var validationResults = clienteViewModel.Validate();
            if (validationResults.Count == 0)
            {
                var result = clienteViewModel.SaveChanges();
                MessageBox.Show(result);
                pnlEditar.Visible = false;
                cargarClientes();
            }
            else
            {
                string listaErrores = string.Join("\n", validationResults.Select(errores => errores.ErrorMessage));
                MessageBox.Show(listaErrores, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
