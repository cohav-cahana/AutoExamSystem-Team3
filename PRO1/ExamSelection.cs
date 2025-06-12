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
            this.BackColor = Color.White;


            StyleLabel(topLbl);
            StyleLabel(topicLbl);
            StyleLabel(difficultyLbl);
            StyleLabel(numQuestionLbl);
            StyleLabel(durationLbl);

            topLbl.Visible = true;
            topicLbl.Visible = true;
            difficultyLbl.Visible = true;
            numQuestionLbl.Visible = true;
            durationLbl.Visible = true;

            StyleLabel(topicPlaceholder);
            StyleLabel(difficultyPlaceholder);
            StyleLabel(numQuestionPlaceholder);
            StyleLabel(durationPlaceholder);
            StyleWarmButton(backBtn);
            StyleWarmButton(startExamBtn);
            StyleWarmButton(btn_A);





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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //using (SolidBrush semiTransBrush = new SolidBrush(Color.FromArgb(120, Color.White)))
            //{
            //    e.Graphics.FillRectangle(semiTransBrush, panel1.ClientRectangle);
            //}
        }

        private void StyleLabel(Label label, bool isTitle = false)
        {
            label.ForeColor = ColorTranslator.FromHtml(isTitle ? "#5C3A21" : "#3E2C23");
            label.BackColor = Color.Transparent;
            label.Font = isTitle
                ? new Font("Segoe UI", 16, FontStyle.Bold)
                : new Font("Segoe UI", 11, FontStyle.Regular);
            label.TextAlign = ContentAlignment.MiddleRight;
            label.RightToLeft = RightToLeft.Yes;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void StyleWarmButton(Button button)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.BackColor = ColorTranslator.FromHtml("#D9A066"); // חום בהיר
            button.ForeColor = Color.White;
            button.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#B86F50"); // חום כהה יותר בהובר
            button.Cursor = Cursors.Hand;
        }

        private void topicLbl_Click(object sender, EventArgs e)
        {

        }

        private void numQuestionLbl_Click(object sender, EventArgs e)
        {

        }

        private void difficultyPlaceholder_Click(object sender, EventArgs e)
        {

        }

        private void btn_A_Click(object sender, EventArgs e)
        {
            AdaptiveSelectionForm adaptiveSelectionForm = new AdaptiveSelectionForm(currentUser, this);
            adaptiveSelectionForm.Show();
            this.Hide();
        }
    }
}
