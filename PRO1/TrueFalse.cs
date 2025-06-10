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
    public partial class TrueFalse : Form
    {
        public TrueFalse()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.back2;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void TrueFalse_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            FirebaseHelper firebaseHelper = new FirebaseHelper();

            // קבלת המידע מהטופס
            string questionText = textBox1.Text;  // השאלה
            string correctAnswer = GetCorrectAnswer();  // תשובה נכונה (True/False)
            string topic = comboBox1.SelectedItem.ToString(); // סוג השאלה שנבחר בקומבובוקס1
            string level = comboBox2.SelectedItem.ToString(); // רמת השאלה שנבחרה בקומבובוקס2

            // שליחה ל-Firebase
            await firebaseHelper.AddQuestionAsync("TrueFalse",correctAnswer, topic, level, questionText, "", "", "", "","");
            // הודעה שהשאלה נשמרה בהצלחה
            MessageBox.Show("השאלה נשמרה בהצלחה!");
        }

        // פונקציה לקביעת התשובה הנכונה
        private string GetCorrectAnswer()
        {
            if (radioButton1.Checked) return "True";  // אם נבחר True
            if (radioButton2.Checked) return "False";  // אם נבחר False

            return string.Empty;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();


            QuestionForm questionForm = new QuestionForm();


            questionForm.Show();
        }
    }
}
