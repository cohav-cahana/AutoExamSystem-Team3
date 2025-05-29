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
    public partial class AdaptiveSelection : Form
    {

        private User user;
        private ExamSelection examSelection;
        public AdaptiveSelection(User user, ExamSelection examSelection)
        {
            InitializeComponent();
            this.user = user;
            this.examSelection = examSelection;
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
            }
            var questions = await firebaseHelper.GetQuestionsByTopicAsync(type);
            if (questions == null || questions.Count < number)
            {
                MessageBox.Show("Not enough questions available for the selected topic.");
            }
            else
            {
                AdaptiveTestForm adaptiveTestForm = new AdaptiveTestForm(user, this, number);
                adaptiveTestForm.Show();
                this.Hide();
            }
        }
    }
}
