namespace CapaPresentacion
{
    partial class frmConsultarClientes
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
            dgvConsultarClientes = new DataGridView();
            idClienteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombresDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            apellidosDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Cedula = new DataGridViewTextBoxColumn();
            columnEditar = new DataGridViewImageColumn();
            columnEliminar = new DataGridViewImageColumn();
            clienteViewModelBindingSource = new BindingSource(components);
            clienteModelBindingSource = new BindingSource(components);
            pnlEditar = new Panel();
            label9 = new Label();
            btnGuardarCambios = new FontAwesome.Sharp.IconButton();
            txtId = new TextBox();
            label10 = new Label();
            txtEditarDireccion = new TextBox();
            label8 = new Label();
            txtEditarTelefono = new TextBox();
            label7 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            txtEditarCorreo = new TextBox();
            label6 = new Label();
            txtEditarCedula = new TextBox();
            label3 = new Label();
            txtEditarApellido = new TextBox();
            label2 = new Label();
            txtEditarNombre = new TextBox();
            label1 = new Label();
            label4 = new Label();
            clienteModelBindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvConsultarClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clienteViewModelBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clienteModelBindingSource).BeginInit();
            pnlEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)clienteModelBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dgvConsultarClientes
            // 
            dgvConsultarClientes.AllowUserToAddRows = false;
            dgvConsultarClientes.AllowUserToDeleteRows = false;
            dgvConsultarClientes.AllowUserToResizeColumns = false;
            dgvConsultarClientes.AllowUserToResizeRows = false;
            dgvConsultarClientes.Anchor = AnchorStyles.None;
            dgvConsultarClientes.AutoGenerateColumns = false;
            dgvConsultarClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvConsultarClientes.BackgroundColor = Color.White;
            dgvConsultarClientes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvConsultarClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(62, 49, 147);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvConsultarClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvConsultarClientes.ColumnHeadersHeight = 35;
            dgvConsultarClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvConsultarClientes.Columns.AddRange(new DataGridViewColumn[] { idClienteDataGridViewTextBoxColumn, nombresDataGridViewTextBoxColumn, apellidosDataGridViewTextBoxColumn, Cedula, columnEditar, columnEliminar });
            dgvConsultarClientes.DataSource = clienteViewModelBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvConsultarClientes.DefaultCellStyle = dataGridViewCellStyle2;
            dgvConsultarClientes.EnableHeadersVisualStyles = false;
            dgvConsultarClientes.GridColor = Color.FromArgb(233, 233, 233);
            dgvConsultarClientes.Location = new Point(55, 117);
            dgvConsultarClientes.Name = "dgvConsultarClientes";
            dgvConsultarClientes.ReadOnly = true;
            dgvConsultarClientes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Blue;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(0, 0, 192);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvConsultarClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvConsultarClientes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dgvConsultarClientes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvConsultarClientes.RowTemplate.Height = 25;
            dgvConsultarClientes.Size = new Size(1054, 691);
            dgvConsultarClientes.TabIndex = 60;
            dgvConsultarClientes.CellContentClick += dgvConsultarClientes_CellContentClick;
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            idClienteDataGridViewTextBoxColumn.DataPropertyName = "IdCliente";
            idClienteDataGridViewTextBoxColumn.HeaderText = "IdCliente";
            idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            idClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombresDataGridViewTextBoxColumn
            // 
            nombresDataGridViewTextBoxColumn.DataPropertyName = "Nombres";
            nombresDataGridViewTextBoxColumn.HeaderText = "Nombres";
            nombresDataGridViewTextBoxColumn.Name = "nombresDataGridViewTextBoxColumn";
            nombresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            apellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos";
            apellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            apellidosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Cedula
            // 
            Cedula.DataPropertyName = "Cedula";
            Cedula.HeaderText = "Cedula";
            Cedula.Name = "Cedula";
            Cedula.ReadOnly = true;
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
            // clienteViewModelBindingSource
            // 
            clienteViewModelBindingSource.DataSource = typeof(ViewModels.ClienteViewModel);
            // 
            // clienteModelBindingSource
            // 
            clienteModelBindingSource.DataSource = typeof(CapaNegocio.Modelo.ClienteModel);
            // 
            // pnlEditar
            // 
            pnlEditar.BackColor = Color.FromArgb(62, 49, 147);
            pnlEditar.BorderStyle = BorderStyle.FixedSingle;
            pnlEditar.Controls.Add(label9);
            pnlEditar.Controls.Add(btnGuardarCambios);
            pnlEditar.Controls.Add(txtId);
            pnlEditar.Controls.Add(label10);
            pnlEditar.Controls.Add(txtEditarDireccion);
            pnlEditar.Controls.Add(label8);
            pnlEditar.Controls.Add(txtEditarTelefono);
            pnlEditar.Controls.Add(label7);
            pnlEditar.Controls.Add(textBox3);
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
            pnlEditar.TabIndex = 61;
            pnlEditar.Visible = false;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.FlatStyle = FlatStyle.Flat;
            label9.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(229, 212, 251);
            label9.Location = new Point(51, 76);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(223, 37);
            label9.TabIndex = 63;
            label9.Text = "EDITAR CLIENTE";
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.Anchor = AnchorStyles.None;
            btnGuardarCambios.IconChar = FontAwesome.Sharp.IconChar.None;
            btnGuardarCambios.IconColor = Color.Black;
            btnGuardarCambios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardarCambios.Location = new Point(51, 669);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Size = new Size(204, 38);
            btnGuardarCambios.TabIndex = 86;
            btnGuardarCambios.Text = "GUARDAR CAMBIOS";
            btnGuardarCambios.UseVisualStyleBackColor = true;
            btnGuardarCambios.Click += btnGuardarCambios_Click;
            // 
            // txtId
            // 
            txtId.Anchor = AnchorStyles.None;
            txtId.BackColor = Color.Gainsboro;
            txtId.Enabled = false;
            txtId.Location = new Point(29, 193);
            txtId.Margin = new Padding(4);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(255, 23);
            txtId.TabIndex = 85;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.FlatStyle = FlatStyle.Flat;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(229, 212, 251);
            label10.Location = new Point(29, 168);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(27, 21);
            label10.TabIndex = 84;
            label10.Text = "ID";
            // 
            // txtEditarDireccion
            // 
            txtEditarDireccion.Anchor = AnchorStyles.None;
            txtEditarDireccion.BackColor = Color.Gainsboro;
            txtEditarDireccion.Location = new Point(29, 586);
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
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(229, 212, 251);
            label8.Location = new Point(29, 432);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(73, 21);
            label8.TabIndex = 82;
            label8.Text = "CORREO";
            // 
            // txtEditarTelefono
            // 
            txtEditarTelefono.Anchor = AnchorStyles.None;
            txtEditarTelefono.BackColor = Color.Gainsboro;
            txtEditarTelefono.Location = new Point(29, 521);
            txtEditarTelefono.Margin = new Padding(4);
            txtEditarTelefono.Name = "txtEditarTelefono";
            txtEditarTelefono.Size = new Size(255, 23);
            txtEditarTelefono.TabIndex = 81;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(30, 500);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(0, 25);
            label7.TabIndex = 77;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.BackColor = Color.Gainsboro;
            textBox3.Location = new Point(29, 525);
            textBox3.Margin = new Padding(4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(255, 23);
            textBox3.TabIndex = 76;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(229, 212, 251);
            label5.Location = new Point(29, 561);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(96, 21);
            label5.TabIndex = 75;
            label5.Text = "DIRECCION";
            // 
            // txtEditarCorreo
            // 
            txtEditarCorreo.Anchor = AnchorStyles.None;
            txtEditarCorreo.BackColor = Color.Gainsboro;
            txtEditarCorreo.Location = new Point(29, 457);
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
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(229, 212, 251);
            label6.Location = new Point(29, 496);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(90, 21);
            label6.TabIndex = 73;
            label6.Text = "TELEFONO";
            // 
            // txtEditarCedula
            // 
            txtEditarCedula.Anchor = AnchorStyles.None;
            txtEditarCedula.BackColor = Color.Gainsboro;
            txtEditarCedula.Location = new Point(29, 392);
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
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(229, 212, 251);
            label3.Location = new Point(29, 367);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(72, 21);
            label3.TabIndex = 69;
            label3.Text = "CEDULA";
            // 
            // txtEditarApellido
            // 
            txtEditarApellido.Anchor = AnchorStyles.None;
            txtEditarApellido.BackColor = Color.Gainsboro;
            txtEditarApellido.Location = new Point(29, 328);
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
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(229, 212, 251);
            label2.Location = new Point(29, 302);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(94, 21);
            label2.TabIndex = 65;
            label2.Text = "APELLIDOS";
            // 
            // txtEditarNombre
            // 
            txtEditarNombre.Anchor = AnchorStyles.None;
            txtEditarNombre.BackColor = Color.Gainsboro;
            txtEditarNombre.Location = new Point(29, 262);
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
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(229, 212, 251);
            label1.Location = new Point(29, 237);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 21);
            label1.TabIndex = 63;
            label1.Text = "NOMBRES";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(427, 37);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(410, 46);
            label4.TabIndex = 62;
            label4.Text = "CLIENTES REGISTRADOS";
            // 
            // clienteModelBindingSource1
            // 
            clienteModelBindingSource1.DataSource = typeof(CapaNegocio.Modelo.ClienteModel);
            // 
            // frmConsultarClientes
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1187, 861);
            Controls.Add(pnlEditar);
            Controls.Add(dgvConsultarClientes);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmConsultarClientes";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            Load += frmConsultarClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvConsultarClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)clienteViewModelBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)clienteModelBindingSource).EndInit();
            pnlEditar.ResumeLayout(false);
            pnlEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)clienteModelBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvConsultarClientes;
        private Panel pnlEditar;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private TextBox txtEditarCorreo;
        private Label label6;
        private TextBox txtEditarCedula;
        private Label label3;
        private TextBox txtEditarApellido;
        private Label label2;
        private TextBox txtEditarNombre;
        private Label label1;
        private Label label7;
        private TextBox txtEditarDireccion;
        private Label label8;
        private TextBox txtEditarTelefono;
        private TextBox txtId;
        private Label label10;
        private FontAwesome.Sharp.IconButton btnGuardarCambios;
        private Label label9;
        private BindingSource clienteModelBindingSource;
        private BindingSource clienteViewModelBindingSource;
        private BindingSource clienteModelBindingSource1;
        private DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombresDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Cedula;
        private DataGridViewImageColumn columnEditar;
        private DataGridViewImageColumn columnEliminar;
    }
}