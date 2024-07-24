using CapaPresentacion;
using CapaPresentacion.ViewModels;
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
    public partial class frmLogin : Form
    {
        private UsuarioViewModel _usuarioViewModel;
        public frmLogin()
        {
            InitializeComponent();
            _usuarioViewModel = new UsuarioViewModel();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtLoginUser.Texts.Trim();
            string contraseña = txtLoginPass.Texts.Trim();

            var usuarioAutenticado = _usuarioViewModel.AutenticarUsuario(usuario, contraseña);

            if (usuarioAutenticado != null)
            {
                MessageBox.Show("Usuario encontrado", "Autenticación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtLoginUser.Texts = string.Empty;
                txtLoginPass.Texts = string.Empty;

                // Redirección basada en el rol
                string rol = usuarioAutenticado.rol;

                Form menuPrincipal = null;

                switch (rol.ToLower())
                {
                    case "gerente":
                      menuPrincipal = new frmMenuPrincipalGerente(this);
                        break;
                    case "vendedor":
                        menuPrincipal = new frmMenuPrincipalVendedor(this);
                        break;
                    case "administrador":
                        menuPrincipal = new frmMenuPrincipalAdministrador(this);
                        break;
                    default:
                        MessageBox.Show("Rol no reconocido.", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                if (menuPrincipal != null)
                {
                    menuPrincipal.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Usuario no encontrado. Verifica tus credenciales.", "Autenticación fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
