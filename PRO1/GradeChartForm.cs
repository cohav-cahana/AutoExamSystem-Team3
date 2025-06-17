using System;
using System.Drawing;
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
            StyleWarmButton(button1);
        }

        private void InitializeChart(int high, int mid, int low)
        {
            chart1.Series.Clear();
            chart1.Titles.Clear();

            chart1.Titles.Add("Student Grade Distribution By Ranges");

            Series series = new Series("מספר תלמידים");
            series.ChartType = SeriesChartType.Column;

            series.Points.AddXY("85-100", high);
            series.Points.AddXY("56-84", mid);
            series.Points.AddXY("0-55", low);

            chart1.Series.Add(series);

            chart1.ChartAreas[0].AxisX.Title = "Grade Range";
            chart1.ChartAreas[0].AxisY.Title = "Amount Of Students";
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StyleWarmButton(Button button)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.BackColor = ColorTranslator.FromHtml("#D9A066");
            button.ForeColor = Color.White;
            button.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#B86F50");
            button.Cursor = Cursors.Hand;
        }
    }



}