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
    public partial class AdaptiveSelectionForm : Form
    {
        private User user;
        private ExamSelection examSelection;
        private Label label1;
        private Label label2;
        private TextBox numberQuestion;
        private ComboBox typeofQ;
        private Button button2;
        private PictureBox pictureBox1;
        private Button startAdaptiveExamButton;


        public AdaptiveSelectionForm(User user, ExamSelection examSelection)
        {
            InitializeComponent();
            InitializeCustomComponents();

            this.user = user;
            this.examSelection = examSelection;
            this.BackColor = Color.White;
        }

        private async void Clickstart(object sender, EventArgs e)
        {
            String num = numberQuestion.Text;
            String type = typeofQ.Text;
            FirebaseHelper firebaseHelper = new FirebaseHelper();

            if (!int.TryParse(num, out int number) || typeofQ.SelectedItem == null)
            {
                MessageBox.Show("Please enter the number of questions and the topic.");
                return;
            }

            var easyQuestions = await firebaseHelper.GetQuestionsByTopicAndLevelAsync(type, "קל");
            var mediumQuestions = await firebaseHelper.GetQuestionsByTopicAndLevelAsync(type, "בינוני");
            var hardQuestions = await firebaseHelper.GetQuestionsByTopicAndLevelAsync(type, "קשה");

            if (easyQuestions == null || easyQuestions.Count < number || mediumQuestions == null
                || mediumQuestions.Count < number || hardQuestions == null || hardQuestions.Count < number)
            {
                MessageBox.Show("Not enough questions available for the selected topic.");
                return;
            }
            else
            {
                AdaptiveTestForm adaptiveTestForm = new AdaptiveTestForm(user, this, number, easyQuestions, mediumQuestions, hardQuestions, type);
                adaptiveTestForm.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            examSelection.Show();
        }
        private async void startAdaptiveExamButton_Click(object sender, EventArgs e)
        {
            String num = numberQuestion.Text;
            String type = typeofQ.Text;
            FirebaseHelper firebaseHelper = new FirebaseHelper();

            if (!int.TryParse(num, out int number) || typeofQ.SelectedItem == null)
            {
                MessageBox.Show("Please enter the number of questions and the topic.");
                return;
            }

            var easyQuestions = await firebaseHelper.GetQuestionsByTopicAndLevelAsync(type, "קל");
            var mediumQuestions = await firebaseHelper.GetQuestionsByTopicAndLevelAsync(type, "בינוני");
            var hardQuestions = await firebaseHelper.GetQuestionsByTopicAndLevelAsync(type, "קשה");

            if (easyQuestions == null || easyQuestions.Count < number || mediumQuestions == null
                || mediumQuestions.Count < number || hardQuestions == null || hardQuestions.Count < number)
            {
                MessageBox.Show("Not enough questions available for the selected topic.");
                return;
            }
            else
            {
                AdaptiveTestForm adaptiveTestForm = new AdaptiveTestForm(user, this, number, easyQuestions, mediumQuestions, hardQuestions, type);
                adaptiveTestForm.Show();
                this.Hide();
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void InitializeCustomComponents()
        {
            this.BackColor = Color.Bisque;

            // label1
            label1 = new Label();
            label1.Text = "Number of Questions:";
            label1.Location = new Point(100, 80);
            label1.Size = new Size(200, 30);
            label1.Font = new Font("Arial", 12, FontStyle.Bold);
            this.Controls.Add(label1);

            // numberQuestion (TextBox)
            numberQuestion = new TextBox();
            numberQuestion.Location = new Point(320, 80);
            numberQuestion.Size = new Size(200, 30);
            this.Controls.Add(numberQuestion);

            // label2
            label2 = new Label();
            label2.Text = "Select Topic:";
            label2.Location = new Point(100, 130);
            label2.Size = new Size(200, 30);
            label2.Font = new Font("Arial", 12, FontStyle.Bold);
            this.Controls.Add(label2);

            // typeofQ (ComboBox)
            typeofQ = new ComboBox();
            typeofQ.Location = new Point(320, 130);
            typeofQ.Size = new Size(200, 30);
            typeofQ.Items.AddRange(new string[] { "Algorithms", "Databases", "Software Testing" });
            this.Controls.Add(typeofQ);

            // button2 - Back
            button2 = new Button();
            button2.Text = "Back";
            button2.BackColor = Color.PeachPuff;
            button2.Font = new Font("Arial", 10, FontStyle.Bold);
            button2.Location = new Point(150, 250);
            button2.Size = new Size(120, 40);
            button2.Click += button2_Click;
            this.Controls.Add(button2);

            // startAdaptiveExamButton - Start Adaptive Exam
            startAdaptiveExamButton = new Button();
            startAdaptiveExamButton.Text = "Start Adaptive Exam";
            startAdaptiveExamButton.BackColor = Color.White;
            startAdaptiveExamButton.Font = new Font("Arial", 10, FontStyle.Bold);
            startAdaptiveExamButton.Location = new Point(300, 250);
            startAdaptiveExamButton.Size = new Size(180, 40);
            startAdaptiveExamButton.Click += startAdaptiveExamButton_Click;
            this.Controls.Add(startAdaptiveExamButton);

            pictureBox1 = new PictureBox();
            pictureBox1.Location = new Point(550, 80);
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.BackColor = Color.Gray;
            pictureBox1.Click += pictureBox1_Click;
            this.Controls.Add(pictureBox1);
        }

        private void AdaptiveSelectionForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
