namespace CapaPresentacion.Forms
{
    partial class frmRegistroUsuario
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
            btnUsuarioLimpiar = new FontAwesome.Sharp.IconButton();
            btnUsuarioGuardar = new FontAwesome.Sharp.IconButton();
            label9 = new Label();
            txtUsuarioTelefono = new TextBox();
            txtUsuarioDireccion = new TextBox();
            label6 = new Label();
            txtUsuarioApellido = new TextBox();
            txtUsuarioNombre = new TextBox();
            txtUsuarioCedula = new TextBox();
            txtUsuarioCorreo = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            fechaRegistroUsuario = new DateTimePicker();
            selectRol = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            label10 = new Label();
            txtUsuarioContraseña = new TextBox();
            label13 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(421, 54);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(413, 46);
            label4.TabIndex = 48;
            label4.Text = "REGISTRO DE USUARIOS";
            // 
            // btnUsuarioLimpiar
            // 
            btnUsuarioLimpiar.Anchor = AnchorStyles.None;
            btnUsuarioLimpiar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnUsuarioLimpiar.IconColor = Color.Black;
            btnUsuarioLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUsuarioLimpiar.Location = new Point(630, 739);
            btnUsuarioLimpiar.Name = "btnUsuarioLimpiar";
            btnUsuarioLimpiar.Size = new Size(204, 38);
            btnUsuarioLimpiar.TabIndex = 47;
            btnUsuarioLimpiar.Text = "LIMPIAR";
            btnUsuarioLimpiar.UseVisualStyleBackColor = true;
            btnUsuarioLimpiar.Click += btnUsuarioLimpiar_Click;
            // 
            // btnUsuarioGuardar
            // 
            btnUsuarioGuardar.Anchor = AnchorStyles.None;
            btnUsuarioGuardar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnUsuarioGuardar.IconColor = Color.Black;
            btnUsuarioGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUsuarioGuardar.Location = new Point(325, 739);
            btnUsuarioGuardar.Name = "btnUsuarioGuardar";
            btnUsuarioGuardar.Size = new Size(204, 38);
            btnUsuarioGuardar.TabIndex = 46;
            btnUsuarioGuardar.Text = "REGISTRAR";
            btnUsuarioGuardar.UseVisualStyleBackColor = true;
            btnUsuarioGuardar.Click += btnUsuarioGuardar_Click;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.FlatStyle = FlatStyle.Flat;
            label9.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(45, 137);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(106, 25);
            label9.TabIndex = 45;
            label9.Text = "TELEFONO";
            // 
            // txtUsuarioTelefono
            // 
            txtUsuarioTelefono.Anchor = AnchorStyles.None;
            txtUsuarioTelefono.BackColor = Color.Gainsboro;
            txtUsuarioTelefono.Location = new Point(46, 168);
            txtUsuarioTelefono.Margin = new Padding(4);
            txtUsuarioTelefono.Name = "txtUsuarioTelefono";
            txtUsuarioTelefono.Size = new Size(259, 29);
            txtUsuarioTelefono.TabIndex = 44;
            // 
            // txtUsuarioDireccion
            // 
            txtUsuarioDireccion.Anchor = AnchorStyles.None;
            txtUsuarioDireccion.BackColor = Color.Gainsboro;
            txtUsuarioDireccion.Location = new Point(46, 355);
            txtUsuarioDireccion.Margin = new Padding(4);
            txtUsuarioDireccion.Name = "txtUsuarioDireccion";
            txtUsuarioDireccion.Size = new Size(259, 29);
            txtUsuarioDireccion.TabIndex = 43;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(45, 227);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(86, 25);
            label6.TabIndex = 42;
            label6.Text = "CORREO";
            // 
            // txtUsuarioApellido
            // 
            txtUsuarioApellido.Anchor = AnchorStyles.None;
            txtUsuarioApellido.BackColor = Color.Gainsboro;
            txtUsuarioApellido.Location = new Point(46, 256);
            txtUsuarioApellido.Margin = new Padding(4);
            txtUsuarioApellido.Name = "txtUsuarioApellido";
            txtUsuarioApellido.Size = new Size(258, 29);
            txtUsuarioApellido.TabIndex = 41;
            // 
            // txtUsuarioNombre
            // 
            txtUsuarioNombre.Anchor = AnchorStyles.None;
            txtUsuarioNombre.BackColor = Color.Gainsboro;
            txtUsuarioNombre.Location = new Point(46, 168);
            txtUsuarioNombre.Margin = new Padding(4);
            txtUsuarioNombre.Name = "txtUsuarioNombre";
            txtUsuarioNombre.Size = new Size(257, 29);
            txtUsuarioNombre.TabIndex = 40;
            // 
            // txtUsuarioCedula
            // 
            txtUsuarioCedula.Anchor = AnchorStyles.None;
            txtUsuarioCedula.BackColor = Color.Gainsboro;
            txtUsuarioCedula.Location = new Point(45, 355);
            txtUsuarioCedula.Margin = new Padding(4);
            txtUsuarioCedula.Name = "txtUsuarioCedula";
            txtUsuarioCedula.Size = new Size(258, 29);
            txtUsuarioCedula.TabIndex = 39;
            // 
            // txtUsuarioCorreo
            // 
            txtUsuarioCorreo.Anchor = AnchorStyles.None;
            txtUsuarioCorreo.BackColor = Color.Gainsboro;
            txtUsuarioCorreo.Location = new Point(45, 256);
            txtUsuarioCorreo.Margin = new Padding(4);
            txtUsuarioCorreo.Name = "txtUsuarioCorreo";
            txtUsuarioCorreo.Size = new Size(259, 29);
            txtUsuarioCorreo.TabIndex = 38;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.FlatStyle = FlatStyle.Flat;
            label12.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(55, 64);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(241, 32);
            label12.TabIndex = 37;
            label12.Text = "DATOS DE USUARIO";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.FlatStyle = FlatStyle.Flat;
            label11.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(44, 64);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(263, 32);
            label11.TabIndex = 36;
            label11.Text = "DATOS DE CONTACTO";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(46, 326);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(112, 25);
            label5.TabIndex = 35;
            label5.Text = "DIRECCION";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(46, 326);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(85, 25);
            label3.TabIndex = 34;
            label3.Text = "CEDULA";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(46, 227);
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
            label1.Location = new Point(48, 137);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(104, 25);
            label1.TabIndex = 32;
            label1.Text = "NOMBRES";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtUsuarioApellido);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtUsuarioCedula);
            groupBox1.Controls.Add(txtUsuarioNombre);
            groupBox1.Controls.Add(label12);
            groupBox1.Location = new Point(28, 145);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(350, 557);
            groupBox1.TabIndex = 49;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtUsuarioDireccion);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtUsuarioTelefono);
            groupBox2.Controls.Add(txtUsuarioCorreo);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(424, 145);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(350, 557);
            groupBox2.TabIndex = 50;
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(fechaRegistroUsuario);
            groupBox3.Controls.Add(selectRol);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(txtUsuarioContraseña);
            groupBox3.Controls.Add(label13);
            groupBox3.Location = new Point(810, 145);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(350, 557);
            groupBox3.TabIndex = 51;
            groupBox3.TabStop = false;
            // 
            // fechaRegistroUsuario
            // 
            fechaRegistroUsuario.CalendarMonthBackground = Color.Gainsboro;
            fechaRegistroUsuario.CustomFormat = "           dd/MM/yyyy    HH:mm";
            fechaRegistroUsuario.Enabled = false;
            fechaRegistroUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            fechaRegistroUsuario.Format = DateTimePickerFormat.Custom;
            fechaRegistroUsuario.Location = new Point(46, 168);
            fechaRegistroUsuario.Name = "fechaRegistroUsuario";
            fechaRegistroUsuario.Size = new Size(258, 29);
            fechaRegistroUsuario.TabIndex = 52;
            // 
            // selectRol
            // 
            selectRol.BackColor = Color.Gainsboro;
            selectRol.Cursor = Cursors.Hand;
            selectRol.FormattingEnabled = true;
            selectRol.Location = new Point(48, 355);
            selectRol.Name = "selectRol";
            selectRol.Size = new Size(257, 29);
            selectRol.TabIndex = 53;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(48, 227);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(138, 25);
            label7.TabIndex = 35;
            label7.Text = "CONTRASEÑA";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.FlatStyle = FlatStyle.Flat;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(78, 63);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(195, 32);
            label8.TabIndex = 36;
            label8.Text = "DATOS DE USER";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.FlatStyle = FlatStyle.Flat;
            label10.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(47, 137);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(196, 25);
            label10.TabIndex = 45;
            label10.Text = "FECHA DE REGISTRO";
            // 
            // txtUsuarioContraseña
            // 
            txtUsuarioContraseña.Anchor = AnchorStyles.None;
            txtUsuarioContraseña.BackColor = Color.Gainsboro;
            txtUsuarioContraseña.Location = new Point(48, 256);
            txtUsuarioContraseña.Margin = new Padding(4);
            txtUsuarioContraseña.Name = "txtUsuarioContraseña";
            txtUsuarioContraseña.Size = new Size(257, 29);
            txtUsuarioContraseña.TabIndex = 38;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.None;
            label13.AutoSize = true;
            label13.FlatStyle = FlatStyle.Flat;
            label13.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(46, 322);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(48, 25);
            label13.TabIndex = 42;
            label13.Text = "ROL";
            // 
            // frmRegistroUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1187, 861);
            Controls.Add(groupBox3);
            Controls.Add(label4);
            Controls.Add(btnUsuarioLimpiar);
            Controls.Add(btnUsuarioGuardar);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "frmRegistroUsuario";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmRegistrarUsuario";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private FontAwesome.Sharp.IconButton btnUsuarioLimpiar;
        private FontAwesome.Sharp.IconButton btnUsuarioGuardar;
        private Label label9;
        private TextBox txtUsuarioTelefono;
        private TextBox txtUsuarioDireccion;
        private Label label6;
        private TextBox txtUsuarioApellido;
        private TextBox txtUsuarioNombre;
        private TextBox txtUsuarioCedula;
        private TextBox txtUsuarioCorreo;
        private Label label12;
        private Label label11;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label7;
        private TextBox textBox1;
        private Label label8;
        private Label label10;
        private TextBox textBox2;
        private TextBox txtUsuarioContraseña;
        private Label label13;
        private DateTimePicker dateTimePicker1;
        private ComboBox selectRol;
        private DateTimePicker fechaRegistroUsuario;
    }
}