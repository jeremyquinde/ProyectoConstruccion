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
            btnVentaDiaria = new Button();
            btnVentaSemanal = new Button();
            btnVentaMensual = new Button();
            chartVentas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)chartVentas).BeginInit();
            SuspendLayout();
            // 
            // btnVentaDiaria
            // 
            btnVentaDiaria.Location = new Point(469, 110);
            btnVentaDiaria.Name = "btnVentaDiaria";
            btnVentaDiaria.Size = new Size(213, 33);
            btnVentaDiaria.TabIndex = 0;
            btnVentaDiaria.Text = "POR DIA";
            btnVentaDiaria.UseVisualStyleBackColor = true;
            btnVentaDiaria.Click += btnVentaDiaria_Click;
            // 
            // btnVentaSemanal
            // 
            btnVentaSemanal.Location = new Point(694, 110);
            btnVentaSemanal.Name = "btnVentaSemanal";
            btnVentaSemanal.Size = new Size(213, 33);
            btnVentaSemanal.TabIndex = 1;
            btnVentaSemanal.Text = "POR SEMANA";
            btnVentaSemanal.UseVisualStyleBackColor = true;
            btnVentaSemanal.Click += btnVentaSemanal_Click;
            // 
            // btnVentaMensual
            // 
            btnVentaMensual.Location = new Point(917, 111);
            btnVentaMensual.Name = "btnVentaMensual";
            btnVentaMensual.Size = new Size(213, 33);
            btnVentaMensual.TabIndex = 2;
            btnVentaMensual.Text = "POR MES";
            btnVentaMensual.UseVisualStyleBackColor = true;
            btnVentaMensual.Click += btnVentaMensual_Click;
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
            panel1.Location = new Point(68, 180);
            panel1.Name = "panel1";
            panel1.Size = new Size(375, 100);
            panel1.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gainsboro;
            panel3.Location = new Point(830, 180);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 100);
            panel3.TabIndex = 7;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gainsboro;
            panel4.Location = new Point(449, 180);
            panel4.Name = "panel4";
            panel4.Size = new Size(375, 100);
            panel4.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "    dd/mm/yyyy - hh:mm";
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(183, 56);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(254, 33);
            dateTimePicker1.TabIndex = 8;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "    dd/mm/yyyy - hh:mm";
            dateTimePicker2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(183, 110);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(254, 33);
            dateTimePicker2.TabIndex = 9;
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
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(chartVentas);
            Controls.Add(btnVentaMensual);
            Controls.Add(btnVentaSemanal);
            Controls.Add(btnVentaDiaria);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "frmInformeVentas";
            Text = "frmInformeVentas";
            Load += frmInformeVentas_Load;
            ((System.ComponentModel.ISupportInitialize)chartVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVentaDiaria;
        private Button btnVentaSemanal;
        private Button btnVentaMensual;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVentas;
        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}