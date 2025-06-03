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
    public partial class ExamSelection : Form
    {
        private User currentUser;
        private StudentForm studentForm;
        public ExamSelection(User user, StudentForm studentForm)
        {
            this.studentForm = studentForm;
            this.currentUser = user;
            InitializeComponent();
            LoadExams();
            this.BackgroundImage = Properties.Resources.jeffrey;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.BackColor = Color.FromArgb(120, Color.White);
            panel1.BorderStyle = BorderStyle.None;
        }
        private async void LoadExams()
        {
            FirebaseHelper firebaseHelper = new FirebaseHelper();
            var exams = await firebaseHelper.GetAllExamsAsync();
            examList.Items.AddRange(exams.ToArray());

        }

        private void examList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (examList.SelectedItem is Exam selectedExam)
            {
                topicLbl.Visible = true;
                topicPlaceholder.Text = selectedExam.Topics.First();
                topicPlaceholder.Visible = true;

                difficultyLbl.Visible = true;
                difficultyPlaceholder.Text = selectedExam.Difficulty;
                difficultyPlaceholder.Visible = true;

                numQuestionLbl.Visible = true;
                numQuestionPlaceholder.Text = selectedExam.QuestionCount.ToString();
                numQuestionPlaceholder.Visible = true;

                durationLbl.Visible = true;
                string duration = TestForm.FormatTime(selectedExam.DurationInSeconds);
                durationPlaceholder.Text = duration;
                durationPlaceholder.Visible = true;
            }
        }

        private void startExamBtn_Click(object sender, EventArgs e)
        {
            if (examList.SelectedItem is Exam selectedExam)
            {
                // Open the exam form, pass selectedExam and currentUser
                TestForm examForm = new TestForm(currentUser, selectedExam, this);
                examForm.Show();
                this.Hide();
            }
            else if (examList.SelectedItem == null)
            {
                MessageBox.Show("Please select an exam to start.");
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            studentForm.Show();
            this.Close();
        }

        private void ExamSelection_Load(object sender, EventArgs e)
        {

        }

        private void topicPlaceholder_Click(object sender, EventArgs e)
        {

        }
    }
}
