using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Drawing.Charts;

namespace PRO1
{
    //ניסיון
    public partial class AdaptiveSelectionForm : Form
    {

        private User user;
        private ExamSelection examSelection;
        public AdaptiveSelectionForm(User user, ExamSelection examSelection)
        {
            InitializeComponent();
            this.user = user;
            this.examSelection = examSelection;
            this.BackColor = Color.White;


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            examSelection.Show();
        }

        private async void Clickstart(object sender, EventArgs e)
        {
            String num = numberQuestion.Text;
            String type = typeofQ.Text;
            FirebaseHelper firebaseHelper = new FirebaseHelper();

            //await firebaseHelper.SaveExamResultAsync(result);
            if (!int.TryParse(num, out int number) || typeofQ.SelectedItem == null)
            {
                MessageBox.Show("Please enter the number of questions and the topic.");
                return;
            }
            var easyQuestions = await firebaseHelper.GetQuestionsByTopicAndLevelAsync(type, "קל");
            var mediumQuestions = await firebaseHelper.GetQuestionsByTopicAndLevelAsync(type, "בינוני");
            var hardQuestions = await firebaseHelper.GetQuestionsByTopicAndLevelAsync(type, "קשה");
            if (easyQuestions == null || easyQuestions.Count < number || mediumQuestions == null
                || mediumQuestions.Count < number || hardQuestions == null || hardQuestions.Count < number)
            {
                MessageBox.Show("Not enough questions available for the selected topic.");
                return;
            }
            else
            {
                AdaptiveTestForm adaptiveTestForm = new AdaptiveTestForm(user, this, number, easyQuestions, mediumQuestions, hardQuestions, type);
                adaptiveTestForm.Show();
                this.Hide();
            }
        }

        private void AdaptiveSelectionForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}