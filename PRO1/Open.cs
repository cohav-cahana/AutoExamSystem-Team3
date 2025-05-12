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
            this.BackgroundImage = Properties.Resources.back2;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }


        public OpenQuestion(Dictionary<string, object> data, string key)
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.back2;
            this.BackgroundImageLayout = ImageLayout.Stretch;

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

            this.Close();
        }

    }
}
