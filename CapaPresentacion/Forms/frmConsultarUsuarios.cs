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
    public partial class frmConsultarUsuarios : Form
    {
        private UsuarioViewModel usuarioViewModel = new UsuarioViewModel();
        public frmConsultarUsuarios()
        {
            InitializeComponent();
        }

        private void frmConsultarUsuarios_Load(object sender, EventArgs e)
        {
            cargarUsuarios();
        }


        private void dgvConsultarUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var column = dgvConsultarUsuarios.Columns[e.ColumnIndex].Name;
            if (column == "columnEditar")
            {
                var usuario = (UsuarioViewModel)dgvConsultarUsuarios.CurrentRow.DataBoundItem;
                mostrarDetallesUsuario(usuario);
            }

            if (column == "columnEliminar")
            {
                var usuario = (UsuarioViewModel)dgvConsultarUsuarios.CurrentRow.DataBoundItem;
                usuarioViewModel.IdUsuario = usuario.IdUsuario;
                usuarioViewModel.State = EntityState.Deleted;

                var result = usuarioViewModel.SaveChanges();
                MessageBox.Show(result);
                cargarUsuarios();
            }
        }


        private void cargarUsuarios()
        {
            var usuarios = usuarioViewModel.Obtener();
            dgvConsultarUsuarios.DataSource = usuarios;
        }

        private void cargarRol()
        {
            List<string> listaRol = new List<string>();
            listaRol.Add("ADMINISTRADOR");
            listaRol.Add("VENDEDOR");
            listaRol.Add("GERENTE");

            cmbRol.Items.AddRange(listaRol.ToArray());
        }

        private void mostrarDetallesUsuario(UsuarioViewModel usuario)
        {
            txtId.Text = usuario.IdUsuario.ToString();
            txtEditarNombre.Text = usuario.Nombres;
            txtEditarApellido.Text = usuario.Apellidos;
            txtEditarCedula.Text = usuario.Cedula;
            txtEditarCorreo.Text = usuario.Correo;
            txtEditarTelefono.Text = usuario.Telefono;
            txtEditarDireccion.Text = usuario.Direccion;
            cmbRol.Text = usuario.Rol;
            txtEditarFechaRegistro.Text = usuario.FechaRegistro.ToString();
            txtEditarContraseña.Text = usuario.Contraseña;
            pnlEditar.Visible = true;
            cargarRol();
 

        }


        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            usuarioViewModel.IdUsuario = int.Parse(txtId.Text);
            usuarioViewModel.Nombres = txtEditarNombre.Text;
            usuarioViewModel.Apellidos = txtEditarApellido.Text;
            usuarioViewModel.Cedula = txtEditarCedula.Text;
            usuarioViewModel.Correo = txtEditarCorreo.Text;
            usuarioViewModel.Telefono = txtEditarTelefono.Text;
            usuarioViewModel.Direccion = txtEditarDireccion.Text;
            usuarioViewModel.Rol = cmbRol.Text;
            usuarioViewModel.FechaRegistro = Convert.ToDateTime(txtEditarFechaRegistro.Text);
            usuarioViewModel.Contraseña = txtEditarContraseña.Text;
            usuarioViewModel.State = EntityState.Modified;

            var validationResults = usuarioViewModel.Validate();
            if (validationResults.Count == 0)
            {
                var result = usuarioViewModel.SaveChanges();
                MessageBox.Show(result);
                pnlEditar.Visible = false;
                cargarUsuarios();
            }
            else
            {
                string listaErrores = string.Join("\n", validationResults.Select(errores => errores.ErrorMessage));
                MessageBox.Show(listaErrores, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
