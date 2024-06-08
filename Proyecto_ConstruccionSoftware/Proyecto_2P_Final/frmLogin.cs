using CapaDatos.Interface;
using Proyecto_2P_Final;
using System;
using System.CodeDom;
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
        private static frmLogin instance;
        private frmLogin()
        {
            InitializeComponent();
        }

        //Metodo para obtener esta misma instancia de frmLogin y evitar abrir otros
        public static frmLogin obtenerInstancia()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new frmLogin();
            }
            return instance;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Strings para definir las variables que contienen los campos de texto personalizados
            string cedula = (logCedula as CapaPresentacion.Custom.RJTextBox)?.Texts ?? "";
            string contraseña = (logContrasena as CapaPresentacion.Custom.RJTextBox)?.Texts ?? "";


            // Instancia de la clase interfaceNegocio para hacer uso de sus metodos
            InterfaceNegocio negocio = new InterfaceNegocio();


            //Bloque trycatch para manejar las excepciones
            try
            {
                //Validaciones de campos
                if (!negocio.campoNoVacio(cedula, contraseña))
                {
                    throw new Exception("Los campos deben ser completados");
                }

                if (!negocio.esNumero(cedula))
                {
                    throw new Exception("El campo de cedula solo puede contener numeros");
                }


                // Validacion para comprobar que los datos se encuentren en la base de datos
                if (negocio.AutenticarUsuario(cedula, contraseña))
                {
                    MessageBox.Show("Usuario encontrado", "Autenticación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Creacion de instancia para mostrar la ventana de menu principal en caso de que la autenticacion sea correcta
                    frmMenuPrincipal menuPrincipal = new frmMenuPrincipal();
                    menuPrincipal.Show();
                    this.Hide();
                }
                else
                {
                    throw new Exception("Usuario no encontrado, verifica que los datos ingresados sean correctos.");
                }

            }
            catch (Exception ex)
            {
                // Mostrar la excepción lanzada en un MessageBox
                MessageBox.Show("Error: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
