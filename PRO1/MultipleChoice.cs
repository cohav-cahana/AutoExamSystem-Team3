using SixLabors.Fonts;
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
        private string questionKey;
        private string teacherId;
        private Question editedQuestion = null;


        public MultipleChoice(string teacherId)
        {
            InitializeComponent();
            this.teacherId = teacherId;

        }
        public MultipleChoice(string teacherId, Question question) : this(teacherId)
        {
            InitializeComponent();

            this.editedQuestion = question;
            this.editedQuestion = question;
            questionKey = question.Id;
            textBox1.Text = question.QuestionText;
            textBox2.Text = question.Answer1;
            textBox3.Text = question.Answer2;
            textBox4.Text = question.Answer3;
            textBox5.Text = question.Answer4;
            comboBox1.SelectedItem = question.Topic;
            comboBox2.SelectedItem = question.Level;

            
            if (question.CorrectAnswer == question.Answer1) radioButton1.Checked = true;
            else if (question.CorrectAnswer == question.Answer2) radioButton2.Checked = true;
            else if (question.CorrectAnswer == question.Answer3) radioButton3.Checked = true;
            else if (question.CorrectAnswer == question.Answer4) radioButton4.Checked = true;
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

            
            string questionText = textBox1.Text;
            string answer1 = textBox2.Text;
            string answer2 = textBox3.Text;
            string answer3 = textBox4.Text;
            string answer4 = textBox5.Text;
            string topic = comboBox1.SelectedItem?.ToString();
            string level = comboBox2.SelectedItem?.ToString();
            string correctAnswer = GetCorrectAnswer();

            if (string.IsNullOrWhiteSpace(questionText) || string.IsNullOrWhiteSpace(correctAnswer))
            {
                MessageBox.Show("אנא מלא את כל השדות ובחר תשובה נכונה.");
                return;
            }

            if (editedQuestion != null)
            {
                
                editedQuestion.QuestionText = questionText;
                editedQuestion.Answer1 = answer1;
                editedQuestion.Answer2 = answer2;
                editedQuestion.Answer3 = answer3;
                editedQuestion.Answer4 = answer4;
                editedQuestion.Topic = topic;
                editedQuestion.Level = level;
                editedQuestion.CorrectAnswer = correctAnswer;

                //await firebaseHelper.UpdateQuestionAsync(editedQuestion);
                var data = new Dictionary<string, object>
    {
        { "QuestionText", editedQuestion.QuestionText },
        { "Answer1", editedQuestion.Answer1 },
        { "Answer2", editedQuestion.Answer2 },
        { "Answer3", editedQuestion.Answer3 },
        { "Answer4", editedQuestion.Answer4 },
        { "Topic", editedQuestion.Topic },
        { "Level", editedQuestion.Level },
        { "CorrectAnswer", editedQuestion.CorrectAnswer },
        { "Type", "MultipleChoice" },
        { "TeacherId", teacherId }
    };
                await firebaseHelper.UpdateQuestionAsync(editedQuestion.Id.ToString(), data);

                MessageBox.Show("השאלה עודכנה בהצלחה!");
            }
            else
            {
                
                await firebaseHelper.AddQuestionAsync("MultipleChoice", correctAnswer, topic, level, questionText, answer1, answer2, answer3, answer4, SessionManager.TeacherId);
                MessageBox.Show("השאלה נשמרה בהצלחה!");
            }
        }

       
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

