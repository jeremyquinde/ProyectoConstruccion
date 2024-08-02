using CapaPresentacion.Resources.Custom;

namespace CapaPresentacion
{
    partial class frmLogin
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
            panel1 = new Panel();
            btnLogin = new CustomBtn();
            label4 = new Label();
            label2 = new Label();
            txtLoginPass = new Custom.RJTextBox();
            txtLoginUser = new Custom.RJTextBox();
            label3 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtLoginPass);
            panel1.Controls.Add(txtLoginUser);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(830, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(434, 681);
            panel1.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(255, 97, 63);
            btnLogin.BackgroundColor = Color.FromArgb(255, 97, 63);
            btnLogin.BorderColor = Color.PaleVioletRed;
            btnLogin.BorderRadius = 20;
            btnLogin.BorderSize = 0;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(75, 477);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(292, 40);
            btnLogin.TabIndex = 11;
            btnLogin.Text = "INICIAR SESION";
            btnLogin.TextColor = Color.White;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkGray;
            label4.Location = new Point(71, 102);
            label4.Name = "label4";
            label4.Size = new Size(296, 21);
            label4.TabIndex = 10;
            label4.Text = "User: 0123456789 pass: administrador";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(75, 337);
            label2.Name = "label2";
            label2.Size = new Size(159, 30);
            label2.TabIndex = 9;
            label2.Text = "CONTRASEÑA";
            // 
            // txtLoginPass
            // 
            txtLoginPass.BackColor = SystemColors.Window;
            txtLoginPass.BorderColor = Color.FromArgb(255, 59, 52);
            txtLoginPass.BorderFocusColor = Color.FromArgb(255, 131, 73);
            txtLoginPass.BorderSize = 3;
            txtLoginPass.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtLoginPass.ForeColor = Color.Black;
            txtLoginPass.Location = new Point(75, 373);
            txtLoginPass.Margin = new Padding(4);
            txtLoginPass.Multiline = false;
            txtLoginPass.Name = "txtLoginPass";
            txtLoginPass.Padding = new Padding(12, 7, 7, 7);
            txtLoginPass.PasswordChar = false;
            txtLoginPass.Size = new Size(292, 40);
            txtLoginPass.TabIndex = 6;
            txtLoginPass.Texts = "";
            txtLoginPass.UnderlinedStyle = false;
            // 
            // txtLoginUser
            // 
            txtLoginUser.BackColor = SystemColors.Window;
            txtLoginUser.BorderColor = Color.FromArgb(255, 59, 52);
            txtLoginUser.BorderFocusColor = Color.FromArgb(255, 131, 73);
            txtLoginUser.BorderSize = 3;
            txtLoginUser.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtLoginUser.ForeColor = Color.Black;
            txtLoginUser.Location = new Point(75, 255);
            txtLoginUser.Margin = new Padding(4);
            txtLoginUser.Multiline = false;
            txtLoginUser.Name = "txtLoginUser";
            txtLoginUser.Padding = new Padding(12, 7, 7, 7);
            txtLoginUser.PasswordChar = false;
            txtLoginUser.Size = new Size(292, 40);
            txtLoginUser.TabIndex = 5;
            txtLoginUser.Texts = "";
            txtLoginUser.UnderlinedStyle = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 35.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.OrangeRed;
            label3.Location = new Point(58, 37);
            label3.Name = "label3";
            label3.Size = new Size(324, 62);
            label3.TabIndex = 4;
            label3.Text = "BIENVENIDO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(75, 220);
            label1.Name = "label1";
            label1.Size = new Size(110, 30);
            label1.TabIndex = 2;
            label1.Text = "USUARIO";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources._10;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(833, 681);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkGray;
            label5.Location = new Point(75, 133);
            label5.Name = "label5";
            label5.Size = new Size(261, 21);
            label5.TabIndex = 12;
            label5.Text = "User: 0987654321 pass: vendedor";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkGray;
            label6.Location = new Point(75, 164);
            label6.Name = "label6";
            label6.Size = new Size(238, 21);
            label6.TabIndex = 13;
            label6.Text = "User: 654321987 pass: gerente";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1264, 681);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            MaximumSize = new Size(1280, 720);
            MinimumSize = new Size(1280, 720);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label3;
        private Custom.RJTextBox txtLoginUser;
        private Custom.RJTextBox txtLoginPass;
        private Label label2;
        private Label label4;
        private CustomBtn btnLogin;
        private Label label6;
        private Label label5;
    }
}