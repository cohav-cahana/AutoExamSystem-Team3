using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PRO1
{
    public partial class GradeChartForm : Form
    {
        public GradeChartForm(int high, int mid, int low)
        {
            InitializeComponent();
            InitializeChart(high, mid, low);
        }

        private void InitializeChart(int high, int mid, int low)
        {
            chart1.Series.Clear();
            chart1.Titles.Clear();

            chart1.Titles.Add("התפלגות ציונים לפי טווחים");

            Series series = new Series("מספר תלמידים");
            series.ChartType = SeriesChartType.Column;

            series.Points.AddXY("85-100", high);
            series.Points.AddXY("56-84", mid);
            series.Points.AddXY("0-55", low);

            chart1.Series.Add(series);

            chart1.ChartAreas[0].AxisX.Title = "טווח ציונים";
            chart1.ChartAreas[0].AxisY.Title = "כמות תלמידים";
        }
        private void GradeChartForm_Load(object sender, EventArgs e)
        {
            // כלום – רק כדי למנוע שגיאה
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }



}