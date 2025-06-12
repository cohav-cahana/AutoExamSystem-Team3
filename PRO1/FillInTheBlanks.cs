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
    public partial class FillInTheBlanks : Form
    {
        private string questionKey;
        private string teacherId;
        private Question question;
        public FillInTheBlanks()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            label2.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            label3.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            label4.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            button1.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            button3.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            comboBox1.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            comboBox2.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            textBox1.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            textBox2.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            mainPanel.BackColor = Color.FromArgb(120, Color.White);

            StyleWarmButton(button1);
            StyleWarmButton(button3);






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
            

            this.teacherId = teacherId;  
            this.question = question;     
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

            if (string.IsNullOrWhiteSpace(questionText) ||
        string.IsNullOrWhiteSpace(correctAnswer) ||
        string.IsNullOrWhiteSpace(topic) ||
        string.IsNullOrWhiteSpace(level))
            {
                MessageBox.Show("Please fill in all fields before saving the question", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("The question was updated successfully!");
            }
            else
            {
                
                await firebaseHelper.AddQuestionAsync("FillInTheBlanks", correctAnswer, topic, level, questionText, "", "", "", "", SessionManager.TeacherId);
                MessageBox.Show("The question was saved successfully!");
            }
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
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
        private void StyleWarmButton(Button button)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.BackColor = ColorTranslator.FromHtml("#D9A066");
            button.ForeColor = Color.White;
            button.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#B86F50");
            button.Cursor = Cursors.Hand;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();


            QuestionForm questionForm = new QuestionForm();


            questionForm.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
