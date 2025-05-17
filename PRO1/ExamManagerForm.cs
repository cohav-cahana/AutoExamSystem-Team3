using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }
        private List<Exam> exams = new List<Exam>();


        private async void btnDeleteExam_Click(object sender, EventArgs e)
        {
            if (lstExams.SelectedIndex == -1)
            {
                MessageBox.Show("בחר מבחן למחיקה");
                return;
            }

            string selectedId = exams[lstExams.SelectedIndex].Id;
            await firebaseHelper.DeleteExamAsync(selectedId);
            MessageBox.Show("המבחן נמחק");

            ExamManagerForm_Load(sender, e);
        }
   
        

        private async void ExamManagerForm_Load(object sender, EventArgs e)
        {
            var data = await firebaseHelper.GetAllExamsAsync();
            exams = data;
            if (exams.Count == 0)
            {
                MessageBox.Show("לא נמצאו מבחנים במאגר");
                return;
            }
            
            lstExams.Items.Clear();
            foreach (var exam in exams)
                lstExams.Items.Add($"{exam.Id} - {exam.QuestionCount} שאלות ({exam.Difficulty})");

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
                        $"• {q.QuestionText} | תשובה: {q.CorrectAnswer} ({q.Type}, {q.Level})"
                     );

                }
            }
            else
            {
                lstExamQuestions.Items.Add("למבחן זה אין שאלות שמורות");
            }
        }
    }
}
