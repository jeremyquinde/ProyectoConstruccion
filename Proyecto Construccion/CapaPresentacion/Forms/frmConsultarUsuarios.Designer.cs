namespace CapaPresentacion.Forms
{
    partial class frmConsultarUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label4 = new Label();
            pnlEditar = new Panel();
            txtEditarContraseña = new TextBox();
            label11 = new Label();
            txtEditarFechaRegistro = new TextBox();
            label12 = new Label();
            btnGuardarCambios = new FontAwesome.Sharp.IconButton();
            label13 = new Label();
            label14 = new Label();
            label9 = new Label();
            txtId = new TextBox();
            txtEditarTelefono = new TextBox();
            label10 = new Label();
            txtEditarDireccion = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            txtEditarCorreo = new TextBox();
            label6 = new Label();
            txtEditarCedula = new TextBox();
            label3 = new Label();
            txtEditarApellido = new TextBox();
            label2 = new Label();
            txtEditarNombre = new TextBox();
            label1 = new Label();
            dgvConsultarUsuarios = new DataGridView();
            idUsuarioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombresDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            apellidosDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefonoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rolDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            columnEditar = new DataGridViewImageColumn();
            columnEliminar = new DataGridViewImageColumn();
            usuarioViewModelBindingSource2 = new BindingSource(components);
            usuarioViewModelBindingSource1 = new BindingSource(components);
            usuarioViewModelBindingSource = new BindingSource(components);
            cmbRol = new ComboBox();
            pnlEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsultarUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usuarioViewModelBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usuarioViewModelBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usuarioViewModelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(416, 37);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(429, 46);
            label4.TabIndex = 65;
            label4.Text = "USUARIOS REGISTRADOS";
            // 
            // pnlEditar
            // 
            pnlEditar.BackColor = Color.FromArgb(62, 49, 147);
            pnlEditar.BorderStyle = BorderStyle.FixedSingle;
            pnlEditar.Controls.Add(cmbRol);
            pnlEditar.Controls.Add(txtEditarContraseña);
            pnlEditar.Controls.Add(label11);
            pnlEditar.Controls.Add(txtEditarFechaRegistro);
            pnlEditar.Controls.Add(label12);
            pnlEditar.Controls.Add(btnGuardarCambios);
            pnlEditar.Controls.Add(label13);
            pnlEditar.Controls.Add(label14);
            pnlEditar.Controls.Add(label9);
            pnlEditar.Controls.Add(txtId);
            pnlEditar.Controls.Add(txtEditarTelefono);
            pnlEditar.Controls.Add(label10);
            pnlEditar.Controls.Add(txtEditarDireccion);
            pnlEditar.Controls.Add(label8);
            pnlEditar.Controls.Add(label7);
            pnlEditar.Controls.Add(label5);
            pnlEditar.Controls.Add(txtEditarCorreo);
            pnlEditar.Controls.Add(label6);
            pnlEditar.Controls.Add(txtEditarCedula);
            pnlEditar.Controls.Add(label3);
            pnlEditar.Controls.Add(txtEditarApellido);
            pnlEditar.Controls.Add(label2);
            pnlEditar.Controls.Add(txtEditarNombre);
            pnlEditar.Controls.Add(label1);
            pnlEditar.Dock = DockStyle.Right;
            pnlEditar.Location = new Point(871, 0);
            pnlEditar.Margin = new Padding(0);
            pnlEditar.Name = "pnlEditar";
            pnlEditar.Size = new Size(316, 861);
            pnlEditar.TabIndex = 64;
            pnlEditar.Visible = false;
            // 
            // txtEditarContraseña
            // 
            txtEditarContraseña.Anchor = AnchorStyles.None;
            txtEditarContraseña.BackColor = Color.Gainsboro;
            txtEditarContraseña.Location = new Point(30, 699);
            txtEditarContraseña.Margin = new Padding(4);
            txtEditarContraseña.Name = "txtEditarContraseña";
            txtEditarContraseña.Size = new Size(255, 23);
            txtEditarContraseña.TabIndex = 96;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.FlatStyle = FlatStyle.Flat;
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(229, 212, 251);
            label11.Location = new Point(31, 676);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(103, 19);
            label11.TabIndex = 94;
            label11.Text = "CONTRASEÑA";
            // 
            // txtEditarFechaRegistro
            // 
            txtEditarFechaRegistro.Anchor = AnchorStyles.None;
            txtEditarFechaRegistro.BackColor = Color.Gainsboro;
            txtEditarFechaRegistro.Location = new Point(30, 640);
            txtEditarFechaRegistro.Margin = new Padding(4);
            txtEditarFechaRegistro.Name = "txtEditarFechaRegistro";
            txtEditarFechaRegistro.Size = new Size(255, 23);
            txtEditarFechaRegistro.TabIndex = 93;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.FlatStyle = FlatStyle.Flat;
            label12.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(37, 557);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(0, 25);
            label12.TabIndex = 90;
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.Anchor = AnchorStyles.None;
            btnGuardarCambios.IconChar = FontAwesome.Sharp.IconChar.None;
            btnGuardarCambios.IconColor = Color.Black;
            btnGuardarCambios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardarCambios.Location = new Point(59, 769);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Size = new Size(204, 38);
            btnGuardarCambios.TabIndex = 86;
            btnGuardarCambios.Text = "GUARDAR CAMBIOS";
            btnGuardarCambios.UseVisualStyleBackColor = true;
            btnGuardarCambios.Click += btnGuardarCambios_Click;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.None;
            label13.AutoSize = true;
            label13.FlatStyle = FlatStyle.Flat;
            label13.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.FromArgb(229, 212, 251);
            label13.Location = new Point(30, 617);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(123, 19);
            label13.TabIndex = 89;
            label13.Text = "FECHA REGISTRO";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.None;
            label14.AutoSize = true;
            label14.FlatStyle = FlatStyle.Flat;
            label14.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.FromArgb(229, 212, 251);
            label14.Location = new Point(30, 557);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(36, 19);
            label14.TabIndex = 87;
            label14.Text = "ROL";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.FlatStyle = FlatStyle.Flat;
            label9.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(229, 212, 251);
            label9.Location = new Point(43, 76);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(238, 37);
            label9.TabIndex = 63;
            label9.Text = "EDITAR USUARIO";
            // 
            // txtId
            // 
            txtId.Anchor = AnchorStyles.None;
            txtId.BackColor = Color.Gainsboro;
            txtId.Enabled = false;
            txtId.Location = new Point(30, 157);
            txtId.Margin = new Padding(4);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(255, 23);
            txtId.TabIndex = 85;
            // 
            // txtEditarTelefono
            // 
            txtEditarTelefono.Anchor = AnchorStyles.None;
            txtEditarTelefono.BackColor = Color.Gainsboro;
            txtEditarTelefono.Location = new Point(30, 463);
            txtEditarTelefono.Margin = new Padding(4);
            txtEditarTelefono.Name = "txtEditarTelefono";
            txtEditarTelefono.Size = new Size(255, 23);
            txtEditarTelefono.TabIndex = 81;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.FlatStyle = FlatStyle.Flat;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(229, 212, 251);
            label10.Location = new Point(30, 132);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(23, 19);
            label10.TabIndex = 84;
            label10.Text = "ID";
            // 
            // txtEditarDireccion
            // 
            txtEditarDireccion.Anchor = AnchorStyles.None;
            txtEditarDireccion.BackColor = Color.Gainsboro;
            txtEditarDireccion.Location = new Point(30, 521);
            txtEditarDireccion.Margin = new Padding(4);
            txtEditarDireccion.Name = "txtEditarDireccion";
            txtEditarDireccion.Size = new Size(255, 23);
            txtEditarDireccion.TabIndex = 83;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.FlatStyle = FlatStyle.Flat;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(229, 212, 251);
            label8.Location = new Point(30, 377);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(65, 19);
            label8.TabIndex = 82;
            label8.Text = "CORREO";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(37, 436);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(0, 25);
            label7.TabIndex = 77;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(229, 212, 251);
            label5.Location = new Point(30, 498);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(83, 19);
            label5.TabIndex = 75;
            label5.Text = "DIRECCION";
            // 
            // txtEditarCorreo
            // 
            txtEditarCorreo.Anchor = AnchorStyles.None;
            txtEditarCorreo.BackColor = Color.Gainsboro;
            txtEditarCorreo.Location = new Point(30, 400);
            txtEditarCorreo.Margin = new Padding(4);
            txtEditarCorreo.Name = "txtEditarCorreo";
            txtEditarCorreo.Size = new Size(255, 23);
            txtEditarCorreo.TabIndex = 74;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(229, 212, 251);
            label6.Location = new Point(30, 436);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(78, 19);
            label6.TabIndex = 73;
            label6.Text = "TELEFONO";
            // 
            // txtEditarCedula
            // 
            txtEditarCedula.Anchor = AnchorStyles.None;
            txtEditarCedula.BackColor = Color.Gainsboro;
            txtEditarCedula.Location = new Point(30, 340);
            txtEditarCedula.Margin = new Padding(4);
            txtEditarCedula.Name = "txtEditarCedula";
            txtEditarCedula.Size = new Size(255, 23);
            txtEditarCedula.TabIndex = 70;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(229, 212, 251);
            label3.Location = new Point(30, 317);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(62, 19);
            label3.TabIndex = 69;
            label3.Text = "CEDULA";
            // 
            // txtEditarApellido
            // 
            txtEditarApellido.Anchor = AnchorStyles.None;
            txtEditarApellido.BackColor = Color.Gainsboro;
            txtEditarApellido.Location = new Point(30, 281);
            txtEditarApellido.Margin = new Padding(4);
            txtEditarApellido.Name = "txtEditarApellido";
            txtEditarApellido.Size = new Size(255, 23);
            txtEditarApellido.TabIndex = 66;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(229, 212, 251);
            label2.Location = new Point(30, 257);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(82, 19);
            label2.TabIndex = 65;
            label2.Text = "APELLIDOS";
            // 
            // txtEditarNombre
            // 
            txtEditarNombre.Anchor = AnchorStyles.None;
            txtEditarNombre.BackColor = Color.Gainsboro;
            txtEditarNombre.Location = new Point(30, 218);
            txtEditarNombre.Margin = new Padding(4);
            txtEditarNombre.Name = "txtEditarNombre";
            txtEditarNombre.Size = new Size(255, 23);
            txtEditarNombre.TabIndex = 64;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(229, 212, 251);
            label1.Location = new Point(30, 194);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(77, 19);
            label1.TabIndex = 63;
            label1.Text = "NOMBRES";
            // 
            // dgvConsultarUsuarios
            // 
            dgvConsultarUsuarios.AllowUserToAddRows = false;
            dgvConsultarUsuarios.AllowUserToDeleteRows = false;
            dgvConsultarUsuarios.AllowUserToResizeColumns = false;
            dgvConsultarUsuarios.AllowUserToResizeRows = false;
            dgvConsultarUsuarios.Anchor = AnchorStyles.None;
            dgvConsultarUsuarios.AutoGenerateColumns = false;
            dgvConsultarUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvConsultarUsuarios.BackgroundColor = Color.White;
            dgvConsultarUsuarios.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvConsultarUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(62, 49, 147);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvConsultarUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvConsultarUsuarios.ColumnHeadersHeight = 35;
            dgvConsultarUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvConsultarUsuarios.Columns.AddRange(new DataGridViewColumn[] { idUsuarioDataGridViewTextBoxColumn, nombresDataGridViewTextBoxColumn, apellidosDataGridViewTextBoxColumn, telefonoDataGridViewTextBoxColumn, rolDataGridViewTextBoxColumn, columnEditar, columnEliminar });
            dgvConsultarUsuarios.DataSource = usuarioViewModelBindingSource2;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvConsultarUsuarios.DefaultCellStyle = dataGridViewCellStyle2;
            dgvConsultarUsuarios.EnableHeadersVisualStyles = false;
            dgvConsultarUsuarios.GridColor = Color.FromArgb(233, 233, 233);
            dgvConsultarUsuarios.Location = new Point(55, 117);
            dgvConsultarUsuarios.Name = "dgvConsultarUsuarios";
            dgvConsultarUsuarios.ReadOnly = true;
            dgvConsultarUsuarios.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Blue;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(0, 0, 192);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvConsultarUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvConsultarUsuarios.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dgvConsultarUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvConsultarUsuarios.RowTemplate.Height = 25;
            dgvConsultarUsuarios.Size = new Size(1054, 691);
            dgvConsultarUsuarios.TabIndex = 63;
            dgvConsultarUsuarios.CellContentClick += dgvConsultarUsuarios_CellContentClick;
            // 
            // idUsuarioDataGridViewTextBoxColumn
            // 
            idUsuarioDataGridViewTextBoxColumn.DataPropertyName = "IdUsuario";
            idUsuarioDataGridViewTextBoxColumn.FillWeight = 96.25668F;
            idUsuarioDataGridViewTextBoxColumn.HeaderText = "IdUsuario";
            idUsuarioDataGridViewTextBoxColumn.Name = "idUsuarioDataGridViewTextBoxColumn";
            idUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombresDataGridViewTextBoxColumn
            // 
            nombresDataGridViewTextBoxColumn.DataPropertyName = "Nombres";
            nombresDataGridViewTextBoxColumn.FillWeight = 100.748665F;
            nombresDataGridViewTextBoxColumn.HeaderText = "Nombres";
            nombresDataGridViewTextBoxColumn.Name = "nombresDataGridViewTextBoxColumn";
            nombresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            apellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos";
            apellidosDataGridViewTextBoxColumn.FillWeight = 100.748665F;
            apellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            apellidosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            telefonoDataGridViewTextBoxColumn.FillWeight = 100.748665F;
            telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rolDataGridViewTextBoxColumn
            // 
            rolDataGridViewTextBoxColumn.DataPropertyName = "Rol";
            rolDataGridViewTextBoxColumn.FillWeight = 100.748665F;
            rolDataGridViewTextBoxColumn.HeaderText = "Rol";
            rolDataGridViewTextBoxColumn.Name = "rolDataGridViewTextBoxColumn";
            rolDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // columnEditar
            // 
            columnEditar.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            columnEditar.FillWeight = 60F;
            columnEditar.HeaderText = "";
            columnEditar.Image = Properties.Resources.editar1;
            columnEditar.Name = "columnEditar";
            columnEditar.ReadOnly = true;
            columnEditar.Resizable = DataGridViewTriState.False;
            columnEditar.Width = 5;
            // 
            // columnEliminar
            // 
            columnEliminar.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            columnEliminar.FillWeight = 20F;
            columnEliminar.HeaderText = "";
            columnEliminar.Image = Properties.Resources.eliminar;
            columnEliminar.Name = "columnEliminar";
            columnEliminar.ReadOnly = true;
            columnEliminar.Resizable = DataGridViewTriState.False;
            columnEliminar.Width = 5;
            // 
            // usuarioViewModelBindingSource2
            // 
            usuarioViewModelBindingSource2.DataSource = typeof(ViewModels.UsuarioViewModel);
            // 
            // usuarioViewModelBindingSource1
            // 
            usuarioViewModelBindingSource1.DataSource = typeof(ViewModels.UsuarioViewModel);
            // 
            // usuarioViewModelBindingSource
            // 
            usuarioViewModelBindingSource.DataSource = typeof(ViewModels.UsuarioViewModel);
            // 
            // cmbRol
            // 
            cmbRol.BackColor = Color.Gainsboro;
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(32, 579);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(253, 23);
            cmbRol.TabIndex = 97;
            // 
            // frmConsultarUsuarios
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1187, 861);
            Controls.Add(pnlEditar);
            Controls.Add(dgvConsultarUsuarios);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmConsultarUsuarios";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmConsultarUsuarios";
            Load += frmConsultarUsuarios_Load;
            pnlEditar.ResumeLayout(false);
            pnlEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsultarUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)usuarioViewModelBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)usuarioViewModelBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)usuarioViewModelBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Panel pnlEditar;
        private Label label9;
        private FontAwesome.Sharp.IconButton btnGuardarCambios;
        private TextBox txtId;
        private Label label10;
        private TextBox txtEditarDireccion;
        private Label label8;
        private TextBox txtEditarTelefono;
        private Label label7;
        private Label label5;
        private TextBox txtEditarCorreo;
        private Label label6;
        private TextBox txtEditarCedula;
        private Label label3;
        private TextBox txtEditarApellido;
        private Label label2;
        private TextBox txtEditarNombre;
        private Label label1;
        private DataGridView dgvConsultarUsuarios;
        private TextBox txtEditarFechaRegistro;
        private Label label12;
        private Label label13;
        private Label label14;
        private TextBox txtEditarContraseña;
        private Label label11;
        private BindingSource usuarioViewModelBindingSource;
        private BindingSource usuarioViewModelBindingSource1;
        private BindingSource usuarioViewModelBindingSource2;
        private DataGridViewTextBoxColumn idUsuarioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombresDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rolDataGridViewTextBoxColumn;
        private DataGridViewImageColumn columnEditar;
        private DataGridViewImageColumn columnEliminar;
        private ComboBox cmbRol;
    }
}