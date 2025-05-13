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
    public partial class MultipleChoice : Form
    {
        public MultipleChoice()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.back2;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void MultipleChoice_Load(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)

        {
            FirebaseHelper firebaseHelper = new FirebaseHelper();

            // קבלת המידע מהטופס
            string questionText = textBox1.Text;
            string answer1 = textBox2.Text;
            string answer2 = textBox3.Text;
            string answer3 = textBox4.Text;
            string answer4 = textBox5.Text;
            string topic = comboBox1.SelectedItem?.ToString();
            string level = comboBox2.SelectedItem?.ToString();
            string correctAnswer = GetCorrectAnswer();


            // שליחה ל-Firebase
            await firebaseHelper.AddQuestionAsync("MultipleChoice",correctAnswer, topic,level, questionText,  answer1,  answer2, answer3, answer4);

            // הודעה שהשאלה נשמרה בהצלחה
            MessageBox.Show("השאלה נשמרה בהצלחה!");
        }

        // פונקציה לקביעת התשובה הנכונה
        private string GetCorrectAnswer()
        {
            if (radioButton1.Checked) return textBox2.Text;
            if (radioButton2.Checked) return textBox3.Text;
            if (radioButton3.Checked) return textBox4.Text;
            if (radioButton4.Checked) return textBox5.Text;

            return string.Empty; // אם לא נבחרה תשובה נכונה
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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

