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
        public FillInTheBlanks()
        {
            InitializeComponent();
            this.BackColor = Color.White;

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
            // יצירת אובייקט של FirebaseHelper
            FirebaseHelper firebaseHelper = new FirebaseHelper();

            // קבלת המידע מהטופס
            string questionText = textBox1.Text;  // שאלה
            string correctAnswer = textBox2.Text; // תשובה נכונה
            string topic = comboBox1.SelectedItem?.ToString(); // נושא
            string level = comboBox2.SelectedItem?.ToString(); // רמת קושי

            // שליחה ל-Firebase
            await firebaseHelper.AddQuestionAsync("FillInTheBlanks", correctAnswer, topic, level, questionText, "", "", "", "","");

            // הודעה שהשאלה נשמרה בהצלחה
            MessageBox.Show("השאלה נשמרה בהצלחה!");
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
    }
}
