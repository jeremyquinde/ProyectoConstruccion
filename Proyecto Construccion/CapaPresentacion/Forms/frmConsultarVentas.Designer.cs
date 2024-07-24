namespace CapaPresentacion.Forms
{
    partial class frmConsultarVentas
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
            label9 = new Label();
            btnGuardarCambios = new FontAwesome.Sharp.IconButton();
            txtId = new TextBox();
            label10 = new Label();
            label8 = new Label();
            txtEditarPrecioFinal = new TextBox();
            label7 = new Label();
            txtEditarDescuento = new TextBox();
            label6 = new Label();
            txtEditarCantidadProducto = new TextBox();
            label3 = new Label();
            txtEditarIdProducto = new TextBox();
            label2 = new Label();
            txtEditarCedula = new TextBox();
            label1 = new Label();
            ventaViewModelBindingSource2 = new BindingSource(components);
            ventaViewModelBindingSource1 = new BindingSource(components);
            ventaViewModelBindingSource = new BindingSource(components);
            dgvConsultarVentas = new DataGridView();
            idVentaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreClienteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            apellidoClienteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cedulaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idProductoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreProductoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            marcaProductoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            precioProductoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cantidadProductoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descuentoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            precioFinalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            columnEditar = new DataGridViewImageColumn();
            columnEliminar = new DataGridViewImageColumn();
            ventaViewModelBindingSource3 = new BindingSource(components);
            pnlEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ventaViewModelBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ventaViewModelBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ventaViewModelBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvConsultarVentas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ventaViewModelBindingSource3).BeginInit();
            SuspendLayout();
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
            label4.Size = new Size(385, 46);
            label4.TabIndex = 65;
            label4.Text = "VENTAS REGISTRADAS";
            // 
            // pnlEditar
            // 
            pnlEditar.BackColor = Color.FromArgb(62, 49, 147);
            pnlEditar.BorderStyle = BorderStyle.FixedSingle;
            pnlEditar.Controls.Add(label9);
            pnlEditar.Controls.Add(btnGuardarCambios);
            pnlEditar.Controls.Add(txtId);
            pnlEditar.Controls.Add(label10);
            pnlEditar.Controls.Add(label8);
            pnlEditar.Controls.Add(txtEditarPrecioFinal);
            pnlEditar.Controls.Add(label7);
            pnlEditar.Controls.Add(txtEditarDescuento);
            pnlEditar.Controls.Add(label6);
            pnlEditar.Controls.Add(txtEditarCantidadProducto);
            pnlEditar.Controls.Add(label3);
            pnlEditar.Controls.Add(txtEditarIdProducto);
            pnlEditar.Controls.Add(label2);
            pnlEditar.Controls.Add(txtEditarCedula);
            pnlEditar.Controls.Add(label1);
            pnlEditar.Dock = DockStyle.Right;
            pnlEditar.Location = new Point(871, 0);
            pnlEditar.Margin = new Padding(0);
            pnlEditar.Name = "pnlEditar";
            pnlEditar.Size = new Size(316, 861);
            pnlEditar.TabIndex = 64;
            pnlEditar.Visible = false;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.FlatStyle = FlatStyle.Flat;
            label9.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(229, 212, 251);
            label9.Location = new Point(60, 76);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(204, 37);
            label9.TabIndex = 63;
            label9.Text = "EDITAR VENTA";
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.Anchor = AnchorStyles.None;
            btnGuardarCambios.IconChar = FontAwesome.Sharp.IconChar.None;
            btnGuardarCambios.IconColor = Color.Black;
            btnGuardarCambios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardarCambios.Location = new Point(60, 632);
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
            txtId.Location = new Point(38, 172);
            txtId.Margin = new Padding(4);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(255, 29);
            txtId.TabIndex = 85;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.FlatStyle = FlatStyle.Flat;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(229, 212, 251);
            label10.Location = new Point(38, 147);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(83, 21);
            label10.TabIndex = 84;
            label10.Text = "ID VENTA";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.FlatStyle = FlatStyle.Flat;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(229, 212, 251);
            label8.Location = new Point(38, 411);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(104, 21);
            label8.TabIndex = 82;
            label8.Text = "DESCUENTO";
            // 
            // txtEditarPrecioFinal
            // 
            txtEditarPrecioFinal.Anchor = AnchorStyles.None;
            txtEditarPrecioFinal.BackColor = Color.Gainsboro;
            txtEditarPrecioFinal.Location = new Point(38, 500);
            txtEditarPrecioFinal.Margin = new Padding(4);
            txtEditarPrecioFinal.Name = "txtEditarPrecioFinal";
            txtEditarPrecioFinal.Size = new Size(255, 29);
            txtEditarPrecioFinal.TabIndex = 81;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(38, 494);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(0, 25);
            label7.TabIndex = 77;
            // 
            // txtEditarDescuento
            // 
            txtEditarDescuento.Anchor = AnchorStyles.None;
            txtEditarDescuento.BackColor = Color.Gainsboro;
            txtEditarDescuento.Location = new Point(38, 436);
            txtEditarDescuento.Margin = new Padding(4);
            txtEditarDescuento.Name = "txtEditarDescuento";
            txtEditarDescuento.Size = new Size(255, 29);
            txtEditarDescuento.TabIndex = 74;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(229, 212, 251);
            label6.Location = new Point(38, 475);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(115, 21);
            label6.TabIndex = 73;
            label6.Text = "PRECIO FINAL";
            // 
            // txtEditarCantidadProducto
            // 
            txtEditarCantidadProducto.Anchor = AnchorStyles.None;
            txtEditarCantidadProducto.BackColor = Color.Gainsboro;
            txtEditarCantidadProducto.Location = new Point(38, 371);
            txtEditarCantidadProducto.Margin = new Padding(4);
            txtEditarCantidadProducto.Name = "txtEditarCantidadProducto";
            txtEditarCantidadProducto.Size = new Size(255, 29);
            txtEditarCantidadProducto.TabIndex = 70;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(229, 212, 251);
            label3.Location = new Point(38, 346);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(183, 21);
            label3.TabIndex = 69;
            label3.Text = "CANTIDAD PRODUCTO";
            // 
            // txtEditarIdProducto
            // 
            txtEditarIdProducto.Anchor = AnchorStyles.None;
            txtEditarIdProducto.BackColor = Color.Gainsboro;
            txtEditarIdProducto.Location = new Point(38, 307);
            txtEditarIdProducto.Margin = new Padding(4);
            txtEditarIdProducto.Name = "txtEditarIdProducto";
            txtEditarIdProducto.Size = new Size(255, 29);
            txtEditarIdProducto.TabIndex = 66;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(229, 212, 251);
            label2.Location = new Point(38, 281);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(121, 21);
            label2.TabIndex = 65;
            label2.Text = "ID PRODUCTO ";
            // 
            // txtEditarCedula
            // 
            txtEditarCedula.Anchor = AnchorStyles.None;
            txtEditarCedula.BackColor = Color.Gainsboro;
            txtEditarCedula.Location = new Point(38, 241);
            txtEditarCedula.Margin = new Padding(4);
            txtEditarCedula.Name = "txtEditarCedula";
            txtEditarCedula.Size = new Size(255, 29);
            txtEditarCedula.TabIndex = 64;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(229, 212, 251);
            label1.Location = new Point(38, 216);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(139, 21);
            label1.TabIndex = 63;
            label1.Text = "CEDULA CLIENTE";
            // 
            // ventaViewModelBindingSource2
            // 
            ventaViewModelBindingSource2.DataSource = typeof(ViewModels.VentaViewModel);
            // 
            // ventaViewModelBindingSource1
            // 
            ventaViewModelBindingSource1.DataSource = typeof(ViewModels.VentaViewModel);
            // 
            // ventaViewModelBindingSource
            // 
            ventaViewModelBindingSource.DataSource = typeof(ViewModels.VentaViewModel);
            // 
            // dgvConsultarVentas
            // 
            dgvConsultarVentas.AllowUserToAddRows = false;
            dgvConsultarVentas.AllowUserToDeleteRows = false;
            dgvConsultarVentas.AllowUserToResizeColumns = false;
            dgvConsultarVentas.AllowUserToResizeRows = false;
            dgvConsultarVentas.Anchor = AnchorStyles.None;
            dgvConsultarVentas.AutoGenerateColumns = false;
            dgvConsultarVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvConsultarVentas.BackgroundColor = Color.White;
            dgvConsultarVentas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvConsultarVentas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(62, 49, 147);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvConsultarVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvConsultarVentas.ColumnHeadersHeight = 35;
            dgvConsultarVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvConsultarVentas.Columns.AddRange(new DataGridViewColumn[] { idVentaDataGridViewTextBoxColumn, nombreClienteDataGridViewTextBoxColumn, apellidoClienteDataGridViewTextBoxColumn, cedulaDataGridViewTextBoxColumn, idProductoDataGridViewTextBoxColumn, nombreProductoDataGridViewTextBoxColumn, marcaProductoDataGridViewTextBoxColumn, precioProductoDataGridViewTextBoxColumn, cantidadProductoDataGridViewTextBoxColumn, descuentoDataGridViewTextBoxColumn, precioFinalDataGridViewTextBoxColumn, columnEditar, columnEliminar });
            dgvConsultarVentas.DataSource = ventaViewModelBindingSource3;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvConsultarVentas.DefaultCellStyle = dataGridViewCellStyle2;
            dgvConsultarVentas.EnableHeadersVisualStyles = false;
            dgvConsultarVentas.GridColor = Color.FromArgb(233, 233, 233);
            dgvConsultarVentas.Location = new Point(55, 117);
            dgvConsultarVentas.Name = "dgvConsultarVentas";
            dgvConsultarVentas.ReadOnly = true;
            dgvConsultarVentas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Blue;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(0, 0, 192);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvConsultarVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvConsultarVentas.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dgvConsultarVentas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvConsultarVentas.RowTemplate.Height = 25;
            dgvConsultarVentas.Size = new Size(1054, 691);
            dgvConsultarVentas.TabIndex = 66;
            dgvConsultarVentas.CellContentClick += dgvConsultarVentas_CellContentClick;
            // 
            // idVentaDataGridViewTextBoxColumn
            // 
            idVentaDataGridViewTextBoxColumn.DataPropertyName = "IdVenta";
            idVentaDataGridViewTextBoxColumn.HeaderText = "IdVenta";
            idVentaDataGridViewTextBoxColumn.Name = "idVentaDataGridViewTextBoxColumn";
            idVentaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreClienteDataGridViewTextBoxColumn
            // 
            nombreClienteDataGridViewTextBoxColumn.DataPropertyName = "NombreCliente";
            nombreClienteDataGridViewTextBoxColumn.HeaderText = "NombreCliente";
            nombreClienteDataGridViewTextBoxColumn.Name = "nombreClienteDataGridViewTextBoxColumn";
            nombreClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidoClienteDataGridViewTextBoxColumn
            // 
            apellidoClienteDataGridViewTextBoxColumn.DataPropertyName = "ApellidoCliente";
            apellidoClienteDataGridViewTextBoxColumn.HeaderText = "ApellidoCliente";
            apellidoClienteDataGridViewTextBoxColumn.Name = "apellidoClienteDataGridViewTextBoxColumn";
            apellidoClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cedulaDataGridViewTextBoxColumn
            // 
            cedulaDataGridViewTextBoxColumn.DataPropertyName = "Cedula";
            cedulaDataGridViewTextBoxColumn.HeaderText = "Cedula";
            cedulaDataGridViewTextBoxColumn.Name = "cedulaDataGridViewTextBoxColumn";
            cedulaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idProductoDataGridViewTextBoxColumn
            // 
            idProductoDataGridViewTextBoxColumn.DataPropertyName = "IdProducto";
            idProductoDataGridViewTextBoxColumn.HeaderText = "IdProducto";
            idProductoDataGridViewTextBoxColumn.Name = "idProductoDataGridViewTextBoxColumn";
            idProductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreProductoDataGridViewTextBoxColumn
            // 
            nombreProductoDataGridViewTextBoxColumn.DataPropertyName = "NombreProducto";
            nombreProductoDataGridViewTextBoxColumn.HeaderText = "NombreProducto";
            nombreProductoDataGridViewTextBoxColumn.Name = "nombreProductoDataGridViewTextBoxColumn";
            nombreProductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // marcaProductoDataGridViewTextBoxColumn
            // 
            marcaProductoDataGridViewTextBoxColumn.DataPropertyName = "MarcaProducto";
            marcaProductoDataGridViewTextBoxColumn.HeaderText = "MarcaProducto";
            marcaProductoDataGridViewTextBoxColumn.Name = "marcaProductoDataGridViewTextBoxColumn";
            marcaProductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioProductoDataGridViewTextBoxColumn
            // 
            precioProductoDataGridViewTextBoxColumn.DataPropertyName = "PrecioProducto";
            precioProductoDataGridViewTextBoxColumn.HeaderText = "PrecioProducto";
            precioProductoDataGridViewTextBoxColumn.Name = "precioProductoDataGridViewTextBoxColumn";
            precioProductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadProductoDataGridViewTextBoxColumn
            // 
            cantidadProductoDataGridViewTextBoxColumn.DataPropertyName = "CantidadProducto";
            cantidadProductoDataGridViewTextBoxColumn.HeaderText = "CantidadProducto";
            cantidadProductoDataGridViewTextBoxColumn.Name = "cantidadProductoDataGridViewTextBoxColumn";
            cantidadProductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descuentoDataGridViewTextBoxColumn
            // 
            descuentoDataGridViewTextBoxColumn.DataPropertyName = "Descuento";
            descuentoDataGridViewTextBoxColumn.HeaderText = "Descuento";
            descuentoDataGridViewTextBoxColumn.Name = "descuentoDataGridViewTextBoxColumn";
            descuentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioFinalDataGridViewTextBoxColumn
            // 
            precioFinalDataGridViewTextBoxColumn.DataPropertyName = "PrecioFinal";
            precioFinalDataGridViewTextBoxColumn.HeaderText = "PrecioFinal";
            precioFinalDataGridViewTextBoxColumn.Name = "precioFinalDataGridViewTextBoxColumn";
            precioFinalDataGridViewTextBoxColumn.ReadOnly = true;
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
            // ventaViewModelBindingSource3
            // 
            ventaViewModelBindingSource3.DataSource = typeof(ViewModels.VentaViewModel);
            // 
            // frmConsultarVentas
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1187, 861);
            Controls.Add(label4);
            Controls.Add(pnlEditar);
            Controls.Add(dgvConsultarVentas);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "frmConsultarVentas";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmConsultarVentas";
            Load += frmConsultarVentas_Load;
            pnlEditar.ResumeLayout(false);
            pnlEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ventaViewModelBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)ventaViewModelBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ventaViewModelBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvConsultarVentas).EndInit();
            ((System.ComponentModel.ISupportInitialize)ventaViewModelBindingSource3).EndInit();
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
        private Label label8;
        private TextBox txtEditarPrecioFinal;
        private Label label7;
        private TextBox txtEditarDescuento;
        private Label label6;
        private TextBox txtEditarCantidadProducto;
        private Label label3;
        private TextBox txtEditarIdProducto;
        private Label label2;
        private TextBox txtEditarCedula;
        private Label label1;
        private BindingSource ventaViewModelBindingSource;
        private BindingSource ventaViewModelBindingSource1;
        private BindingSource ventaViewModelBindingSource2;
        private DataGridView dgvConsultarVentas;
        private DataGridViewTextBoxColumn idVentaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreClienteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellidoClienteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cedulaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idProductoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreProductoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn marcaProductoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precioProductoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cantidadProductoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descuentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precioFinalDataGridViewTextBoxColumn;
        private DataGridViewImageColumn columnEditar;
        private DataGridViewImageColumn columnEliminar;
        private BindingSource ventaViewModelBindingSource3;
    }
}