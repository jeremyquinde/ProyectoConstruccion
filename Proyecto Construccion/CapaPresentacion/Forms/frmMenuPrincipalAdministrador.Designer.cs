
namespace CapaPresentacion
{
    partial class frmMenuPrincipalAdministrador
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
            pnlRegistroUsuario = new Panel();
            btnRegistroUsuario = new FontAwesome.Sharp.IconButton();
            pnlConsultaUsuario = new Panel();
            btnConsultaVentas = new FontAwesome.Sharp.IconButton();
            panel6 = new Panel();
            btnConsultarProducto = new FontAwesome.Sharp.IconButton();
            panel3 = new Panel();
            btnConsultaUsuario = new FontAwesome.Sharp.IconButton();
            panel4 = new Panel();
            btnRegistroProducto = new FontAwesome.Sharp.IconButton();
            panel5 = new Panel();
            btnRegistroVenta = new FontAwesome.Sharp.IconButton();
            pnlRegistroCliente = new Panel();
            btnRegistroClientes = new FontAwesome.Sharp.IconButton();
            pnlConsultaCliente = new Panel();
            btnConsultaCliente = new FontAwesome.Sharp.IconButton();
            pnlSesion = new Panel();
            btnCerrarSesion = new FontAwesome.Sharp.IconButton();
            pnlInicio = new Panel();
            btnInicio = new FontAwesome.Sharp.IconButton();
            pnlBtnAbrir = new Panel();
            btnAbrirCerrar = new FontAwesome.Sharp.IconButton();
            tmrMenu = new System.Windows.Forms.Timer(components);
            pnlFormularios = new Panel();
            pnlateral2.SuspendLayout();
            pnlateral1.SuspendLayout();
            pnlRegistroUsuario.SuspendLayout();
            pnlConsultaUsuario.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            pnlRegistroCliente.SuspendLayout();
            pnlConsultaCliente.SuspendLayout();
            pnlSesion.SuspendLayout();
            pnlInicio.SuspendLayout();
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
            pnlateral1.Controls.Add(pnlRegistroUsuario);
            pnlateral1.Controls.Add(pnlConsultaUsuario);
            pnlateral1.Controls.Add(panel6);
            pnlateral1.Controls.Add(panel3);
            pnlateral1.Controls.Add(panel4);
            pnlateral1.Controls.Add(panel5);
            pnlateral1.Controls.Add(pnlRegistroCliente);
            pnlateral1.Controls.Add(pnlConsultaCliente);
            pnlateral1.Controls.Add(pnlSesion);
            pnlateral1.Controls.Add(pnlInicio);
            pnlateral1.Controls.Add(pnlBtnAbrir);
            pnlateral1.Dock = DockStyle.Left;
            pnlateral1.Location = new Point(0, 0);
            pnlateral1.Name = "pnlateral1";
            pnlateral1.Size = new Size(237, 861);
            pnlateral1.TabIndex = 1;
            // 
            // pnlRegistroUsuario
            // 
            pnlRegistroUsuario.BackColor = Color.Transparent;
            pnlRegistroUsuario.Controls.Add(btnRegistroUsuario);
            pnlRegistroUsuario.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pnlRegistroUsuario.Location = new Point(2, 152);
            pnlRegistroUsuario.Name = "pnlRegistroUsuario";
            pnlRegistroUsuario.Size = new Size(234, 64);
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
            btnRegistroUsuario.Location = new Point(0, 0);
            btnRegistroUsuario.Name = "btnRegistroUsuario";
            btnRegistroUsuario.Padding = new Padding(10, 0, 20, 0);
            btnRegistroUsuario.Size = new Size(234, 64);
            btnRegistroUsuario.TabIndex = 5;
            btnRegistroUsuario.Text = "    REGISTRO                  USUARIO";
            btnRegistroUsuario.TextAlign = ContentAlignment.MiddleLeft;
            btnRegistroUsuario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRegistroUsuario.UseVisualStyleBackColor = true;
            btnRegistroUsuario.Click += btnRegistroUsuario_Click;
            // 
            // pnlConsultaUsuario
            // 
            pnlConsultaUsuario.BackColor = Color.Transparent;
            pnlConsultaUsuario.Controls.Add(btnConsultaVentas);
            pnlConsultaUsuario.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pnlConsultaUsuario.Location = new Point(2, 364);
            pnlConsultaUsuario.Name = "pnlConsultaUsuario";
            pnlConsultaUsuario.Size = new Size(234, 65);
            pnlConsultaUsuario.TabIndex = 3;
            // 
            // btnConsultaVentas
            // 
            btnConsultaVentas.FlatAppearance.BorderSize = 0;
            btnConsultaVentas.FlatAppearance.MouseOverBackColor = Color.FromArgb(114, 63, 192);
            btnConsultaVentas.FlatStyle = FlatStyle.Flat;
            btnConsultaVentas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnConsultaVentas.ForeColor = Color.FromArgb(229, 212, 251);
            btnConsultaVentas.IconChar = FontAwesome.Sharp.IconChar.LineChart;
            btnConsultaVentas.IconColor = Color.FromArgb(229, 212, 251);
            btnConsultaVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnConsultaVentas.IconSize = 40;
            btnConsultaVentas.ImageAlign = ContentAlignment.MiddleLeft;
            btnConsultaVentas.Location = new Point(0, 0);
            btnConsultaVentas.Name = "btnConsultaVentas";
            btnConsultaVentas.Padding = new Padding(10, 0, 20, 0);
            btnConsultaVentas.Size = new Size(234, 65);
            btnConsultaVentas.TabIndex = 6;
            btnConsultaVentas.Text = "     CONSULTA                 VENTAS";
            btnConsultaVentas.TextAlign = ContentAlignment.MiddleLeft;
            btnConsultaVentas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConsultaVentas.UseVisualStyleBackColor = true;
            btnConsultaVentas.Click += btnConsultaVentas_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Transparent;
            panel6.Controls.Add(btnConsultarProducto);
            panel6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panel6.Location = new Point(3, 651);
            panel6.Name = "panel6";
            panel6.Size = new Size(234, 64);
            panel6.TabIndex = 13;
            // 
            // btnConsultarProducto
            // 
            btnConsultarProducto.FlatAppearance.BorderSize = 0;
            btnConsultarProducto.FlatAppearance.MouseOverBackColor = Color.FromArgb(114, 63, 192);
            btnConsultarProducto.FlatStyle = FlatStyle.Flat;
            btnConsultarProducto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnConsultarProducto.ForeColor = Color.FromArgb(229, 212, 251);
            btnConsultarProducto.IconChar = FontAwesome.Sharp.IconChar.BoxesPacking;
            btnConsultarProducto.IconColor = Color.FromArgb(229, 212, 251);
            btnConsultarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnConsultarProducto.IconSize = 40;
            btnConsultarProducto.ImageAlign = ContentAlignment.MiddleLeft;
            btnConsultarProducto.Location = new Point(0, 0);
            btnConsultarProducto.Name = "btnConsultarProducto";
            btnConsultarProducto.Padding = new Padding(10, 0, 20, 0);
            btnConsultarProducto.Size = new Size(234, 64);
            btnConsultarProducto.TabIndex = 12;
            btnConsultarProducto.Text = "     CONSULTA                 PRODUCTO";
            btnConsultarProducto.TextAlign = ContentAlignment.MiddleLeft;
            btnConsultarProducto.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConsultarProducto.UseVisualStyleBackColor = true;
            btnConsultarProducto.Click += btnConsultarProducto_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(btnConsultaUsuario);
            panel3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panel3.Location = new Point(2, 222);
            panel3.Name = "panel3";
            panel3.Size = new Size(234, 64);
            panel3.TabIndex = 11;
            // 
            // btnConsultaUsuario
            // 
            btnConsultaUsuario.FlatAppearance.BorderSize = 0;
            btnConsultaUsuario.FlatAppearance.MouseOverBackColor = Color.FromArgb(114, 63, 192);
            btnConsultaUsuario.FlatStyle = FlatStyle.Flat;
            btnConsultaUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnConsultaUsuario.ForeColor = Color.FromArgb(229, 212, 251);
            btnConsultaUsuario.IconChar = FontAwesome.Sharp.IconChar.ClipboardUser;
            btnConsultaUsuario.IconColor = Color.FromArgb(229, 212, 251);
            btnConsultaUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnConsultaUsuario.IconSize = 40;
            btnConsultaUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            btnConsultaUsuario.Location = new Point(0, 0);
            btnConsultaUsuario.Name = "btnConsultaUsuario";
            btnConsultaUsuario.Padding = new Padding(10, 0, 20, 0);
            btnConsultaUsuario.Size = new Size(234, 64);
            btnConsultaUsuario.TabIndex = 11;
            btnConsultaUsuario.Text = "    CONSULTA                 USUARIO";
            btnConsultaUsuario.TextAlign = ContentAlignment.MiddleLeft;
            btnConsultaUsuario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConsultaUsuario.UseVisualStyleBackColor = true;
            btnConsultaUsuario.Click += btnConsultaUsuario_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(btnRegistroProducto);
            panel4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panel4.Location = new Point(2, 586);
            panel4.Name = "panel4";
            panel4.Size = new Size(234, 64);
            panel4.TabIndex = 14;
            // 
            // btnRegistroProducto
            // 
            btnRegistroProducto.FlatAppearance.BorderSize = 0;
            btnRegistroProducto.FlatAppearance.MouseOverBackColor = Color.FromArgb(114, 63, 192);
            btnRegistroProducto.FlatStyle = FlatStyle.Flat;
            btnRegistroProducto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistroProducto.ForeColor = Color.FromArgb(229, 212, 251);
            btnRegistroProducto.IconChar = FontAwesome.Sharp.IconChar.Gear;
            btnRegistroProducto.IconColor = Color.FromArgb(229, 212, 251);
            btnRegistroProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRegistroProducto.IconSize = 40;
            btnRegistroProducto.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistroProducto.Location = new Point(1, 0);
            btnRegistroProducto.Name = "btnRegistroProducto";
            btnRegistroProducto.Padding = new Padding(10, 0, 20, 0);
            btnRegistroProducto.Size = new Size(234, 64);
            btnRegistroProducto.TabIndex = 6;
            btnRegistroProducto.Text = "     REGISTRO                  PRODUCTO";
            btnRegistroProducto.TextAlign = ContentAlignment.MiddleLeft;
            btnRegistroProducto.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRegistroProducto.UseVisualStyleBackColor = true;
            btnRegistroProducto.Click += btnRegistroProducto_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.Controls.Add(btnRegistroVenta);
            panel5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panel5.Location = new Point(3, 293);
            panel5.Name = "panel5";
            panel5.Size = new Size(234, 65);
            panel5.TabIndex = 12;
            // 
            // btnRegistroVenta
            // 
            btnRegistroVenta.FlatAppearance.BorderSize = 0;
            btnRegistroVenta.FlatAppearance.MouseOverBackColor = Color.FromArgb(114, 63, 192);
            btnRegistroVenta.FlatStyle = FlatStyle.Flat;
            btnRegistroVenta.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistroVenta.ForeColor = Color.FromArgb(229, 212, 251);
            btnRegistroVenta.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            btnRegistroVenta.IconColor = Color.FromArgb(229, 212, 251);
            btnRegistroVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRegistroVenta.IconSize = 40;
            btnRegistroVenta.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistroVenta.Location = new Point(0, 0);
            btnRegistroVenta.Name = "btnRegistroVenta";
            btnRegistroVenta.Padding = new Padding(10, 0, 20, 0);
            btnRegistroVenta.Size = new Size(234, 65);
            btnRegistroVenta.TabIndex = 6;
            btnRegistroVenta.Text = "     REGISTRO                   VENTAS";
            btnRegistroVenta.TextAlign = ContentAlignment.MiddleLeft;
            btnRegistroVenta.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRegistroVenta.UseVisualStyleBackColor = true;
            btnRegistroVenta.Click += btnRegistroVenta_Click;
            // 
            // pnlRegistroCliente
            // 
            pnlRegistroCliente.BackColor = Color.Transparent;
            pnlRegistroCliente.Controls.Add(btnRegistroClientes);
            pnlRegistroCliente.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pnlRegistroCliente.Location = new Point(1, 437);
            pnlRegistroCliente.Name = "pnlRegistroCliente";
            pnlRegistroCliente.Size = new Size(234, 64);
            pnlRegistroCliente.TabIndex = 14;
            // 
            // btnRegistroClientes
            // 
            btnRegistroClientes.FlatAppearance.BorderSize = 0;
            btnRegistroClientes.FlatAppearance.MouseOverBackColor = Color.FromArgb(114, 63, 192);
            btnRegistroClientes.FlatStyle = FlatStyle.Flat;
            btnRegistroClientes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistroClientes.ForeColor = Color.FromArgb(229, 212, 251);
            btnRegistroClientes.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            btnRegistroClientes.IconColor = Color.FromArgb(229, 212, 251);
            btnRegistroClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRegistroClientes.IconSize = 40;
            btnRegistroClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistroClientes.Location = new Point(2, 0);
            btnRegistroClientes.Name = "btnRegistroClientes";
            btnRegistroClientes.Padding = new Padding(10, 0, 20, 0);
            btnRegistroClientes.Size = new Size(234, 64);
            btnRegistroClientes.TabIndex = 4;
            btnRegistroClientes.Text = "     REGISTRO                   CLIENTE";
            btnRegistroClientes.TextAlign = ContentAlignment.MiddleLeft;
            btnRegistroClientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRegistroClientes.UseVisualStyleBackColor = true;
            btnRegistroClientes.Click += btnRegistroClientes_Click;
            // 
            // pnlConsultaCliente
            // 
            pnlConsultaCliente.BackColor = Color.Transparent;
            pnlConsultaCliente.Controls.Add(btnConsultaCliente);
            pnlConsultaCliente.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pnlConsultaCliente.Location = new Point(3, 512);
            pnlConsultaCliente.Name = "pnlConsultaCliente";
            pnlConsultaCliente.Size = new Size(234, 64);
            pnlConsultaCliente.TabIndex = 2;
            // 
            // btnConsultaCliente
            // 
            btnConsultaCliente.FlatAppearance.BorderSize = 0;
            btnConsultaCliente.FlatAppearance.MouseOverBackColor = Color.FromArgb(114, 63, 192);
            btnConsultaCliente.FlatStyle = FlatStyle.Flat;
            btnConsultaCliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnConsultaCliente.ForeColor = Color.FromArgb(229, 212, 251);
            btnConsultaCliente.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            btnConsultaCliente.IconColor = Color.FromArgb(229, 212, 251);
            btnConsultaCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnConsultaCliente.IconSize = 40;
            btnConsultaCliente.ImageAlign = ContentAlignment.MiddleLeft;
            btnConsultaCliente.Location = new Point(-3, 0);
            btnConsultaCliente.Name = "btnConsultaCliente";
            btnConsultaCliente.Padding = new Padding(10, 0, 20, 0);
            btnConsultaCliente.Size = new Size(234, 64);
            btnConsultaCliente.TabIndex = 10;
            btnConsultaCliente.Text = "      CONSULTA                 CLIENTE";
            btnConsultaCliente.TextAlign = ContentAlignment.MiddleLeft;
            btnConsultaCliente.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConsultaCliente.UseVisualStyleBackColor = true;
            btnConsultaCliente.Click += btnConsultaCliente_Click;
            // 
            // pnlSesion
            // 
            pnlSesion.Controls.Add(btnCerrarSesion);
            pnlSesion.Location = new Point(0, 781);
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
            pnlInicio.Location = new Point(0, 81);
            pnlInicio.Name = "pnlInicio";
            pnlInicio.Size = new Size(234, 64);
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
            btnInicio.Location = new Point(2, 0);
            btnInicio.Name = "btnInicio";
            btnInicio.Padding = new Padding(10, 0, 20, 0);
            btnInicio.Size = new Size(234, 64);
            btnInicio.TabIndex = 2;
            btnInicio.Text = "      INICIO";
            btnInicio.TextAlign = ContentAlignment.MiddleLeft;
            btnInicio.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
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
            // frmMenuPrincipalAdministrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1424, 861);
            Controls.Add(pnlFormularios);
            Controls.Add(pnlateral2);
            MaximizeBox = false;
            MinimumSize = new Size(1440, 900);
            Name = "frmMenuPrincipalAdministrador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosing += frmMenuPrincipal_FormClosing;
            pnlateral2.ResumeLayout(false);
            pnlateral1.ResumeLayout(false);
            pnlRegistroUsuario.ResumeLayout(false);
            pnlConsultaUsuario.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            pnlRegistroCliente.ResumeLayout(false);
            pnlConsultaCliente.ResumeLayout(false);
            pnlSesion.ResumeLayout(false);
            pnlInicio.ResumeLayout(false);
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
        private FontAwesome.Sharp.IconButton btnConsultaCliente;
        private Panel pnlConsultaUsuario;
        private Panel pnlRegistroCliente;
        private FontAwesome.Sharp.IconButton btnRegistroProducto;
        private FontAwesome.Sharp.IconButton btnConsultarProducto;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private FontAwesome.Sharp.IconButton btnConsultaVentas;
        private Panel panel6;
        private FontAwesome.Sharp.IconButton btnRegistroVenta;
    }
}