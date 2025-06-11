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
    public partial class OpenQuestion : Form
    {
        private string questionKey;
        private Dictionary<string, object> originalData;
        private bool isEditMode = false;

        public OpenQuestion()
        {
            InitializeComponent();
            label4.Font = new Font("Arial", 18, FontStyle.Bold);
            label1.Font = new Font("Arial", 18, FontStyle.Bold);
            label3.Font = new Font("Arial", 18, FontStyle.Bold);
            label2.Font = new Font("Arial", 18, FontStyle.Bold);

        }
        public OpenQuestion(Question selectedQuestion)
        {
            InitializeComponent();

            questionKey = selectedQuestion.Id; 
            originalData = new Dictionary<string, object>()
    {
        { "QuestionText", selectedQuestion.QuestionText },
        { "CorrectAnswer", selectedQuestion.CorrectAnswer },
        { "Topic", selectedQuestion.Topic },
        { "Level", selectedQuestion.Level },
        { "Type", "OpenQuestion" }
    };

            isEditMode = true;

            textBox1.Text = selectedQuestion.QuestionText;
            textBox2.Text = selectedQuestion.CorrectAnswer;
            comboBox1.SelectedItem = selectedQuestion.Topic;
            comboBox2.SelectedItem = selectedQuestion.Level;
        }




        public OpenQuestion(Dictionary<string, object> data, string key)
        {
            InitializeComponent();
            

            questionKey = key;
            originalData = data;
            isEditMode = true;

            textBox1.Text = data.ContainsKey("QuestionText") ? data["QuestionText"].ToString() : "";
            textBox2.Text = data.ContainsKey("CorrectAnswer") ? data["CorrectAnswer"].ToString() : "";
            comboBox1.SelectedItem = data.ContainsKey("Topic") ? data["Topic"].ToString() : null;
            comboBox2.SelectedItem = data.ContainsKey("Level") ? data["Level"].ToString() : null;
        }


        private void OpenQuestion_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();


            QuestionForm questionForm = new QuestionForm();


            questionForm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            FirebaseHelper firebaseHelper = new FirebaseHelper();

            string questionText = textBox1.Text;
            string correctAnswer = textBox2.Text;
            string topic = comboBox1.SelectedItem?.ToString();
            string level = comboBox2.SelectedItem?.ToString();

            if (isEditMode)
            {
                Dictionary<string, object> updatedData = new Dictionary<string, object>()
        {
                     { "Id", questionKey },
            { "QuestionText", questionText },
            { "CorrectAnswer", correctAnswer },
            { "Topic", topic },
            { "Level", level },
            { "Type", "OpenQuestion" },
            { "Answer1", "" },
            { "Answer2", "" },
            { "Answer3", "" },
            { "Answer4", "" }
        };

                await firebaseHelper.UpdateQuestionAsync(questionKey, updatedData);
                MessageBox.Show("השאלה הפתוחה עודכנה בהצלחה!");
            }
            else
            {
                await firebaseHelper.AddQuestionAsync("OpenQuestion", correctAnswer, topic, level, questionText, "", "", "", "");
                MessageBox.Show("השאלה הפתוחה נשמרה בהצלחה!");
            }

        }

    }
}
