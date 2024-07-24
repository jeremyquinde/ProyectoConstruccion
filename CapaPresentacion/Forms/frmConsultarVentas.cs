using System;
using System.Linq;
using System.Windows.Forms;
using CapaNegocio.ValueObjects;
using CapaPresentacion.ViewModels;

namespace CapaPresentacion.Forms
{
    public partial class frmConsultarVentas : Form
    {
        private VentaViewModel ventaViewModel = new VentaViewModel();

        public frmConsultarVentas()
        {
            InitializeComponent();
        }

        private void frmConsultarVentas_Load(object sender, EventArgs e)
        {
            cargarVentas();
        }

        private void dgvConsultarVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var column = dgvConsultarVentas.Columns[e.ColumnIndex].Name;
            if (column == "columnEditar")
            {
                var venta = (VentaViewModel)dgvConsultarVentas.CurrentRow.DataBoundItem;
                mostrarDetallesVenta(venta);
            }

            if (column == "columnEliminar")
            {
                var venta = (VentaViewModel)dgvConsultarVentas.CurrentRow.DataBoundItem;
                ventaViewModel.IdVenta = venta.IdVenta;
                ventaViewModel.State = EntityState.Deleted;
                var result = ventaViewModel.SaveChanges();
                MessageBox.Show(result);
                cargarVentas();
            }
        }

        private void cargarVentas()
        {
            var ventas = ventaViewModel.Obtener();
            dgvConsultarVentas.DataSource = ventas;
        }

        private void mostrarDetallesVenta(VentaViewModel venta)
        {
            txtId.Text = venta.IdVenta.ToString();
            txtEditarCedula.Text = venta.Cedula;
            txtEditarIdProducto.Text = venta.IdProducto.ToString();
            txtEditarCantidadProducto.Text = venta.CantidadProducto.ToString();
            txtEditarDescuento.Text = venta.Descuento.ToString();
            txtEditarPrecioFinal.Text = venta.PrecioFinal.ToString();
            pnlEditar.Visible = true;
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            ventaViewModel.IdVenta = int.Parse(txtId.Text);
            ventaViewModel.Cedula = txtEditarCedula.Text;
            ventaViewModel.IdProducto = int.Parse(txtEditarIdProducto.Text);
            ventaViewModel.CantidadProducto = int.Parse(txtEditarCantidadProducto.Text);
            ventaViewModel.Descuento = int.Parse(txtEditarDescuento.Text);
            ventaViewModel.PrecioFinal = decimal.Parse(txtEditarPrecioFinal.Text);
            ventaViewModel.State = EntityState.Modified;

            var validationResults = ventaViewModel.Validate();
            if (validationResults.Count == 0)
            {
                var result = ventaViewModel.SaveChanges();
                MessageBox.Show(result);
                pnlEditar.Visible = false;
                cargarVentas();
            }
            else
            {
                string listaErrores = string.Join("\n", validationResults.Select(errores => errores.ErrorMessage));
                MessageBox.Show(listaErrores, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
