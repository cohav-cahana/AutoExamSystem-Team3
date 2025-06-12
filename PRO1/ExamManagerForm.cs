using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRO1
{
    public partial class ExamManagerForm : Form
    {
        private FirebaseHelper firebaseHelper = new FirebaseHelper();

        public ExamManagerForm()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            label1.Font = new System.Drawing.Font("Arial", 12, FontStyle.Bold);
        }

        private List<Exam> exams = new List<Exam>();

        private async void btnDeleteExam_Click(object sender, EventArgs e)
        {
            if (lstExams.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an exam to delete.");
                return;
            }

            string selectedId = exams[lstExams.SelectedIndex].Id;
            await firebaseHelper.DeleteExamAsync(selectedId);
            MessageBox.Show("Exam deleted.");

            ExamManagerForm_Load(sender, e);
        }

        private async void ExamManagerForm_Load(object sender, EventArgs e)
        {

            var data = await firebaseHelper.GetAllExamsAsync();
            exams = data;
            if (exams.Count == 0)
            {
                MessageBox.Show("No exams found in the database.");
                return;
            }

            lstExams.Items.Clear();
            foreach (var exam in exams)
                lstExams.Items.Add($"{exam.Id} - {exam.QuestionCount} questions ({exam.Difficulty})");
        }

        private void lstExams_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstExams.SelectedIndex == -1)
                return;

            var selectedExam = exams[lstExams.SelectedIndex];
            lstExamQuestions.Items.Clear();

            if (selectedExam.Questions != null && selectedExam.Questions.Count > 0)
            {
                foreach (var q in selectedExam.Questions)
                {
                    lstExamQuestions.Items.Add(
                        $"• {q.QuestionText} | Answer: {q.CorrectAnswer} ({q.Type}, {q.Level})"
                    );
                }
            }
            else
            {
                lstExamQuestions.Items.Add("This exam has no saved questions.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
 


    }

}
