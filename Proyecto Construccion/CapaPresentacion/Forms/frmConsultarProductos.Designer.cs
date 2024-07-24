namespace CapaPresentacion.Forms
{
    partial class frmConsultarProductos
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
            txtEditarPrecio = new TextBox();
            label7 = new Label();
            txtEditarCantidadStock = new TextBox();
            label6 = new Label();
            txtEditarMarca = new TextBox();
            label3 = new Label();
            txtEditarCategoria = new TextBox();
            label2 = new Label();
            txtEditarNombre = new TextBox();
            label1 = new Label();
            dgvConsultarProductos = new DataGridView();
            idProductoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoriaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            marcaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cantidadStockDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            precioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            columnEditar = new DataGridViewImageColumn();
            columnEliminar = new DataGridViewImageColumn();
            productoViewModelBindingSource = new BindingSource(components);
            ventaViewModelBindingSource = new BindingSource(components);
            clienteViewModelBindingSource = new BindingSource(components);
            usuarioViewModelBindingSource = new BindingSource(components);
            pnlEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsultarProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productoViewModelBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ventaViewModelBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clienteViewModelBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usuarioViewModelBindingSource).BeginInit();
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
            label4.Size = new Size(440, 46);
            label4.TabIndex = 65;
            label4.Text = "INVENTARIO PRODUCTOS";
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
            pnlEditar.Controls.Add(txtEditarPrecio);
            pnlEditar.Controls.Add(label7);
            pnlEditar.Controls.Add(txtEditarCantidadStock);
            pnlEditar.Controls.Add(label6);
            pnlEditar.Controls.Add(txtEditarMarca);
            pnlEditar.Controls.Add(label3);
            pnlEditar.Controls.Add(txtEditarCategoria);
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
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.FlatStyle = FlatStyle.Flat;
            label9.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(229, 212, 251);
            label9.Location = new Point(28, 76);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(265, 37);
            label9.TabIndex = 63;
            label9.Text = "EDITAR PRODUCTO";
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.Anchor = AnchorStyles.None;
            btnGuardarCambios.IconChar = FontAwesome.Sharp.IconChar.None;
            btnGuardarCambios.IconColor = Color.Black;
            btnGuardarCambios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardarCambios.Location = new Point(52, 591);
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
            txtId.Location = new Point(30, 172);
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
            label10.Location = new Point(30, 151);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(27, 21);
            label10.TabIndex = 84;
            label10.Text = "ID";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.FlatStyle = FlatStyle.Flat;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(229, 212, 251);
            label8.Location = new Point(30, 411);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(146, 21);
            label8.TabIndex = 82;
            label8.Text = "CANTIDAD STOCK";
            // 
            // txtEditarPrecio
            // 
            txtEditarPrecio.Anchor = AnchorStyles.None;
            txtEditarPrecio.BackColor = Color.Gainsboro;
            txtEditarPrecio.Location = new Point(30, 500);
            txtEditarPrecio.Margin = new Padding(4);
            txtEditarPrecio.Name = "txtEditarPrecio";
            txtEditarPrecio.Size = new Size(255, 23);
            txtEditarPrecio.TabIndex = 81;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(30, 418);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(0, 25);
            label7.TabIndex = 77;
            // 
            // txtEditarCantidadStock
            // 
            txtEditarCantidadStock.Anchor = AnchorStyles.None;
            txtEditarCantidadStock.BackColor = Color.Gainsboro;
            txtEditarCantidadStock.Location = new Point(30, 436);
            txtEditarCantidadStock.Margin = new Padding(4);
            txtEditarCantidadStock.Name = "txtEditarCantidadStock";
            txtEditarCantidadStock.Size = new Size(255, 23);
            txtEditarCantidadStock.TabIndex = 74;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(229, 212, 251);
            label6.Location = new Point(30, 479);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(66, 21);
            label6.TabIndex = 73;
            label6.Text = "PRECIO";
            // 
            // txtEditarMarca
            // 
            txtEditarMarca.Anchor = AnchorStyles.None;
            txtEditarMarca.BackColor = Color.Gainsboro;
            txtEditarMarca.Location = new Point(30, 371);
            txtEditarMarca.Margin = new Padding(4);
            txtEditarMarca.Name = "txtEditarMarca";
            txtEditarMarca.Size = new Size(255, 23);
            txtEditarMarca.TabIndex = 70;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(229, 212, 251);
            label3.Location = new Point(30, 350);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(67, 21);
            label3.TabIndex = 69;
            label3.Text = "MARCA";
            // 
            // txtEditarCategoria
            // 
            txtEditarCategoria.Anchor = AnchorStyles.None;
            txtEditarCategoria.BackColor = Color.Gainsboro;
            txtEditarCategoria.Location = new Point(30, 307);
            txtEditarCategoria.Margin = new Padding(4);
            txtEditarCategoria.Name = "txtEditarCategoria";
            txtEditarCategoria.Size = new Size(255, 23);
            txtEditarCategoria.TabIndex = 66;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(229, 212, 251);
            label2.Location = new Point(30, 285);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(97, 21);
            label2.TabIndex = 65;
            label2.Text = "CATEGORIA";
            // 
            // txtEditarNombre
            // 
            txtEditarNombre.Anchor = AnchorStyles.None;
            txtEditarNombre.BackColor = Color.Gainsboro;
            txtEditarNombre.Location = new Point(30, 241);
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
            label1.Location = new Point(30, 220);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(79, 21);
            label1.TabIndex = 63;
            label1.Text = "NOMBRE";
            // 
            // dgvConsultarProductos
            // 
            dgvConsultarProductos.AllowUserToAddRows = false;
            dgvConsultarProductos.AllowUserToDeleteRows = false;
            dgvConsultarProductos.AllowUserToResizeColumns = false;
            dgvConsultarProductos.AllowUserToResizeRows = false;
            dgvConsultarProductos.Anchor = AnchorStyles.None;
            dgvConsultarProductos.AutoGenerateColumns = false;
            dgvConsultarProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvConsultarProductos.BackgroundColor = Color.White;
            dgvConsultarProductos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvConsultarProductos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(62, 49, 147);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvConsultarProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvConsultarProductos.ColumnHeadersHeight = 35;
            dgvConsultarProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvConsultarProductos.Columns.AddRange(new DataGridViewColumn[] { idProductoDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, categoriaDataGridViewTextBoxColumn, marcaDataGridViewTextBoxColumn, cantidadStockDataGridViewTextBoxColumn, precioDataGridViewTextBoxColumn, columnEditar, columnEliminar });
            dgvConsultarProductos.DataSource = productoViewModelBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvConsultarProductos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvConsultarProductos.EnableHeadersVisualStyles = false;
            dgvConsultarProductos.GridColor = Color.FromArgb(233, 233, 233);
            dgvConsultarProductos.Location = new Point(55, 117);
            dgvConsultarProductos.Name = "dgvConsultarProductos";
            dgvConsultarProductos.ReadOnly = true;
            dgvConsultarProductos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Blue;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(0, 0, 192);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvConsultarProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvConsultarProductos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dgvConsultarProductos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvConsultarProductos.RowTemplate.Height = 25;
            dgvConsultarProductos.Size = new Size(1054, 691);
            dgvConsultarProductos.TabIndex = 63;
            dgvConsultarProductos.CellContentClick += dgvConsultarProductos_CellContentClick;
            // 
            // idProductoDataGridViewTextBoxColumn
            // 
            idProductoDataGridViewTextBoxColumn.DataPropertyName = "IdProducto";
            idProductoDataGridViewTextBoxColumn.HeaderText = "IdProducto";
            idProductoDataGridViewTextBoxColumn.Name = "idProductoDataGridViewTextBoxColumn";
            idProductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            categoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria";
            categoriaDataGridViewTextBoxColumn.HeaderText = "Categoria";
            categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            categoriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            marcaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadStockDataGridViewTextBoxColumn
            // 
            cantidadStockDataGridViewTextBoxColumn.DataPropertyName = "CantidadStock";
            cantidadStockDataGridViewTextBoxColumn.HeaderText = "CantidadStock";
            cantidadStockDataGridViewTextBoxColumn.Name = "cantidadStockDataGridViewTextBoxColumn";
            cantidadStockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            precioDataGridViewTextBoxColumn.ReadOnly = true;
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
            // productoViewModelBindingSource
            // 
            productoViewModelBindingSource.DataSource = typeof(ViewModels.ProductoViewModel);
            // 
            // ventaViewModelBindingSource
            // 
            ventaViewModelBindingSource.DataSource = typeof(ViewModels.VentaViewModel);
            // 
            // clienteViewModelBindingSource
            // 
            clienteViewModelBindingSource.DataSource = typeof(ViewModels.ClienteViewModel);
            // 
            // usuarioViewModelBindingSource
            // 
            usuarioViewModelBindingSource.DataSource = typeof(ViewModels.UsuarioViewModel);
            // 
            // frmConsultarProductos
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1187, 861);
            Controls.Add(pnlEditar);
            Controls.Add(dgvConsultarProductos);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmConsultarProductos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmConsultarProductos";
            Load += frmConsultarProductos_Load;
            pnlEditar.ResumeLayout(false);
            pnlEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsultarProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)productoViewModelBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)ventaViewModelBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)clienteViewModelBindingSource).EndInit();
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
        private Label label8;
        private TextBox txtEditarPrecio;
        private Label label7;
        private TextBox txtEditarCantidadStock;
        private Label label6;
        private TextBox txtEditarMarca;
        private Label label3;
        private TextBox txtEditarCategoria;
        private Label label2;
        private TextBox txtEditarNombre;
        private Label label1;
        private DataGridView dgvConsultarProductos;
        private BindingSource ventaViewModelBindingSource;
        private BindingSource clienteViewModelBindingSource;
        private BindingSource usuarioViewModelBindingSource;
        private BindingSource productoViewModelBindingSource;
        private DataGridViewTextBoxColumn idProductoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cantidadStockDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private DataGridViewImageColumn columnEditar;
        private DataGridViewImageColumn columnEliminar;
    }
}