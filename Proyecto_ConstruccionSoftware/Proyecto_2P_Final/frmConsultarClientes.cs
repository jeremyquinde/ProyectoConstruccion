using CapaDatos.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmConsultarClientes : Form
    {
        private readonly InterfaceNegocio negocio = new InterfaceNegocio();
        public frmConsultarClientes()
        {
            InitializeComponent();
        }

        private void frmConsultarClientes_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void CargarClientes()
        {
            try
            {
                dgvConsultarClientes.DataSource = negocio.consultarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
