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



        public GradesForm(User user)
        {
            InitializeComponent();
            currentUser = user;
            firebaseHelper = new FirebaseHelper();
            
            label1.BackColor = System.Drawing.Color.FromArgb(180, 150, 100, 50);
            label2.BackColor = System.Drawing.Color.FromArgb(180, 150, 100, 50);
            label1.Font = new System.Drawing.Font("Arial", 12, FontStyle.Bold);
            label2.Font = new System.Drawing.Font("Arial", 12, FontStyle.Bold);
            label3.Font = new System.Drawing.Font("Arial", 16, FontStyle.Bold);
            label3.BackColor = System.Drawing.Color.FromArgb(180, 150, 100, 50);
            label4.Font = new System.Drawing.Font("Arial", 15, FontStyle.Bold);
            int size = 80;
            int cornerRadius = 20;

            panelAverage.Size = new Size(size, size);
            panelAverage.BackColor = System.Drawing.Color.White;

            GraphicsPath path = new GraphicsPath();

            // פינה שמאל עליונה
            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
            // קו למעלה
            path.AddLine(cornerRadius, 0, size - cornerRadius, 0);
            // פינה ימין עליונה
            path.AddArc(size - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
            // קו ימני
            path.AddLine(size, cornerRadius, size, size - cornerRadius);
            // פינה ימין תחתונה
            path.AddArc(size - cornerRadius, size - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            // קו תחתון
            path.AddLine(size - cornerRadius, size, cornerRadius, size);
            // פינה שמאל תחתונה
            path.AddArc(0, size - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            // קו שמאלי
            path.AddLine(0, size - cornerRadius, 0, cornerRadius);

            panelAverage.Region = new Region(path);

            StyleLabel(label1,true);
            StyleLabel(label2);
            StyleLabel(label3, true); 
            StyleLabel(label4);

            chartGrades.BackColor = Color.Transparent;
            chartGrades.ChartAreas[0].BackColor = Color.FromArgb(160, Color.White);
            StyleLinenButton(button1);
            StyleDataGridView(dataGridView1);
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
                
                examResults = await firebaseHelper.GetAllExamsAsync(currentUser.UserId);

                
                List<Exam> allExams = await firebaseHelper.GetAllExamsAsync();

                
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
                
                dataGridView1.EnableHeadersVisualStyles = false;
                dataGridView1.BackgroundColor = System.Drawing.Color.White;
                dataGridView1.GridColor = System.Drawing.Color.LightGray;
                dataGridView1.BorderStyle = BorderStyle.None;
                dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

                
                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(240, 240, 240); 
                dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.Black;
                dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.ColumnHeadersDefaultCellStyle.Padding = new Padding(0, 5, 0, 5);
                dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

                
                dataGridView1.DefaultCellStyle.BackColor = System.Drawing.Color.White;
                dataGridView1.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
                dataGridView1.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(220, 220, 250); 
                dataGridView1.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
                dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.DefaultCellStyle.Padding = new Padding(0, 5, 0, 5);

               
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.RowTemplate.Height = 35;


               

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
                label4.Text = average.ToString("0.##"); 

                
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
            chartArea.AxisX.Title = "תאריך";
            chartArea.AxisY.Title = "ציון";
            chartGrades.ChartAreas.Add(chartArea);

            
            Series series = new Series
            {
                ChartType = SeriesChartType.SplineArea, 
                Color = System.Drawing.Color.FromArgb(180, 150, 100, 50), 

                BorderWidth = 2,
                BorderColor = System.Drawing.Color.SaddleBrown, 
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 6,
                MarkerColor = System.Drawing.Color.SaddleBrown,
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
                studentForm = new StudentForm(currentUser,  login); // בהנחה שזו החתימה
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
    }
}
