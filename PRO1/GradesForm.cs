using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Spreadsheet;
using PRO1.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PRO1
{
    public partial class GradesForm : Form
    {
        private User currentUser;
        private FirebaseHelper firebaseHelper;
        private List<ExamResult> examResults = new List<ExamResult>();


        public GradesForm(User user)
        {
            InitializeComponent();
            currentUser = user;
            firebaseHelper = new FirebaseHelper();
            this.BackgroundImage = Image.FromFile(@"C:\Users\maimo\source\repos\PRO1\PRO1\Resources\projec11.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            label1.BackColor = System.Drawing.Color.FromArgb(100, 173, 216, 230);
            label2.BackColor = System.Drawing.Color.FromArgb(100, 173, 216, 230);
            label1.Font = new System.Drawing.Font("Arial", 12, FontStyle.Bold);
            label2.Font = new System.Drawing.Font("Arial", 12, FontStyle.Bold);
            label3.Font = new System.Drawing.Font("Arial", 20, FontStyle.Bold);
            label3.BackColor = System.Drawing.Color.FromArgb(120, 173, 216, 230); // תכלת עם שקיפות
            label4.Font = new System.Drawing.Font("Arial", 20, FontStyle.Bold);



        }

        private async void GradesForm_Load(object sender, EventArgs e)
        {
            

            try
            {
                // שליפת תוצאות המבחנים של המשתמש הנוכחי
                examResults = await firebaseHelper.GetAllExamsAsync(currentUser.UserId);

                // שליפת כל המבחנים כדי שנוכל לראות כמות שאלות לפי ID
                List<Exam> allExams = await firebaseHelper.GetAllExamsAsync();

                // יצירת טבלה
                DataTable table = new DataTable();
                table.Columns.Add("מזהה מבחן");
                table.Columns.Add("כמות שאלות");
                table.Columns.Add("ציון");
                table.Columns.Add("תאריך");

                foreach (var result in examResults)
                { 
                    var exam = allExams.FirstOrDefault(ex => ex.Id == result.ExamId);

                    int questionCount = exam != null ? exam.QuestionCount : 0;

                    table.Rows.Add(result.ExamId, questionCount, result.Grade, result.TakenAt.ToString("dd/MM/yyyy HH:mm"));
                }

                dataGridView1.DataSource = table;

                // עיצוב הטבלה (רשות)
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10, FontStyle.Bold);
                dataGridView1.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10);
            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה בטעינת נתוני הציונים: " + ex.Message);
            }
            // חישוב ממוצע ציונים והצגה ב-label4
            double total = 0;
            int count = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["ציון"].Value != null && double.TryParse(row.Cells["ציון"].Value.ToString(), out double grade))
                {
                    total += grade;
                    count++;
                }
            }

            double average = count > 0 ? total / count : 0;
            label4.Text = average.ToString("0.##"); // רק הממוצע, בלי טקסט נוסף

            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.GridColor = dataGridView1.BackgroundColor;

            DrawGradesChart();



        }
        private void DrawGradesChart()
        {
            chartGrades.Series.Clear();
            chartGrades.ChartAreas.Clear();

            // יצירת אזור גרף
            ChartArea chartArea = new ChartArea();
            chartArea.BackColor = System.Drawing.Color.White;
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea.AxisX.Title = "תאריך";
            chartArea.AxisY.Title = "ציון";
            chartGrades.ChartAreas.Add(chartArea);

            // יצירת סדרה
            Series series = new Series
            {
                ChartType = SeriesChartType.SplineArea, // קו הררי חלק
                Color = System.Drawing.Color.FromArgb(180, 0, 120, 255), // כחול שקוף
                BorderWidth = 2,
                BorderColor = System.Drawing.Color.Blue,
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 6,
                MarkerColor = System.Drawing.Color.Blue,
            };

            // הוספת הנתונים לפי תאריך
            var sortedResults = examResults.OrderBy(r => r.TakenAt);
            foreach (var result in sortedResults)
            {
                series.Points.AddXY(result.TakenAt.ToString("dd/MM"), result.Grade);
            }

            chartGrades.Series.Add(series);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void chartGrades_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
