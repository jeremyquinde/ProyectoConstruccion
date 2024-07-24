using CapaPresentacion;
using CapaPresentacion.Forms;
using FontAwesome.Sharp;

namespace CapaPresentacion
{
    public partial class frmMenuPrincipalAdministrador : Form
    {
        private frmLogin    _loginForm;
        private Form        frmActual;
        private IconButton  btnActual;
        private bool        menuLateral     = true;
        private bool        esCierreSesion  = false; 

        public frmMenuPrincipalAdministrador(frmLogin loginForm)
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

        //Metodo para mostrar Formularios
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

        //Accesos a formularios

        private void btnAbrirCerrar_Click(object sender, EventArgs e)
        {
            tmrMenu.Start();
        }


        private void btnInicio_Click(object sender, EventArgs e)
        {
            mostrarFrm(new frmInicio());
        }


        private void btnRegistroUsuario_Click(object sender, EventArgs e)
        {
            btnActivo(btnConsultaCliente, Color.White);
            mostrarFrm(new frmRegistroUsuario());

        }

        private void btnConsultaUsuario_Click(object sender, EventArgs e)
        {
            btnActivo(btnConsultaCliente, Color.White);
            mostrarFrm(new frmConsultarUsuarios());
        }


        private void btnRegistroVenta_Click(object sender, EventArgs e)
        {
            btnActivo(btnRegistroVenta, Color.White);
            mostrarFrm(new frmRegistrarVenta());
        }


        private void btnConsultaVentas_Click(object sender, EventArgs e)
        {
            btnActivo(btnConsultaCliente, Color.White);
            mostrarFrm(new frmConsultarVentas());
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


        private void btnConsultarProducto_Click(object sender, EventArgs e)
        {
            btnActivo(btnConsultaCliente, Color.White);
            mostrarFrm(new frmConsultarProductos());
        }

        private void btnRegistroProducto_Click(object sender, EventArgs e)
        {
            btnActivo(btnConsultaCliente, Color.White);
            mostrarFrm(new frmRegistroProducto());
        }


        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            esCierreSesion = true;
            _loginForm.Show();
            this.Close();
        }


    }
}
