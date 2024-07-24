namespace CapaPresentacion.Forms
{
    partial class frmRegistroProducto
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
            btnProductoLimpiar = new FontAwesome.Sharp.IconButton();
            btnProductoGuardar = new FontAwesome.Sharp.IconButton();
            label9 = new Label();
            txtCantidadStock = new TextBox();
            txtPrecioProducto = new TextBox();
            txtCategoriaProducto = new TextBox();
            txtProductoNombre = new TextBox();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            txtMarcaProducto = new TextBox();
            groupBox1 = new GroupBox();
            label12 = new Label();
            groupBox2 = new GroupBox();
            label11 = new Label();
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
            label4.Size = new Size(376, 46);
            label4.TabIndex = 48;
            label4.Text = "REGISTRO PRODUCTO";
            // 
            // btnProductoLimpiar
            // 
            btnProductoLimpiar.Anchor = AnchorStyles.None;
            btnProductoLimpiar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnProductoLimpiar.IconColor = Color.Black;
            btnProductoLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProductoLimpiar.Location = new Point(635, 698);
            btnProductoLimpiar.Name = "btnProductoLimpiar";
            btnProductoLimpiar.Size = new Size(204, 38);
            btnProductoLimpiar.TabIndex = 47;
            btnProductoLimpiar.Text = "LIMPIAR";
            btnProductoLimpiar.UseVisualStyleBackColor = true;
            btnProductoLimpiar.Click += btnProductoLimpiar_Click;
            // 
            // btnProductoGuardar
            // 
            btnProductoGuardar.Anchor = AnchorStyles.None;
            btnProductoGuardar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnProductoGuardar.IconColor = Color.Black;
            btnProductoGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProductoGuardar.Location = new Point(330, 698);
            btnProductoGuardar.Name = "btnProductoGuardar";
            btnProductoGuardar.Size = new Size(204, 38);
            btnProductoGuardar.TabIndex = 46;
            btnProductoGuardar.Text = "REGISTRAR";
            btnProductoGuardar.UseVisualStyleBackColor = true;
            btnProductoGuardar.Click += btnProductoGuardar_Click;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.FlatStyle = FlatStyle.Flat;
            label9.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(169, 519);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(174, 25);
            label9.TabIndex = 45;
            label9.Text = "CANTIDAD STOCK";
            // 
            // txtCantidadStock
            // 
            txtCantidadStock.Anchor = AnchorStyles.None;
            txtCantidadStock.BackColor = Color.Gainsboro;
            txtCantidadStock.Location = new Point(169, 548);
            txtCantidadStock.Margin = new Padding(4);
            txtCantidadStock.Name = "txtCantidadStock";
            txtCantidadStock.Size = new Size(365, 29);
            txtCantidadStock.TabIndex = 44;
            // 
            // txtPrecioProducto
            // 
            txtPrecioProducto.Anchor = AnchorStyles.None;
            txtPrecioProducto.BackColor = Color.Gainsboro;
            txtPrecioProducto.Location = new Point(635, 548);
            txtPrecioProducto.Margin = new Padding(4);
            txtPrecioProducto.Name = "txtPrecioProducto";
            txtPrecioProducto.Size = new Size(365, 29);
            txtPrecioProducto.TabIndex = 43;
            // 
            // txtCategoriaProducto
            // 
            txtCategoriaProducto.Anchor = AnchorStyles.None;
            txtCategoriaProducto.BackColor = Color.Gainsboro;
            txtCategoriaProducto.Location = new Point(586, 83);
            txtCategoriaProducto.Margin = new Padding(4);
            txtCategoriaProducto.Name = "txtCategoriaProducto";
            txtCategoriaProducto.Size = new Size(365, 29);
            txtCategoriaProducto.TabIndex = 41;
            // 
            // txtProductoNombre
            // 
            txtProductoNombre.Anchor = AnchorStyles.None;
            txtProductoNombre.BackColor = Color.Gainsboro;
            txtProductoNombre.Location = new Point(122, 83);
            txtProductoNombre.Margin = new Padding(4);
            txtProductoNombre.Name = "txtProductoNombre";
            txtProductoNombre.Size = new Size(365, 29);
            txtProductoNombre.TabIndex = 40;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(635, 519);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(78, 25);
            label5.TabIndex = 35;
            label5.Text = "PRECIO";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(586, 54);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(116, 25);
            label2.TabIndex = 33;
            label2.Text = "CATEGORIA";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(122, 54);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(93, 25);
            label1.TabIndex = 32;
            label1.Text = "NOMBRE";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(120, 129);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(80, 25);
            label3.TabIndex = 34;
            label3.Text = "MARCA";
            // 
            // txtMarcaProducto
            // 
            txtMarcaProducto.Anchor = AnchorStyles.None;
            txtMarcaProducto.BackColor = Color.Gainsboro;
            txtMarcaProducto.Location = new Point(122, 158);
            txtMarcaProducto.Margin = new Padding(4);
            txtMarcaProducto.Name = "txtMarcaProducto";
            txtMarcaProducto.Size = new Size(366, 29);
            txtMarcaProducto.TabIndex = 39;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtMarcaProducto);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtProductoNombre);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtCategoriaProducto);
            groupBox1.Location = new Point(49, 147);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1081, 264);
            groupBox1.TabIndex = 49;
            groupBox1.TabStop = false;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.FlatStyle = FlatStyle.Flat;
            label12.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(41, -10);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(258, 37);
            label12.TabIndex = 37;
            label12.Text = "DATOS PRODUCTO";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label11);
            groupBox2.Location = new Point(49, 441);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1081, 223);
            groupBox2.TabIndex = 50;
            groupBox2.TabStop = false;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.FlatStyle = FlatStyle.Flat;
            label11.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(41, -7);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(274, 37);
            label11.TabIndex = 36;
            label11.Text = "DATOS INVENTARIO";
            // 
            // frmRegistroProducto
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1187, 861);
            Controls.Add(label4);
            Controls.Add(btnProductoLimpiar);
            Controls.Add(btnProductoGuardar);
            Controls.Add(label9);
            Controls.Add(txtCantidadStock);
            Controls.Add(txtPrecioProducto);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "frmRegistroProducto";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmRegistroProducto";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private FontAwesome.Sharp.IconButton btnProductoLimpiar;
        private FontAwesome.Sharp.IconButton btnProductoGuardar;
        private Label label9;
        private TextBox txtCantidadStock;
        private TextBox txtPrecioProducto;
        private TextBox txtCategoriaProducto;
        private TextBox txtProductoNombre;
        private Label label5;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox txtMarcaProducto;
        private GroupBox groupBox1;
        private Label label12;
        private GroupBox groupBox2;
        private Label label11;
    }
}