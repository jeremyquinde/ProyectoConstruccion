using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CapaNegocio.ValueObjects;
using CapaPresentacion.ViewModels;

namespace CapaPresentacion.Forms
{
    public partial class frmRegistrarVenta : Form
    {
        ClienteViewModel cliente = new ClienteViewModel();
        ProductoViewModel producto = new ProductoViewModel();
        VentaViewModel ventaViewModel = new VentaViewModel();

        public frmRegistrarVenta()
        {
            InitializeComponent();
        }

        private void frmRegistrarVenta_Load(object sender, EventArgs e)
        {
            CargarCedulasClientes();
            CargarIdsProductos();
        }

        private void CargarCedulasClientes()
        {
            var clientes = cliente.Obtener();
            comboBoxCedula.DataSource = clientes;
            comboBoxCedula.DisplayMember = "Cedula";
            comboBoxCedula.ValueMember = "Cedula";
            comboBoxCedula.SelectedIndex = -1;
        }

        private void CargarIdsProductos()
        {
            var productos = producto.Obtener();
            comboBoxIdProducto.DataSource = productos;
            comboBoxIdProducto.DisplayMember = "IdProducto";
            comboBoxIdProducto.ValueMember = "IdProducto";
            comboBoxIdProducto.SelectedIndex = -1;

        }

        private void comboBoxCedula_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCedula.SelectedItem != null)
            {
                ClienteViewModel clienteSeleccionado = (ClienteViewModel)comboBoxCedula.SelectedItem;

                if (clienteSeleccionado != null)
                {
                    txtClienteNombre.Text = clienteSeleccionado.Nombres;
                    txtClienteApellido.Text = clienteSeleccionado.Apellidos;
                }
            }
            else
            {
                txtClienteNombre.Text = string.Empty;
                txtClienteApellido.Text = string.Empty;
            }
        }


        private void comboBoxIdProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxIdProducto.SelectedItem != null)
            {
                ProductoViewModel productoSeleccionado = (ProductoViewModel)comboBoxIdProducto.SelectedItem;

                if (productoSeleccionado != null)
                {
                    txtProductoNombre.Text = productoSeleccionado.Nombre;
                    txtProductoMarca.Text = productoSeleccionado.Marca;
                    txtProductoPrecio.Text = productoSeleccionado.Precio.ToString("F2");
                }
            }
            else
            {
                txtProductoNombre.Text = string.Empty;
                txtProductoMarca.Text = string.Empty;
                txtProductoPrecio.Text = string.Empty;
            }
        }

        private void txtCantidadProducto_TextChanged(object sender, EventArgs e)
        {
            CalcularPrecioFinal();
        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {
            CalcularPrecioFinal();
        }

        private void CalcularPrecioFinal()
        {
            if (int.TryParse(txtCantidadProducto.Text, out int cantidad) &&
                decimal.TryParse(txtProductoPrecio.Text, out decimal precio) &&
                int.TryParse(txtDescuento.Text, out int descuento))
            {
                decimal descuentoDecimal = descuento / 100m;
                decimal precioFinal = cantidad * precio * (1 - descuentoDecimal);
                txtPrecioFinal.Text = precioFinal.ToString("F2");
            }
        }

        private void btnVentaGuardar_Click(object sender, EventArgs e)
        {
            var ventaViewModel = new VentaViewModel
            {
                Cedula = comboBoxCedula.SelectedValue.ToString(),
                IdProducto = (int)comboBoxIdProducto.SelectedValue,
                CantidadProducto = int.Parse(txtCantidadProducto.Text),
                Descuento = int.Parse(txtDescuento.Text),
                PrecioFinal = decimal.Parse(txtPrecioFinal.Text),
                State = EntityState.Added
            };

            var validationResults = ventaViewModel.Validate();
            if (validationResults.Count == 0)
            {
                var result = ventaViewModel.SaveChanges();
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
