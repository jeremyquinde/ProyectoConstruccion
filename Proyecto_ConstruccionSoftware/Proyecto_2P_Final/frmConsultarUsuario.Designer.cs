namespace CapaPresentacion
{
    partial class frmConsultarUsuario
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
            dgvConsultaUsuarios = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvConsultaUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dgvConsultaUsuarios
            // 
            dgvConsultaUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultaUsuarios.Location = new Point(45, 32);
            dgvConsultaUsuarios.Name = "dgvConsultaUsuarios";
            dgvConsultaUsuarios.RowTemplate.Height = 25;
            dgvConsultaUsuarios.Size = new Size(702, 387);
            dgvConsultaUsuarios.TabIndex = 0;
            // 
            // frmConsultarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvConsultaUsuarios);
            Name = "frmConsultarUsuario";
            Text = "Form1";
            Load += frmConsultarUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvConsultaUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvConsultaUsuarios;
    }
}