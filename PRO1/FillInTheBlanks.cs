using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PRO1
{
    public partial class FillInTheBlanks : Form
    {
        private string questionKey;
        private string teacherId;
        private Question question;
        public FillInTheBlanks()
        {
            InitializeComponent();
            this.BackColor = Color.White;

        }
        public FillInTheBlanks(Question question) : this(SessionManager.TeacherId, question)
        {
            

        }

        public FillInTheBlanks(string teacherId) : this()
        {

            this.teacherId = teacherId;
        }

        public FillInTheBlanks(string teacherId, Question question) : this(teacherId)
        {
            

            this.teacherId = teacherId;   // ודא שמקצה גם את teacherId
            this.question = question;     // שומר את השאלה לעריכה
            questionKey = question.Id;
            textBox1.Text = question.QuestionText;
            textBox2.Text = question.CorrectAnswer;
            comboBox1.SelectedItem = question.Topic;
            comboBox2.SelectedItem = question.Level;

        }

        private void FillInTheBlanks_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
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

        private async void button1_Click(object sender, EventArgs e)
        {
            FirebaseHelper firebaseHelper = new FirebaseHelper();

            string questionText = textBox1.Text;
            string correctAnswer = textBox2.Text;
            string topic = comboBox1.SelectedItem?.ToString();
            string level = comboBox2.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(questionText) || string.IsNullOrWhiteSpace(correctAnswer))
            {
                MessageBox.Show("אנא מלא את כל השדות הדרושים.");
                return;
            }

            if (question != null)
            {
                question.QuestionText = questionText;
                question.CorrectAnswer = correctAnswer;
                question.Topic = topic;
                question.Level = level;

                var data = new Dictionary<string, object>
        {
                     { "Id", questionKey },
            { "QuestionText", question.QuestionText },
            { "CorrectAnswer", question.CorrectAnswer },
            { "Topic", question.Topic },
            { "Level", question.Level },
            { "Type", "FillInTheBlanks" },
            { "TeacherId", teacherId }
        };

                await firebaseHelper.UpdateQuestionAsync(question.Id.ToString(), data);
                MessageBox.Show("השאלה עודכנה בהצלחה!");
            }
            else
            {
                // יצירת שאלה חדשה
                await firebaseHelper.AddQuestionAsync("FillInTheBlanks", correctAnswer, topic, level, questionText, "", "", "", "", SessionManager.TeacherId);
                MessageBox.Show("השאלה נשמרה בהצלחה!");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();


            QuestionForm questionForm = new QuestionForm();


            questionForm.Show();
        }
    }
}
