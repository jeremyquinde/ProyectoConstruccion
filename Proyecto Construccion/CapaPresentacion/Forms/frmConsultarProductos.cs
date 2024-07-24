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
    public partial class frmConsultarProductos : Form
    {
        private ProductoViewModel productoViewModel = new ProductoViewModel();

        public frmConsultarProductos()
        {
            InitializeComponent();
        }

        private void frmConsultarProductos_Load(object sender, EventArgs e)
        {
            cargarProductos();
        }

        private void dgvConsultarProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var column = dgvConsultarProductos.Columns[e.ColumnIndex].Name;
            if (column == "columnEditar")
            {
                var producto = (ProductoViewModel)dgvConsultarProductos.CurrentRow.DataBoundItem;
                mostrarDetallesProducto(producto);
            }

            if (column == "columnEliminar")
            {
                var producto = (ProductoViewModel)dgvConsultarProductos.CurrentRow.DataBoundItem;
                productoViewModel.IdProducto = producto.IdProducto;
                productoViewModel.State = EntityState.Deleted;

                var result = productoViewModel.SaveChanges();
                MessageBox.Show(result);
                cargarProductos();
            }
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            productoViewModel.IdProducto = int.Parse(txtId.Text);
            productoViewModel.Nombre = txtEditarNombre.Text;
            productoViewModel.Categoria = txtEditarCategoria.Text;
            productoViewModel.Marca = txtEditarMarca.Text;
            productoViewModel.CantidadStock = int.Parse(txtEditarCantidadStock.Text);
            productoViewModel.Precio = decimal.Parse(txtEditarPrecio.Text);
            productoViewModel.State = EntityState.Modified;

            var validationResults = productoViewModel.Validate();
            if (validationResults.Count == 0)
            {
                var result = productoViewModel.SaveChanges();
                MessageBox.Show(result);
                pnlEditar.Visible = false;
                cargarProductos();
            }
            else
            {
                string listaErrores = string.Join("\n", validationResults.Select(errores => errores.ErrorMessage));
                MessageBox.Show(listaErrores, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargarProductos()
        {
            var productos = productoViewModel.Obtener();
            dgvConsultarProductos.DataSource = productos;
        }

        private void mostrarDetallesProducto(ProductoViewModel producto)
        {
            txtId.Text = producto.IdProducto.ToString();
            txtEditarNombre.Text = producto.Nombre;
            txtEditarCategoria.Text = producto.Categoria;
            txtEditarMarca.Text = producto.Marca;
            txtEditarCantidadStock.Text = producto.CantidadStock.ToString();
            txtEditarPrecio.Text = producto.Precio.ToString();
            pnlEditar.Visible = true;
        }
    }
}
