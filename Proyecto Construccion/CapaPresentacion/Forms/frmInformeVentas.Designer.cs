namespace CapaPresentacion.Forms
{
    partial class frmInformeVentas
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            btnFiltroHoy = new Button();
            btnFiltroSemanal = new Button();
            btnFiltroMensual = new Button();
            chartVentas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1 = new Panel();
            totalVentas = new Label();
            label4 = new Label();
            panel3 = new Panel();
            totalBeneficio = new Label();
            label6 = new Label();
            panel4 = new Panel();
            totalIngresos = new Label();
            label5 = new Label();
            fechaDesde = new DateTimePicker();
            fechaHasta = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)chartVentas).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // btnFiltroHoy
            // 
            btnFiltroHoy.Location = new Point(469, 110);
            btnFiltroHoy.Name = "btnFiltroHoy";
            btnFiltroHoy.Size = new Size(213, 33);
            btnFiltroHoy.TabIndex = 0;
            btnFiltroHoy.Text = "HOY";
            btnFiltroHoy.UseVisualStyleBackColor = true;
            btnFiltroHoy.Click += btnFiltroHoy_Click;
            // 
            // btnFiltroSemanal
            // 
            btnFiltroSemanal.Location = new Point(694, 110);
            btnFiltroSemanal.Name = "btnFiltroSemanal";
            btnFiltroSemanal.Size = new Size(213, 33);
            btnFiltroSemanal.TabIndex = 1;
            btnFiltroSemanal.Text = "ULTIMOS 7 DIAS";
            btnFiltroSemanal.UseVisualStyleBackColor = true;
            btnFiltroSemanal.Click += btnFiltroSemanal_Click;
            // 
            // btnFiltroMensual
            // 
            btnFiltroMensual.Location = new Point(917, 111);
            btnFiltroMensual.Name = "btnFiltroMensual";
            btnFiltroMensual.Size = new Size(213, 33);
            btnFiltroMensual.TabIndex = 2;
            btnFiltroMensual.Text = "ULTIMOS 30 DIAS";
            btnFiltroMensual.UseVisualStyleBackColor = true;
            btnFiltroMensual.Click += btnFiltroMensual_Click;
            // 
            // chartVentas
            // 
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.LabelStyle.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            chartArea1.AxisX.MajorGrid.LineWidth = 0;
            chartArea1.AxisX.MajorTickMark.LineWidth = 0;
            chartArea1.AxisX.TitleAlignment = StringAlignment.Near;
            chartArea1.AxisX2.IsMarginVisible = false;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            chartArea1.AxisY.LabelStyle.Format = "${}";
            chartArea1.AxisY.MajorTickMark.LineWidth = 0;
            chartArea1.Name = "ChartArea1";
            chartVentas.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartVentas.Legends.Add(legend1);
            chartVentas.Location = new Point(12, 330);
            chartVentas.Name = "chartVentas";
            series1.BackSecondaryColor = Color.White;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series1.Legend = "Legend1";
            series1.MarkerSize = 0;
            series1.Name = "Series1";
            series1.YValuesPerPoint = 2;
            chartVentas.Series.Add(series1);
            chartVentas.Size = new Size(1163, 479);
            chartVentas.TabIndex = 3;
            chartVentas.Text = "chart1";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(totalVentas);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(79, 180);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 100);
            panel1.TabIndex = 4;
            // 
            // totalVentas
            // 
            totalVentas.AutoSize = true;
            totalVentas.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            totalVentas.Location = new Point(151, 40);
            totalVentas.Name = "totalVentas";
            totalVentas.Size = new Size(0, 37);
            totalVentas.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.GrayText;
            label4.Location = new Point(14, 9);
            label4.Name = "label4";
            label4.Size = new Size(121, 21);
            label4.TabIndex = 0;
            label4.Text = "TOTAL VENTAS";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gainsboro;
            panel3.Controls.Add(totalBeneficio);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(789, 180);
            panel3.Name = "panel3";
            panel3.Size = new Size(350, 100);
            panel3.TabIndex = 7;
            // 
            // totalBeneficio
            // 
            totalBeneficio.AutoSize = true;
            totalBeneficio.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            totalBeneficio.Location = new Point(90, 40);
            totalBeneficio.Name = "totalBeneficio";
            totalBeneficio.Size = new Size(0, 37);
            totalBeneficio.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.GrayText;
            label6.Location = new Point(17, 9);
            label6.Name = "label6";
            label6.Size = new Size(141, 21);
            label6.TabIndex = 1;
            label6.Text = "TOTAL BENEFICIO";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gainsboro;
            panel4.Controls.Add(totalIngresos);
            panel4.Controls.Add(label5);
            panel4.Location = new Point(434, 180);
            panel4.Name = "panel4";
            panel4.Size = new Size(350, 100);
            panel4.TabIndex = 6;
            // 
            // totalIngresos
            // 
            totalIngresos.AutoSize = true;
            totalIngresos.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            totalIngresos.Location = new Point(84, 40);
            totalIngresos.Name = "totalIngresos";
            totalIngresos.Size = new Size(0, 37);
            totalIngresos.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.GrayText;
            label5.Location = new Point(13, 9);
            label5.Name = "label5";
            label5.Size = new Size(138, 21);
            label5.TabIndex = 1;
            label5.Text = "TOTAL INGRESOS";
            // 
            // fechaDesde
            // 
            fechaDesde.CustomFormat = "    dd/MM/yyyy - hh:mm";
            fechaDesde.Enabled = false;
            fechaDesde.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            fechaDesde.Format = DateTimePickerFormat.Custom;
            fechaDesde.Location = new Point(183, 56);
            fechaDesde.Name = "fechaDesde";
            fechaDesde.Size = new Size(254, 33);
            fechaDesde.TabIndex = 8;
            // 
            // fechaHasta
            // 
            fechaHasta.CustomFormat = "    dd/MM/yyyy - hh:mm";
            fechaHasta.Enabled = false;
            fechaHasta.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            fechaHasta.Format = DateTimePickerFormat.Custom;
            fechaHasta.Location = new Point(183, 110);
            fechaHasta.Name = "fechaHasta";
            fechaHasta.Size = new Size(254, 33);
            fechaHasta.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(72, 56);
            label1.Name = "label1";
            label1.Size = new Size(96, 32);
            label1.TabIndex = 10;
            label1.Text = "DESDE:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(72, 111);
            label2.Name = "label2";
            label2.Size = new Size(98, 32);
            label2.TabIndex = 11;
            label2.Text = "HASTA:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(469, 56);
            label3.Name = "label3";
            label3.Size = new Size(273, 32);
            label3.TabIndex = 12;
            label3.Text = "FILTRAR GRAFICO POR";
            // 
            // frmInformeVentas
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1187, 861);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(fechaHasta);
            Controls.Add(fechaDesde);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(chartVentas);
            Controls.Add(btnFiltroMensual);
            Controls.Add(btnFiltroSemanal);
            Controls.Add(btnFiltroHoy);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "frmInformeVentas";
            Text = "frmInformeVentas";
            Load += frmInformeVentas_Load;
            ((System.ComponentModel.ISupportInitialize)chartVentas).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFiltroHoy;
        private Button btnFiltroSemanal;
        private Button btnFiltroMensual;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVentas;
        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private DateTimePicker fechaDesde;
        private DateTimePicker fechaHasta;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label5;
        private Label totalVentas;
        private Label totalBeneficio;
        private Label totalIngresos;
    }
}