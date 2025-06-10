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
        private string questionKey; 
        private bool isEditMode = false;
        public TrueFalse()
        {
            InitializeComponent();
            
        }
        public TrueFalse(Question selectedQuestion)
        {
            InitializeComponent();
            

            isEditMode = true;
            questionKey = selectedQuestion.Id;

            // מילוי נתוני השאלה בטופס
            textBox1.Text = selectedQuestion.QuestionText;

            if (selectedQuestion.CorrectAnswer == "True")
                radioButton1.Checked = true;
            else if (selectedQuestion.CorrectAnswer == "False")
                radioButton2.Checked = true;

            comboBox1.SelectedItem = selectedQuestion.Topic;
            comboBox2.SelectedItem = selectedQuestion.Level;
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

            string questionText = textBox1.Text;
            string correctAnswer = GetCorrectAnswer();
            string topic = comboBox1.SelectedItem?.ToString();
            string level = comboBox2.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(questionText) || string.IsNullOrWhiteSpace(correctAnswer))
            {
                MessageBox.Show("אנא מלא את כל השדות הדרושים.");
                return;
            }

            if (isEditMode)
            {
                // עדכון שאלה קיימת
                var data = new Dictionary<string, object>
        {
                    { "Id", questionKey },
            { "QuestionText", questionText },
            { "CorrectAnswer", correctAnswer },
            { "Topic", topic },
            { "Level", level },
            { "Type", "TrueFalse" },
            { "TeacherId", SessionManager.TeacherId }
        };

                await firebaseHelper.UpdateQuestionAsync(questionKey, data);
                MessageBox.Show("השאלה עודכנה בהצלחה!");
            }
            else
            {
                // הוספת שאלה חדשה
                await firebaseHelper.AddQuestionAsync("TrueFalse", correctAnswer, topic, level, questionText, "", "", "", "", SessionManager.TeacherId);
                MessageBox.Show("השאלה נשמרה בהצלחה!");
            }
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
