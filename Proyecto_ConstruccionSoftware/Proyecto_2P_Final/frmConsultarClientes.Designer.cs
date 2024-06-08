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
            dgvConsultarClientes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvConsultarClientes).BeginInit();
            SuspendLayout();
            // 
            // dgvConsultarClientes
            // 
            dgvConsultarClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultarClientes.Location = new Point(65, 63);
            dgvConsultarClientes.Name = "dgvConsultarClientes";
            dgvConsultarClientes.RowTemplate.Height = 25;
            dgvConsultarClientes.Size = new Size(678, 321);
            dgvConsultarClientes.TabIndex = 0;
            // 
            // frmConsultarClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvConsultarClientes);
            Name = "frmConsultarClientes";
            Text = "Form1";
            Load += this.frmConsultarClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvConsultarClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvConsultarClientes;
    }
}