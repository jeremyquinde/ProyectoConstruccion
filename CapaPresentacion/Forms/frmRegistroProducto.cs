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
    public partial class frmRegistroProducto : Form
    {
        private ProductoViewModel productoViewModel = new ProductoViewModel();

        public frmRegistroProducto()
        {
            InitializeComponent();
        }

        private void btnProductoGuardar_Click(object sender, EventArgs e)
        {

            productoViewModel.Nombre        = txtProductoNombre     .Text;
            productoViewModel.Categoria     = txtCategoriaProducto  .Text;
            productoViewModel.Marca         = txtMarcaProducto      .Text;
            productoViewModel.CantidadStock = Convert.ToInt32(txtCantidadStock.Text);
            productoViewModel.Precio        = Convert.ToDecimal(txtPrecioProducto.Text);
            productoViewModel.State         = EntityState.Added;

            var validationResults = productoViewModel.Validate();
            if (validationResults.Count == 0)
            {
                var result = productoViewModel.SaveChanges();
                MessageBox.Show(result);
            }
            else
            {
                string listaErrores = string.Join("\n", validationResults.Select(errores => errores.ErrorMessage));
                MessageBox.Show(listaErrores, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnProductoLimpiar_Click(object sender, EventArgs e)
        {
            txtProductoNombre     .Text    = string.Empty;
            txtCategoriaProducto  .Text    = string.Empty;
            txtMarcaProducto      .Text    = string.Empty;
            txtCantidadStock      .Text    = string.Empty;
            txtPrecioProducto     .Text    = string.Empty;
        }



        
    }
}