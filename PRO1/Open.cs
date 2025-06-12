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

            StyleLabel(label1); 
            StyleLabel(label2); 
            StyleLabel(label3); 
            StyleLabel(label4);

            StyleWarmButton(button1); 
            StyleWarmButton(button2);

            panelmain.Paint += panel1_Paint;
            panelmain.BackColor = Color.Transparent;

            button1.MouseEnter += (s, e) => button1.BackColor = ColorTranslator.FromHtml("#B86F50");
            button1.MouseLeave += (s, e) => button1.BackColor = ColorTranslator.FromHtml("#D9A066");

            button2.MouseEnter += (s, e) => button2.BackColor = ColorTranslator.FromHtml("#B86F50");
            button2.MouseLeave += (s, e) => button2.BackColor = ColorTranslator.FromHtml("#D9A066");
  
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.BackColor = Color.White;
            comboBox1.ForeColor = ColorTranslator.FromHtml("#3E2C23");
            comboBox1.Font = new Font("Segoe UI", 10, FontStyle.Regular);

            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.BackColor = Color.White;
            comboBox2.ForeColor = ColorTranslator.FromHtml("#3E2C23");
            comboBox2.Font = new Font("Segoe UI", 10, FontStyle.Regular);
        }
        private void panelMain_Paint(object sender, PaintEventArgs e)
        {
            Color semiTransparentWhite = Color.FromArgb(160, Color.White);
            using (SolidBrush brush = new SolidBrush(semiTransparentWhite))
            {
                e.Graphics.FillRectangle(brush, panelmain.ClientRectangle);
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Color semiTransparentWhite = Color.FromArgb(160, Color.White); 
            using (SolidBrush brush = new SolidBrush(semiTransparentWhite))
            {
                e.Graphics.FillRectangle(brush, panelmain.ClientRectangle);
            }
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
        private void StyleLabel(Label label, bool isTitle = false)
        {
            label.ForeColor = ColorTranslator.FromHtml("#3E2C23");
            label.BackColor = Color.Transparent;
            label.Font = isTitle
                ? new Font("Segoe UI", 16, FontStyle.Bold)
                : new Font("Segoe UI", 11, FontStyle.Regular);
            label.TextAlign = ContentAlignment.MiddleLeft;
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

            if (string.IsNullOrWhiteSpace(questionText) || string.IsNullOrWhiteSpace(correctAnswer) ||
        string.IsNullOrWhiteSpace(topic) || string.IsNullOrWhiteSpace(level))
            {
                MessageBox.Show("Please fill in all fields before saving the question", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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
                MessageBox.Show("The question was updated successfully!");
            }
            else
            {
                await firebaseHelper.AddQuestionAsync("OpenQuestion", correctAnswer, topic, level, questionText, "", "", "", "", SessionManager.TeacherId);
                MessageBox.Show("The question was saved successfully!");
            }

            
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
