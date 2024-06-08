using CapaPresentacion;
using FontAwesome.Sharp;

namespace Proyecto_2P_Final
{
    public partial class frmMenuPrincipal : Form
    {
        private IconButton btnActual;
        bool menuLateral = true;
        private Form frmActual;

        private bool esCierreSesion = false; // Bandera para controlar el cierre de sesión

        public frmMenuPrincipal()
        {
            InitializeComponent();

            // Manejar el evento FormClosing para cerrar toda la aplicación
            this.FormClosing += new FormClosingEventHandler(frmMenuPrincipal_FormClosing);
        }

        // Método para manejar el evento FormClosing
        private void frmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!esCierreSesion)
            {
                Application.Exit();
            }
        }


        //Metodos mostrar Formularios
        private void mostrarFrm(Form frmElegido)
        {
            if (frmActual != null)
            {
                frmActual.Close();
            }
            frmActual = frmElegido;

            frmElegido.TopLevel = false;
            frmElegido.Dock = DockStyle.Fill;
            pnlFormularios.Controls.Add(frmElegido);
            frmElegido.BringToFront();
            frmElegido.Show();
        }

        //Metodos Menu lateral

        private void tmrMenu_Tick(object sender, EventArgs e)
        {
            if (menuLateral)
            {
                pnlateral1.Width -= 5;
                pnlateral2.Width -= 5;
                if (pnlateral1.Width <= 72 && pnlateral2.Width <= 75)
                {
                    menuLateral = false;
                    tmrMenu.Stop();

                    pnlBtnAbrir.Width = pnlateral1.Width;
                    pnlInicio.Width = pnlateral1.Width;
                    pnlRegistroCliente.Width = pnlateral1.Width;
                    pnlConsultaCliente.Width = pnlateral1.Width;
                    pnlRegistroUsuario.Width = pnlateral1.Width;
                    pnlConsultaUsuario.Width = pnlateral1.Width;
                    pnlSesion.Width = pnlateral1.Width;

                }
            }
            else
            {
                pnlateral1.Width += 5;
                pnlateral2.Width += 5;
                if (pnlateral1.Width >= 234 && pnlateral2.Width >= 237)
                {
                    menuLateral = true;
                    tmrMenu.Stop();

                    pnlBtnAbrir.Width = pnlateral1.Width;
                    pnlInicio.Width = pnlateral1.Width;
                    pnlConsultaCliente.Width = pnlateral1.Width;
                    pnlRegistroCliente.Width = pnlateral1.Width;
                    pnlConsultaUsuario.Width = pnlateral1.Width;
                    pnlRegistroUsuario.Width = pnlateral1.Width;
                    pnlSesion.Width = pnlateral1.Width;
                }
            }
        }

        private void btnAbrirCerrar_Click(object sender, EventArgs e)
        {
            tmrMenu.Start();
        }



        //Metodos Botones y fuente de color
        private void btnActivo(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                btnInactivo();
                btnActual = (IconButton)senderBtn;
                btnActual.ForeColor = color;
                btnActual.IconColor = color;

            }
        }
        private void btnInactivo()
        {
            if (btnActual != null)
            {
                btnActual.ForeColor = Color.FromArgb(229, 212, 251);
                btnActual.IconColor = Color.FromArgb(229, 212, 251);
            }
        }


        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            btnActivo(btnCerrarSesion, Color.White);
            esCierreSesion = true; // Establecer la bandera a true para indicar que se está cerrando sesión
            frmLogin loginForm = frmLogin.obtenerInstancia();
            loginForm.Show();
            this.Close();
        }


        private void btnRegistroClientes_Click(object sender, EventArgs e)
        {
            btnActivo(btnRegistroClientes, Color.White);
            mostrarFrm(new frmRegistroCliente());
        }

        private void btnConsultaCliente_Click(object sender, EventArgs e)
        {
            btnActivo(btnConsultaCliente, Color.White);
            mostrarFrm(new frmConsultarClientes());
        }

        private void btnRegistroUsuario_Click(object sender, EventArgs e)
        {
            btnActivo(btnRegistroUsuario, Color.White);
            mostrarFrm(new frmRegistroUsuario());
        }

        private void btnConsultaUsuario_Click(object sender, EventArgs e)
        {
            btnActivo(btnConsultaUsuario, Color.White);
            mostrarFrm(new frmConsultarUsuario());
        }

    }
}
