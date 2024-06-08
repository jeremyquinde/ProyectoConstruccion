namespace Proyecto_2P_Final
{
    partial class frmMenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pnlateral2 = new Panel();
            pnlateral1 = new Panel();
            pnlRegistroCliente = new Panel();
            btnRegistroClientes = new FontAwesome.Sharp.IconButton();
            pnlConsultaUsuario = new Panel();
            btnConsultaUsuario = new FontAwesome.Sharp.IconButton();
            pnlConsultaCliente = new Panel();
            btnConsultaCliente = new FontAwesome.Sharp.IconButton();
            pnlRegistroUsuario = new Panel();
            btnRegistroUsuario = new FontAwesome.Sharp.IconButton();
            pnlSesion = new Panel();
            btnCerrarSesion = new FontAwesome.Sharp.IconButton();
            pnlInicio = new Panel();
            btnInicio = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            panel2 = new Panel();
            pnlBtnAbrir = new Panel();
            btnAbrirCerrar = new FontAwesome.Sharp.IconButton();
            tmrMenu = new System.Windows.Forms.Timer(components);
            pnlFormularios = new Panel();
            pnlateral2.SuspendLayout();
            pnlateral1.SuspendLayout();
            pnlRegistroCliente.SuspendLayout();
            pnlConsultaUsuario.SuspendLayout();
            pnlConsultaCliente.SuspendLayout();
            pnlRegistroUsuario.SuspendLayout();
            pnlSesion.SuspendLayout();
            pnlInicio.SuspendLayout();
            panel1.SuspendLayout();
            pnlBtnAbrir.SuspendLayout();
            SuspendLayout();
            // 
            // pnlateral2
            // 
            pnlateral2.BackColor = Color.FromArgb(65, 42, 143);
            pnlateral2.Controls.Add(pnlateral1);
            pnlateral2.Dock = DockStyle.Left;
            pnlateral2.Location = new Point(0, 0);
            pnlateral2.Margin = new Padding(0);
            pnlateral2.Name = "pnlateral2";
            pnlateral2.Size = new Size(237, 681);
            pnlateral2.TabIndex = 0;
            // 
            // pnlateral1
            // 
            pnlateral1.BackColor = Color.FromArgb(62, 49, 147);
            pnlateral1.Controls.Add(pnlRegistroCliente);
            pnlateral1.Controls.Add(pnlConsultaUsuario);
            pnlateral1.Controls.Add(pnlConsultaCliente);
            pnlateral1.Controls.Add(pnlRegistroUsuario);
            pnlateral1.Controls.Add(pnlSesion);
            pnlateral1.Controls.Add(pnlInicio);
            pnlateral1.Controls.Add(pnlBtnAbrir);
            pnlateral1.Dock = DockStyle.Left;
            pnlateral1.Location = new Point(0, 0);
            pnlateral1.Name = "pnlateral1";
            pnlateral1.Size = new Size(234, 681);
            pnlateral1.TabIndex = 1;
            // 
            // pnlRegistroCliente
            // 
            pnlRegistroCliente.BackColor = Color.Transparent;
            pnlRegistroCliente.Controls.Add(btnRegistroClientes);
            pnlRegistroCliente.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pnlRegistroCliente.Location = new Point(2, 160);
            pnlRegistroCliente.Name = "pnlRegistroCliente";
            pnlRegistroCliente.Size = new Size(234, 75);
            pnlRegistroCliente.TabIndex = 14;
            // 
            // btnRegistroClientes
            // 
            btnRegistroClientes.FlatAppearance.BorderSize = 0;
            btnRegistroClientes.FlatAppearance.MouseOverBackColor = Color.FromArgb(114, 63, 192);
            btnRegistroClientes.FlatStyle = FlatStyle.Flat;
            btnRegistroClientes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistroClientes.ForeColor = Color.FromArgb(229, 212, 251);
            btnRegistroClientes.IconChar = FontAwesome.Sharp.IconChar.CircleUser;
            btnRegistroClientes.IconColor = Color.FromArgb(229, 212, 251);
            btnRegistroClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRegistroClientes.IconSize = 40;
            btnRegistroClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistroClientes.Location = new Point(0, -3);
            btnRegistroClientes.Name = "btnRegistroClientes";
            btnRegistroClientes.Padding = new Padding(10, 0, 20, 0);
            btnRegistroClientes.Size = new Size(234, 75);
            btnRegistroClientes.TabIndex = 4;
            btnRegistroClientes.Text = "    Registro Cliente";
            btnRegistroClientes.TextAlign = ContentAlignment.MiddleLeft;
            btnRegistroClientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRegistroClientes.UseVisualStyleBackColor = true;
            btnRegistroClientes.Click += btnRegistroClientes_Click;
            // 
            // pnlConsultaUsuario
            // 
            pnlConsultaUsuario.BackColor = Color.Transparent;
            pnlConsultaUsuario.Controls.Add(btnConsultaUsuario);
            pnlConsultaUsuario.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pnlConsultaUsuario.Location = new Point(0, 379);
            pnlConsultaUsuario.Name = "pnlConsultaUsuario";
            pnlConsultaUsuario.Size = new Size(237, 75);
            pnlConsultaUsuario.TabIndex = 3;
            // 
            // btnConsultaUsuario
            // 
            btnConsultaUsuario.FlatAppearance.BorderSize = 0;
            btnConsultaUsuario.FlatAppearance.MouseOverBackColor = Color.FromArgb(114, 63, 192);
            btnConsultaUsuario.FlatStyle = FlatStyle.Flat;
            btnConsultaUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnConsultaUsuario.ForeColor = Color.FromArgb(229, 212, 251);
            btnConsultaUsuario.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            btnConsultaUsuario.IconColor = Color.FromArgb(229, 212, 251);
            btnConsultaUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnConsultaUsuario.IconSize = 40;
            btnConsultaUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            btnConsultaUsuario.Location = new Point(3, 3);
            btnConsultaUsuario.Name = "btnConsultaUsuario";
            btnConsultaUsuario.Padding = new Padding(10, 0, 20, 0);
            btnConsultaUsuario.Size = new Size(234, 75);
            btnConsultaUsuario.TabIndex = 11;
            btnConsultaUsuario.Text = "    Consulta                     Usuario";
            btnConsultaUsuario.TextAlign = ContentAlignment.MiddleLeft;
            btnConsultaUsuario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConsultaUsuario.UseVisualStyleBackColor = true;
            btnConsultaUsuario.Click += btnConsultaUsuario_Click;
            // 
            // pnlConsultaCliente
            // 
            pnlConsultaCliente.BackColor = Color.Transparent;
            pnlConsultaCliente.Controls.Add(btnConsultaCliente);
            pnlConsultaCliente.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pnlConsultaCliente.Location = new Point(0, 238);
            pnlConsultaCliente.Name = "pnlConsultaCliente";
            pnlConsultaCliente.Size = new Size(237, 68);
            pnlConsultaCliente.TabIndex = 2;
            // 
            // btnConsultaCliente
            // 
            btnConsultaCliente.FlatAppearance.BorderSize = 0;
            btnConsultaCliente.FlatAppearance.MouseOverBackColor = Color.FromArgb(114, 63, 192);
            btnConsultaCliente.FlatStyle = FlatStyle.Flat;
            btnConsultaCliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnConsultaCliente.ForeColor = Color.FromArgb(229, 212, 251);
            btnConsultaCliente.IconChar = FontAwesome.Sharp.IconChar.CircleUser;
            btnConsultaCliente.IconColor = Color.FromArgb(229, 212, 251);
            btnConsultaCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnConsultaCliente.IconSize = 40;
            btnConsultaCliente.ImageAlign = ContentAlignment.MiddleLeft;
            btnConsultaCliente.Location = new Point(1, -5);
            btnConsultaCliente.Name = "btnConsultaCliente";
            btnConsultaCliente.Padding = new Padding(10, 0, 20, 0);
            btnConsultaCliente.Size = new Size(234, 75);
            btnConsultaCliente.TabIndex = 10;
            btnConsultaCliente.Text = "    Consulta Cliente";
            btnConsultaCliente.TextAlign = ContentAlignment.MiddleLeft;
            btnConsultaCliente.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConsultaCliente.UseVisualStyleBackColor = true;
            btnConsultaCliente.Click += btnConsultaCliente_Click;
            // 
            // pnlRegistroUsuario
            // 
            pnlRegistroUsuario.BackColor = Color.Transparent;
            pnlRegistroUsuario.Controls.Add(btnRegistroUsuario);
            pnlRegistroUsuario.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pnlRegistroUsuario.Location = new Point(3, 301);
            pnlRegistroUsuario.Name = "pnlRegistroUsuario";
            pnlRegistroUsuario.Size = new Size(234, 75);
            pnlRegistroUsuario.TabIndex = 13;
            // 
            // btnRegistroUsuario
            // 
            btnRegistroUsuario.FlatAppearance.BorderSize = 0;
            btnRegistroUsuario.FlatAppearance.MouseOverBackColor = Color.FromArgb(114, 63, 192);
            btnRegistroUsuario.FlatStyle = FlatStyle.Flat;
            btnRegistroUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistroUsuario.ForeColor = Color.FromArgb(229, 212, 251);
            btnRegistroUsuario.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            btnRegistroUsuario.IconColor = Color.FromArgb(229, 212, 251);
            btnRegistroUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRegistroUsuario.IconSize = 40;
            btnRegistroUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistroUsuario.Location = new Point(0, 3);
            btnRegistroUsuario.Name = "btnRegistroUsuario";
            btnRegistroUsuario.Padding = new Padding(10, 0, 20, 0);
            btnRegistroUsuario.Size = new Size(234, 75);
            btnRegistroUsuario.TabIndex = 5;
            btnRegistroUsuario.Text = "    Registro  Usuario";
            btnRegistroUsuario.TextAlign = ContentAlignment.MiddleLeft;
            btnRegistroUsuario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRegistroUsuario.UseVisualStyleBackColor = true;
            btnRegistroUsuario.Click += btnRegistroUsuario_Click;
            // 
            // pnlSesion
            // 
            pnlSesion.Controls.Add(btnCerrarSesion);
            pnlSesion.Location = new Point(0, 606);
            pnlSesion.Name = "pnlSesion";
            pnlSesion.Size = new Size(234, 75);
            pnlSesion.TabIndex = 9;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatAppearance.MouseOverBackColor = Color.FromArgb(114, 63, 192);
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCerrarSesion.ForeColor = Color.FromArgb(229, 212, 251);
            btnCerrarSesion.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            btnCerrarSesion.IconColor = Color.FromArgb(229, 212, 251);
            btnCerrarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCerrarSesion.IconSize = 40;
            btnCerrarSesion.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.Location = new Point(3, 0);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Padding = new Padding(10, 0, 10, 0);
            btnCerrarSesion.Size = new Size(234, 75);
            btnCerrarSesion.TabIndex = 6;
            btnCerrarSesion.Text = "   Cerrar Sesion";
            btnCerrarSesion.TextAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // pnlInicio
            // 
            pnlInicio.Controls.Add(btnInicio);
            pnlInicio.Controls.Add(panel1);
            pnlInicio.Location = new Point(0, 81);
            pnlInicio.Name = "pnlInicio";
            pnlInicio.Size = new Size(234, 75);
            pnlInicio.TabIndex = 8;
            // 
            // btnInicio
            // 
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatAppearance.MouseOverBackColor = Color.FromArgb(114, 63, 192);
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInicio.ForeColor = Color.FromArgb(229, 212, 251);
            btnInicio.IconChar = FontAwesome.Sharp.IconChar.House;
            btnInicio.IconColor = Color.FromArgb(229, 212, 251);
            btnInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnInicio.IconSize = 40;
            btnInicio.ImageAlign = ContentAlignment.MiddleLeft;
            btnInicio.Location = new Point(0, 3);
            btnInicio.Name = "btnInicio";
            btnInicio.Padding = new Padding(10, 0, 20, 0);
            btnInicio.Size = new Size(234, 75);
            btnInicio.TabIndex = 2;
            btnInicio.Text = "   Inicio";
            btnInicio.TextAlign = ContentAlignment.MiddleLeft;
            btnInicio.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInicio.UseVisualStyleBackColor = true;

            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(panel2);
            panel1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(0, 71);
            panel1.Name = "panel1";
            panel1.Size = new Size(234, 75);
            panel1.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panel2.Location = new Point(3, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(231, 75);
            panel2.TabIndex = 3;
            // 
            // pnlBtnAbrir
            // 
            pnlBtnAbrir.BackColor = Color.Transparent;
            pnlBtnAbrir.Controls.Add(btnAbrirCerrar);
            pnlBtnAbrir.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pnlBtnAbrir.Location = new Point(0, 0);
            pnlBtnAbrir.Name = "pnlBtnAbrir";
            pnlBtnAbrir.Size = new Size(234, 75);
            pnlBtnAbrir.TabIndex = 1;
            // 
            // btnAbrirCerrar
            // 
            btnAbrirCerrar.FlatAppearance.BorderSize = 0;
            btnAbrirCerrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(114, 63, 192);
            btnAbrirCerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(114, 63, 192);
            btnAbrirCerrar.FlatStyle = FlatStyle.Flat;
            btnAbrirCerrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAbrirCerrar.ForeColor = Color.FromArgb(229, 212, 251);
            btnAbrirCerrar.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            btnAbrirCerrar.IconColor = Color.FromArgb(229, 212, 251);
            btnAbrirCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAbrirCerrar.IconSize = 40;
            btnAbrirCerrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAbrirCerrar.Location = new Point(0, 0);
            btnAbrirCerrar.Name = "btnAbrirCerrar";
            btnAbrirCerrar.Padding = new Padding(10, 0, 20, 0);
            btnAbrirCerrar.Size = new Size(234, 75);
            btnAbrirCerrar.TabIndex = 3;
            btnAbrirCerrar.Text = "   Grupo 5";
            btnAbrirCerrar.TextAlign = ContentAlignment.MiddleLeft;
            btnAbrirCerrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAbrirCerrar.UseVisualStyleBackColor = true;
            btnAbrirCerrar.Click += btnAbrirCerrar_Click;
            // 
            // tmrMenu
            // 
            tmrMenu.Interval = 5;
            tmrMenu.Tick += tmrMenu_Tick;
            // 
            // pnlFormularios
            // 
            pnlFormularios.BorderStyle = BorderStyle.FixedSingle;
            pnlFormularios.Dock = DockStyle.Fill;
            pnlFormularios.Location = new Point(237, 0);
            pnlFormularios.Margin = new Padding(0);
            pnlFormularios.Name = "pnlFormularios";
            pnlFormularios.Size = new Size(1027, 681);
            pnlFormularios.TabIndex = 1;
            // 
            // frmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(pnlFormularios);
            Controls.Add(pnlateral2);
            MinimumSize = new Size(1280, 720);
            Name = "frmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosing += frmMenuPrincipal_FormClosing;
            pnlateral2.ResumeLayout(false);
            pnlateral1.ResumeLayout(false);
            pnlRegistroCliente.ResumeLayout(false);
            pnlConsultaUsuario.ResumeLayout(false);
            pnlConsultaCliente.ResumeLayout(false);
            pnlRegistroUsuario.ResumeLayout(false);
            pnlSesion.ResumeLayout(false);
            pnlInicio.ResumeLayout(false);
            panel1.ResumeLayout(false);
            pnlBtnAbrir.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlateral2;
        private Panel pnlateral1;
        private Panel pnlBtnAbrir;
        private FontAwesome.Sharp.IconButton btnInicio;
        private FontAwesome.Sharp.IconButton btnRegistroUsuario;
        private FontAwesome.Sharp.IconButton btnRegistroClientes;
        private Panel pnlInicio;
        private System.Windows.Forms.Timer tmrMenu;
        private Panel pnlFormularios;
        private Panel pnlSesion;
        private FontAwesome.Sharp.IconButton btnCerrarSesion;
        private FontAwesome.Sharp.IconButton btnAbrirCerrar;
        private FontAwesome.Sharp.IconButton btnConsultaUsuario;
        private Panel pnlConsultaCliente;
        private Panel pnlRegistroUsuario;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnConsultaCliente;
        private Panel pnlConsultaUsuario;
        private Panel pnlRegistroCliente;
        private Panel panel2;
    }
}