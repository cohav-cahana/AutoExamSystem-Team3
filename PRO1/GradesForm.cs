using DocumentFormat.OpenXml.Bibliography;
using PRO1.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
        private StudentForm studentForm;
        private frontPage login;




        public GradesForm(User user, frontPage login)
        {
            InitializeComponent();
            this.currentUser = user;
            this.login = login;
            firebaseHelper = new FirebaseHelper();
            
           
            
            
            label4.Font = new System.Drawing.Font("Arial", 20, FontStyle.Bold);

            StyleLabel(label1);
            StyleLabel(label2);
            StyleLabel(label3); 
           

            chartGrades.BackColor = Color.Transparent;
            chartGrades.ChartAreas[0].BackColor = Color.FromArgb(160, Color.White);
            StyleLinenButton(button1);
            StyleDataGridView(dataGridView1);

            StyleWarmButton(button1);
            SetRoundedRegion(panelAverage,20);
        }
        private void SetRoundedRegion(Control control, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = control.ClientRectangle;

            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();

            control.Region = new Region(path);
        }


        private void StyleLinenButton(Button button)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.BackColor = Color.Linen;
            button.ForeColor = ColorTranslator.FromHtml("#3E2C23");
            button.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            button.FlatAppearance.BorderSize = 0; // <--- בלי מסגרת
            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 239, 213); // Peach-like hover
            button.Cursor = Cursors.Hand;
            button.TextAlign = ContentAlignment.MiddleCenter;
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
                table.Columns.Add("Exam ID");
                table.Columns.Add("Number of Questions");
                table.Columns.Add("Grade");
                table.Columns.Add("Date");

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

                dataGridView1.BorderStyle = BorderStyle.None;
                dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
                dataGridView1.GridColor = dataGridView1.BackgroundColor;

                double total = 0;
                int count = 0;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["Grade"].Value != null && double.TryParse(row.Cells["Grade"].Value.ToString(), out double grade))
                    {
                        total += grade;
                        count++;
                    }
                }

                double average = count > 0 ? total / count : 0;
                label4.Text = average.ToString("0.##"); // רק המספר

                // ציור תרשים ציונים
                DrawGradesChart();


            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה בטעינת נתוני הציונים: " + ex.Message);
            }
            



        }
        private void DrawGradesChart()
        {
            chartGrades.Series.Clear();
            chartGrades.ChartAreas.Clear();

            ChartArea chartArea = new ChartArea();
            chartArea.BackColor = System.Drawing.Color.White;
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea.AxisX.Title = "Date";
            chartArea.AxisY.Title = "Grade";
            chartGrades.ChartAreas.Add(chartArea);

            
            Series series = new Series
            {
                ChartType = SeriesChartType.SplineArea,
                Color = System.Drawing.Color.FromArgb(180, 255, 245, 238),  
                BorderWidth = 2,
                BorderColor = Color.FromArgb(255, 245, 230, 220)
,
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 6,
                MarkerColor = Color.FromArgb(255, 245, 230, 220),
            };

          
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
        private void StyleDataGridView(DataGridView dgv)
        {
            dgv.BorderStyle = BorderStyle.None;
            dgv.BackgroundColor = Color.White;
            dgv.EnableHeadersVisualStyles = false;
            dgv.GridColor = Color.LightGray;

            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(217, 160, 102); // חום בהיר
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;

            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#3E2C23");
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(230, 215, 200);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.ColumnHeadersHeight = 35;

            dgv.RowTemplate.Height = 30;
            dgv.AllowUserToAddRows = false;
            dgv.RowHeadersVisible = false;
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


        private void button1_Click(object sender, EventArgs e)
        {

            if (studentForm == null)
            {
                studentForm = new StudentForm(currentUser, login);
            }
            this.Close();
            studentForm.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void StyleLabel(Label label, bool isTitle = false)
        {
            label.BackColor = Color.Transparent;
            label.ForeColor = ColorTranslator.FromHtml("#3E2C23");
            label.Font = isTitle
                ? new Font("Segoe UI", 16, FontStyle.Bold)
                : new Font("Segoe UI", 11, FontStyle.Regular);
            label.TextAlign = ContentAlignment.MiddleRight;
        }

        private void button1_Click_1(object sender, EventArgs e) {
            StudentForm gradesform = new StudentForm(currentUser, login);
            gradesform.Show();
            this.Hide();
        }

        private void panelAverage_Paint(object sender, PaintEventArgs e)
        {

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

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
