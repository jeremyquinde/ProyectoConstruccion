using CapaPresentacion;
using CapaPresentacion.Forms;
using FontAwesome.Sharp;

namespace CapaPresentacion
{
    public partial class frmMenuPrincipalGerente : Form
    {
        private frmLogin _loginForm;
        private Form frmActual;
        private IconButton btnActual;
        private bool menuLateral = true;
        private bool esCierreSesion = false;

        public frmMenuPrincipalGerente(frmLogin loginForm)
        {
            InitializeComponent();
            _loginForm = loginForm;
            mostrarFrm(new frmInicio());
        }

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
                if (pnlateral1.Width <= 67 && pnlateral2.Width <= 67)
                {
                    menuLateral = false;
                    tmrMenu.Stop();

                    pnlBtnAbrir.Width = pnlateral1.Width;
                    pnlInicio.Width = pnlateral1.Width;
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
                    pnlSesion.Width = pnlateral1.Width;
                }
            }
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


        private void btnAbrirCerrar_Click(object sender, EventArgs e)
        {
            tmrMenu.Start();
        }


        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            esCierreSesion = true;
            _loginForm.Show();
            this.Close();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            mostrarFrm(new frmInicio());
        }

        private void btnInformeInventario_Click(object sender, EventArgs e)
        {
            mostrarFrm(new frmInformeInventario());
        }

        private void btnInformeVentas_Click(object sender, EventArgs e)
        {
            mostrarFrm(new frmInformeVentas());
        }
    }
}
