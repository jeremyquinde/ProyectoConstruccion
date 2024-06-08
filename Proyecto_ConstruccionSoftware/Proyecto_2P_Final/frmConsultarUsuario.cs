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
    public partial class frmConsultarUsuario : Form
    {
        private readonly InterfaceNegocio negocio = new InterfaceNegocio();


        public frmConsultarUsuario()
        {
            InitializeComponent();
        }

        private void frmConsultarUsuario_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            try
            {
                dgvConsultaUsuarios.DataSource = negocio.MostrarUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuarios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
