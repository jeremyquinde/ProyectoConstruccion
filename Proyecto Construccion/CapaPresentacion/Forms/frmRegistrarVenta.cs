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
        ClienteViewModel  cliente = new ClienteViewModel();
        ProductoViewModel producto = new ProductoViewModel();
        VentaViewModel    ventaViewModel = new VentaViewModel();

        public frmRegistrarVenta()
        {
            InitializeComponent();
        }

        private void frmRegistrarVenta_Load(object sender, EventArgs e)
        {
            CargarCedulasClientes();
            CargarIdsProductos();
            LimpiarCampos();
        }

        private void CargarCedulasClientes()
        {
            var clientes = cliente.Obtener();
            comboBoxCedula.DataSource     = clientes;
            comboBoxCedula.DisplayMember  = "Cedula";
            comboBoxCedula.ValueMember    = "Cedula";
            comboBoxCedula.SelectedIndex  = -1;
        }

        private void CargarIdsProductos()
        {
            var productos = producto.Obtener();
            comboBoxIdProducto.DataSource    = productos;
            comboBoxIdProducto.DisplayMember = "IdProducto";
            comboBoxIdProducto.ValueMember   = "IdProducto";
            comboBoxIdProducto.SelectedIndex = -1;
        }

        private void comboBoxCedula_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCedula.SelectedItem != null)
            {
                ClienteViewModel clienteSeleccionado = (ClienteViewModel)comboBoxCedula.SelectedItem;
                txtClienteNombre.Text          = clienteSeleccionado.Nombres;
                txtClienteApellido.Text        = clienteSeleccionado.Apellidos;
                ventaViewModel.Cedula          = clienteSeleccionado.Cedula;
                ventaViewModel.NombreCliente   = clienteSeleccionado.Nombres;
                ventaViewModel.ApellidoCliente = clienteSeleccionado.Apellidos;
            }
        }

        private void comboBoxIdProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxIdProducto.SelectedItem != null)
            {
                ProductoViewModel productoSeleccionado = (ProductoViewModel)comboBoxIdProducto.SelectedItem;
                txtProductoNombre.Text        = productoSeleccionado.Nombre;
                txtProductoMarca.Text         = productoSeleccionado.Marca;
                txtProductoPrecio.Text        = productoSeleccionado.Precio.ToString();
                ventaViewModel.IdProducto     = productoSeleccionado.IdProducto;
                ventaViewModel.NombreProducto = productoSeleccionado.Nombre;
                ventaViewModel.MarcaProducto  = productoSeleccionado.Marca;
                ventaViewModel.PrecioProducto = productoSeleccionado.Precio;
                ActualizarPrecioFinal();
            }
        }

        private void txtCantidadProducto_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtCantidadProducto.Text, out int cantidad))
            {
                ventaViewModel.CantidadProducto = cantidad;
                ActualizarPrecioFinal();
            }
        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtDescuento.Text, out int descuento))
            {
                ventaViewModel.Descuento = descuento;
                ActualizarPrecioFinal();
            }
        }

        private void ActualizarPrecioFinal()
        {
            ventaViewModel.CalcularPrecioFinal();
            txtPrecioFinal.Text = ventaViewModel.PrecioFinal.ToString("0.00");
        }

        private void btnVentaGuardar_Click(object sender, EventArgs e)
        {
            var validationResults = ventaViewModel.Validate();
            if (validationResults.Count == 0)
            {
                ventaViewModel.State = EntityState.Added;
                string message = ventaViewModel.SaveChanges();
                MessageBox.Show(message);
                LimpiarCampos();
            }
            else
            {
                string errorMessage = string.Join("\n", validationResults.Select(r => r.ErrorMessage));
                MessageBox.Show(errorMessage);
            }
        }

        private void LimpiarCampos()
        {
            comboBoxCedula.SelectedIndex     = -1;
            comboBoxIdProducto.SelectedIndex = -1;
            txtClienteNombre        .Clear();
            txtClienteApellido      .Clear();
            txtProductoNombre       .Clear();
            txtProductoMarca        .Clear();
            txtProductoPrecio       .Clear();
            txtCantidadProducto     .Clear();
            txtDescuento            .Clear();
            txtPrecioFinal          .Clear();
        }

        private void btnVentaLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
