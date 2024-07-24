
namespace CapaPresentacion
{
    partial class frmMenuPrincipalGerente
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
            panel6 = new Panel();
            btnInformeVentas = new FontAwesome.Sharp.IconButton();
            panel4 = new Panel();
            btnInformeInventario = new FontAwesome.Sharp.IconButton();
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
            panel6.SuspendLayout();
            panel4.SuspendLayout();
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
            pnlateral2.Size = new Size(237, 861);
            pnlateral2.TabIndex = 0;
            // 
            // pnlateral1
            // 
            pnlateral1.BackColor = Color.FromArgb(62, 49, 147);
            pnlateral1.Controls.Add(panel6);
            pnlateral1.Controls.Add(panel4);
            pnlateral1.Controls.Add(pnlSesion);
            pnlateral1.Controls.Add(pnlInicio);
            pnlateral1.Controls.Add(pnlBtnAbrir);
            pnlateral1.Dock = DockStyle.Left;
            pnlateral1.Location = new Point(0, 0);
            pnlateral1.Name = "pnlateral1";
            pnlateral1.Size = new Size(237, 861);
            pnlateral1.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Transparent;
            panel6.Controls.Add(btnInformeVentas);
            panel6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panel6.Location = new Point(2, 249);
            panel6.Name = "panel6";
            panel6.Size = new Size(237, 74);
            panel6.TabIndex = 13;
            // 
            // btnInformeVentas
            // 
            btnInformeVentas.FlatAppearance.BorderSize = 0;
            btnInformeVentas.FlatAppearance.MouseOverBackColor = Color.FromArgb(114, 63, 192);
            btnInformeVentas.FlatStyle = FlatStyle.Flat;
            btnInformeVentas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInformeVentas.ForeColor = Color.FromArgb(229, 212, 251);
            btnInformeVentas.IconChar = FontAwesome.Sharp.IconChar.ChartSimple;
            btnInformeVentas.IconColor = Color.FromArgb(229, 212, 251);
            btnInformeVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnInformeVentas.IconSize = 40;
            btnInformeVentas.ImageAlign = ContentAlignment.MiddleLeft;
            btnInformeVentas.Location = new Point(-1, -2);
            btnInformeVentas.Name = "btnInformeVentas";
            btnInformeVentas.Padding = new Padding(10, 0, 20, 0);
            btnInformeVentas.Size = new Size(237, 76);
            btnInformeVentas.TabIndex = 6;
            btnInformeVentas.Text = "     INFORME DE              VENTAS";
            btnInformeVentas.TextAlign = ContentAlignment.MiddleLeft;
            btnInformeVentas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInformeVentas.UseVisualStyleBackColor = true;
            btnInformeVentas.Click += btnInformeVentas_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(btnInformeInventario);
            panel4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panel4.Location = new Point(3, 164);
            panel4.Name = "panel4";
            panel4.Size = new Size(234, 75);
            panel4.TabIndex = 14;
            // 
            // btnInformeInventario
            // 
            btnInformeInventario.FlatAppearance.BorderSize = 0;
            btnInformeInventario.FlatAppearance.MouseOverBackColor = Color.FromArgb(114, 63, 192);
            btnInformeInventario.FlatStyle = FlatStyle.Flat;
            btnInformeInventario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInformeInventario.ForeColor = Color.FromArgb(229, 212, 251);
            btnInformeInventario.IconChar = FontAwesome.Sharp.IconChar.BoxesAlt;
            btnInformeInventario.IconColor = Color.FromArgb(229, 212, 251);
            btnInformeInventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnInformeInventario.IconSize = 40;
            btnInformeInventario.ImageAlign = ContentAlignment.MiddleLeft;
            btnInformeInventario.Location = new Point(-2, 0);
            btnInformeInventario.Name = "btnInformeInventario";
            btnInformeInventario.Padding = new Padding(10, 0, 20, 0);
            btnInformeInventario.Size = new Size(237, 75);
            btnInformeInventario.TabIndex = 12;
            btnInformeInventario.Text = "     INFORMES                  INVENTARIO";
            btnInformeInventario.TextAlign = ContentAlignment.MiddleLeft;
            btnInformeInventario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInformeInventario.UseVisualStyleBackColor = true;
            btnInformeInventario.Click += btnInformeInventario_Click;
            // 
            // pnlSesion
            // 
            pnlSesion.Controls.Add(btnCerrarSesion);
            pnlSesion.Location = new Point(0, 774);
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
            btnInicio.Location = new Point(0, 0);
            btnInicio.Name = "btnInicio";
            btnInicio.Padding = new Padding(10, 0, 20, 0);
            btnInicio.Size = new Size(234, 75);
            btnInicio.TabIndex = 2;
            btnInicio.Text = "     INICIO";
            btnInicio.TextAlign = ContentAlignment.MiddleLeft;
            btnInicio.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
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
            btnAbrirCerrar.Size = new Size(234, 78);
            btnAbrirCerrar.TabIndex = 3;
            btnAbrirCerrar.Text = "     Grupo D";
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
            pnlFormularios.Size = new Size(1187, 861);
            pnlFormularios.TabIndex = 1;
            // 
            // frmMenuPrincipalGerente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1424, 861);
            Controls.Add(pnlFormularios);
            Controls.Add(pnlateral2);
            MaximizeBox = false;
            MinimumSize = new Size(1440, 900);
            Name = "frmMenuPrincipalGerente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosing += frmMenuPrincipal_FormClosing;
            pnlateral2.ResumeLayout(false);
            pnlateral1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel4.ResumeLayout(false);
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
        private Panel pnlInicio;
        private System.Windows.Forms.Timer tmrMenu;
        private Panel pnlFormularios;
        private Panel pnlSesion;
        private FontAwesome.Sharp.IconButton btnCerrarSesion;
        private FontAwesome.Sharp.IconButton btnAbrirCerrar;
        private Panel panel1;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton btnInformeInventario;
        private Panel panel4;
        private Panel panel6;
        private FontAwesome.Sharp.IconButton btnInformeVentas;
    }
}