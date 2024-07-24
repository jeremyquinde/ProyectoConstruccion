namespace CapaPresentacion.Forms
{
    partial class frmRegistrarVenta
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
            label4 = new Label();
            btnVentaLimpiar = new FontAwesome.Sharp.IconButton();
            btnVentaGuardar = new FontAwesome.Sharp.IconButton();
            groupBox3 = new GroupBox();
            txtDescuento = new TextBox();
            txtPrecioFinal = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label10 = new Label();
            txtCantidadProducto = new TextBox();
            label13 = new Label();
            comboBoxCedula = new ComboBox();
            groupBox1 = new GroupBox();
            txtClienteApellido = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            txtClienteNombre = new TextBox();
            label12 = new Label();
            groupBox2 = new GroupBox();
            comboBoxIdProducto = new ComboBox();
            label14 = new Label();
            label5 = new Label();
            txtProductoPrecio = new TextBox();
            label11 = new Label();
            label9 = new Label();
            txtProductoNombre = new TextBox();
            txtProductoMarca = new TextBox();
            label6 = new Label();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(424, 54);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(353, 46);
            label4.TabIndex = 48;
            label4.Text = "REGISTRO DE VENTA";
            // 
            // btnVentaLimpiar
            // 
            btnVentaLimpiar.Anchor = AnchorStyles.None;
            btnVentaLimpiar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnVentaLimpiar.IconColor = Color.Black;
            btnVentaLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVentaLimpiar.Location = new Point(634, 742);
            btnVentaLimpiar.Name = "btnVentaLimpiar";
            btnVentaLimpiar.Size = new Size(204, 38);
            btnVentaLimpiar.TabIndex = 47;
            btnVentaLimpiar.Text = "LIMPIAR";
            btnVentaLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnVentaGuardar
            // 
            btnVentaGuardar.Anchor = AnchorStyles.None;
            btnVentaGuardar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnVentaGuardar.IconColor = Color.Black;
            btnVentaGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVentaGuardar.Location = new Point(329, 742);
            btnVentaGuardar.Name = "btnVentaGuardar";
            btnVentaGuardar.Size = new Size(204, 38);
            btnVentaGuardar.TabIndex = 46;
            btnVentaGuardar.Text = "REGISTRAR";
            btnVentaGuardar.UseVisualStyleBackColor = true;
            btnVentaGuardar.Click += btnVentaGuardar_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtDescuento);
            groupBox3.Controls.Add(txtPrecioFinal);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(txtCantidadProducto);
            groupBox3.Controls.Add(label13);
            groupBox3.Location = new Point(810, 145);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(350, 557);
            groupBox3.TabIndex = 54;
            groupBox3.TabStop = false;
            // 
            // txtDescuento
            // 
            txtDescuento.Anchor = AnchorStyles.None;
            txtDescuento.BackColor = Color.Gainsboro;
            txtDescuento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescuento.Location = new Point(44, 256);
            txtDescuento.Margin = new Padding(4);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(257, 29);
            txtDescuento.TabIndex = 55;
            // 
            // txtPrecioFinal
            // 
            txtPrecioFinal.Anchor = AnchorStyles.None;
            txtPrecioFinal.BackColor = Color.Gainsboro;
            txtPrecioFinal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecioFinal.Location = new Point(44, 347);
            txtPrecioFinal.Margin = new Padding(4);
            txtPrecioFinal.Name = "txtPrecioFinal";
            txtPrecioFinal.Size = new Size(257, 29);
            txtPrecioFinal.TabIndex = 54;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(44, 227);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(122, 25);
            label7.TabIndex = 35;
            label7.Text = "DESCUENTO";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.FlatStyle = FlatStyle.Flat;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(69, 54);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(213, 32);
            label8.TabIndex = 36;
            label8.Text = "DATOS DE VENTA";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.FlatStyle = FlatStyle.Flat;
            label10.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(44, 136);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(217, 25);
            label10.TabIndex = 45;
            label10.Text = "CANTIDAD PRODUCTO";
            // 
            // txtCantidadProducto
            // 
            txtCantidadProducto.Anchor = AnchorStyles.None;
            txtCantidadProducto.BackColor = Color.Gainsboro;
            txtCantidadProducto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCantidadProducto.Location = new Point(46, 168);
            txtCantidadProducto.Margin = new Padding(4);
            txtCantidadProducto.Name = "txtCantidadProducto";
            txtCantidadProducto.Size = new Size(257, 29);
            txtCantidadProducto.TabIndex = 38;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.None;
            label13.AutoSize = true;
            label13.FlatStyle = FlatStyle.Flat;
            label13.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(46, 316);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(137, 25);
            label13.TabIndex = 42;
            label13.Text = "PRECIO FINAL";
            // 
            // comboBoxCedula
            // 
            comboBoxCedula.BackColor = Color.Gainsboro;
            comboBoxCedula.Cursor = Cursors.Hand;
            comboBoxCedula.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxCedula.FormattingEnabled = true;
            comboBoxCedula.Location = new Point(48, 168);
            comboBoxCedula.Name = "comboBoxCedula";
            comboBoxCedula.Size = new Size(257, 29);
            comboBoxCedula.TabIndex = 53;
            comboBoxCedula.SelectedIndexChanged += comboBoxCedula_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtClienteApellido);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(comboBoxCedula);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtClienteNombre);
            groupBox1.Controls.Add(label12);
            groupBox1.Location = new Point(28, 145);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(350, 557);
            groupBox1.TabIndex = 52;
            groupBox1.TabStop = false;
            // 
            // txtClienteApellido
            // 
            txtClienteApellido.Anchor = AnchorStyles.None;
            txtClienteApellido.BackColor = Color.Gainsboro;
            txtClienteApellido.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtClienteApellido.Location = new Point(47, 347);
            txtClienteApellido.Margin = new Padding(4);
            txtClienteApellido.Name = "txtClienteApellido";
            txtClienteApellido.Size = new Size(258, 29);
            txtClienteApellido.TabIndex = 41;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(47, 316);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(112, 25);
            label2.TabIndex = 33;
            label2.Text = "APELLIDOS";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(47, 227);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(104, 25);
            label1.TabIndex = 32;
            label1.Text = "NOMBRES";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(48, 137);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(85, 25);
            label3.TabIndex = 34;
            label3.Text = "CEDULA";
            // 
            // txtClienteNombre
            // 
            txtClienteNombre.Anchor = AnchorStyles.None;
            txtClienteNombre.BackColor = Color.Gainsboro;
            txtClienteNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtClienteNombre.Location = new Point(47, 256);
            txtClienteNombre.Margin = new Padding(4);
            txtClienteNombre.Name = "txtClienteNombre";
            txtClienteNombre.Size = new Size(257, 29);
            txtClienteNombre.TabIndex = 40;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.FlatStyle = FlatStyle.Flat;
            label12.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(63, 54);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(230, 32);
            label12.TabIndex = 37;
            label12.Text = "DATOS DE CLIENTE";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBoxIdProducto);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtProductoPrecio);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtProductoNombre);
            groupBox2.Controls.Add(txtProductoMarca);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(424, 145);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(350, 557);
            groupBox2.TabIndex = 53;
            groupBox2.TabStop = false;
            // 
            // comboBoxIdProducto
            // 
            comboBoxIdProducto.BackColor = Color.Gainsboro;
            comboBoxIdProducto.Cursor = Cursors.Hand;
            comboBoxIdProducto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxIdProducto.FormattingEnabled = true;
            comboBoxIdProducto.Location = new Point(50, 168);
            comboBoxIdProducto.Name = "comboBoxIdProducto";
            comboBoxIdProducto.Size = new Size(257, 29);
            comboBoxIdProducto.TabIndex = 54;
            comboBoxIdProducto.SelectedIndexChanged += comboBoxIdProducto_SelectedIndexChanged;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.None;
            label14.AutoSize = true;
            label14.FlatStyle = FlatStyle.Flat;
            label14.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(48, 136);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(139, 25);
            label14.TabIndex = 47;
            label14.Text = "ID PRODUCTO";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(46, 404);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(78, 25);
            label5.TabIndex = 35;
            label5.Text = "PRECIO";
            // 
            // txtProductoPrecio
            // 
            txtProductoPrecio.Anchor = AnchorStyles.None;
            txtProductoPrecio.BackColor = Color.Gainsboro;
            txtProductoPrecio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtProductoPrecio.Location = new Point(47, 435);
            txtProductoPrecio.Margin = new Padding(4);
            txtProductoPrecio.Name = "txtProductoPrecio";
            txtProductoPrecio.Size = new Size(259, 29);
            txtProductoPrecio.TabIndex = 43;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.FlatStyle = FlatStyle.Flat;
            label11.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(41, 54);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(266, 32);
            label11.TabIndex = 36;
            label11.Text = "DATOS DE PRODUCTO";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.FlatStyle = FlatStyle.Flat;
            label9.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(47, 227);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(93, 25);
            label9.TabIndex = 45;
            label9.Text = "NOMBRE";
            // 
            // txtProductoNombre
            // 
            txtProductoNombre.Anchor = AnchorStyles.None;
            txtProductoNombre.BackColor = Color.Gainsboro;
            txtProductoNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtProductoNombre.Location = new Point(46, 256);
            txtProductoNombre.Margin = new Padding(4);
            txtProductoNombre.Name = "txtProductoNombre";
            txtProductoNombre.Size = new Size(259, 29);
            txtProductoNombre.TabIndex = 44;
            // 
            // txtProductoMarca
            // 
            txtProductoMarca.Anchor = AnchorStyles.None;
            txtProductoMarca.BackColor = Color.Gainsboro;
            txtProductoMarca.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtProductoMarca.Location = new Point(46, 347);
            txtProductoMarca.Margin = new Padding(4);
            txtProductoMarca.Name = "txtProductoMarca";
            txtProductoMarca.Size = new Size(259, 29);
            txtProductoMarca.TabIndex = 38;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(45, 316);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(80, 25);
            label6.TabIndex = 42;
            label6.Text = "MARCA";
            // 
            // frmRegistrarVenta
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1187, 861);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(label4);
            Controls.Add(btnVentaLimpiar);
            Controls.Add(btnVentaGuardar);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "frmRegistrarVenta";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmRegistrarVenta";
            Load += frmRegistrarVenta_Load;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private FontAwesome.Sharp.IconButton btnVentaLimpiar;
        private FontAwesome.Sharp.IconButton btnVentaGuardar;
        private GroupBox groupBox3;
        private ComboBox comboBoxCedula;
        private Label label7;
        private Label label8;
        private Label label10;
        private TextBox txtCantidadProducto;
        private Label label13;
        private GroupBox groupBox1;
        private TextBox txtClienteApellido;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox txtClienteNombre;
        private Label label12;
        private GroupBox groupBox2;
        private Label label5;
        private TextBox txtProductoPrecio;
        private Label label11;
        private Label label9;
        private TextBox txtProductoNombre;
        private TextBox txtProductoMarca;
        private Label label6;
        private Label label14;
        private TextBox txtDescuento;
        private TextBox txtPrecioFinal;
        private ComboBox comboBoxIdProducto;
    }
}