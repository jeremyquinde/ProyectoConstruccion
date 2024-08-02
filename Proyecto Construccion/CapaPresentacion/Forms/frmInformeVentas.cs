using CapaNegocio.Modelo;
using CapaPresentacion.ViewModels;
using System.Windows.Forms.DataVisualization.Charting;

namespace CapaPresentacion.Forms
{
    public partial class frmInformeVentas : Form
    {
        private VentaModel ventaModel;


        public frmInformeVentas()
        {
            InitializeComponent();
            ventaModel = new VentaModel();
        }

        private void frmInformeVentas_Load(object sender, EventArgs e)
        {
            fechaDesde.Value = DateTime.Now.Date;
            fechaHasta.Value = DateTime.Now;
        }

        private void btnFiltroHoy_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = DateTime.Now.Date.AddHours(7);
            DateTime fechaFin = DateTime.Now.Date.AddHours(17);

            CargarInformeVentas(fechaInicio, fechaFin, "hours");
        }

        private void btnFiltroSemanal_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = DateTime.Now.Date.AddDays(-7);
            DateTime fechaFin = DateTime.Now;

            CargarInformeVentas(fechaInicio, fechaFin, "days");
        }

        private void btnFiltroMensual_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = DateTime.Now.Date.AddDays(-30);
            DateTime fechaFin = DateTime.Now;

            CargarInformeVentas(fechaInicio, fechaFin, "days_30");
        }

        private void CargarInformeVentas(DateTime fechaInicio, DateTime fechaFin, string intervalo)
        {
            var ventaViewModel = new VentaViewModel();
            var informeVentas = ventaViewModel.ObtenerInformeVentas(fechaInicio, fechaFin);

            if (!informeVentas.Any())
            {
                string mensaje = "";

                switch (intervalo)
                {
                    case "hours":
                        mensaje = "Hoy no se han realizado ventas.";
                        break;
                    case "days":
                        mensaje = "Esta semana no se han realizado ventas.";
                        break;
                    case "days_30":
                        mensaje = "Este mes no se han realizado ventas.";
                        break;
                }

                MessageBox.Show(mensaje, "Informe de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            chartVentas.Series.Clear();
            chartVentas.ChartAreas[0].AxisX.Interval = 1;
            chartVentas.ChartAreas[0].AxisY.Minimum = 0;

            var series = new Series("Ventas")
            {
                ChartType = SeriesChartType.SplineArea
            };

            DateTime minFecha = informeVentas.Min(v => v.FechaVenta);
            DateTime maxFecha = informeVentas.Max(v => v.FechaVenta);
            decimal maxPrecio = informeVentas.Max(v => v.PrecioFinal);

            chartVentas.ChartAreas[0].AxisY.Maximum = (double)maxPrecio;

            if (intervalo == "hours")
            {
                chartVentas.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm";
                chartVentas.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Hours;
                chartVentas.ChartAreas[0].AxisX.Interval = 1;
                chartVentas.ChartAreas[0].AxisX.Minimum = fechaInicio.ToOADate();
                chartVentas.ChartAreas[0].AxisX.Maximum = fechaFin.ToOADate();
            }
            else if (intervalo == "days")
            {
                chartVentas.ChartAreas[0].AxisX.LabelStyle.Format = "dd-MM";
                chartVentas.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Days;
                chartVentas.ChartAreas[0].AxisX.Interval = 1;
            }
            else if (intervalo == "days_30")
            {
                chartVentas.ChartAreas[0].AxisX.LabelStyle.Format = "dd-MM";
                chartVentas.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Days;
                chartVentas.ChartAreas[0].AxisX.Interval = 2;
            }

            foreach (var venta in informeVentas)
            {
                series.Points.AddXY(venta.FechaVenta, venta.PrecioFinal);
            }

            chartVentas.Series.Add(series);

            // Calcular totales
            var totales = ventaViewModel.CalcularTotales(informeVentas);

            // Mostrar totales en labels
            totalVentas.Text = $"{totales.TotalVentas}";
            totalIngresos.Text = $" ${totales.TotalBeneficio:F2}";
            totalBeneficio.Text = $"${totales.TotalIngresos:F2}"; ;
        }
    }
}
