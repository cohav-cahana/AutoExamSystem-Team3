using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
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
            int centerX = this.ClientSize.Width / 2;

            numberQuestion.Size = new Size(250, 35);
            numberQuestion.Location = new Point(centerX - numberQuestion.Width / 2, 100);
            this.Resize += (s, e) => InitializeCustomComponents();

            typeofQ.Size = new Size(250, 35);
            typeofQ.Location = new Point(centerX - typeofQ.Width / 2, 150);

            SetPlaceholder(numberQuestion, "Number of Questions");
            SetPlaceholder(typeofQ, "Select Topic");

            this.user = user;
            this.examSelection = examSelection;
            this.BackColor = Color.White;
            StyleWarmButton(button2);
            StyleWarmButton(startAdaptiveExamButton);

        }
        private void SetPlaceholder(Control ctrl, string placeholder)
        {
            ctrl.ForeColor = Color.Gray;
            ctrl.Text = placeholder;

            ctrl.GotFocus += (s, e) =>
            {
                if (ctrl.Text == placeholder)
                {
                    ctrl.Text = "";
                    ctrl.ForeColor = Color.Black;
                }
            };

            ctrl.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(ctrl.Text))
                {
                    ctrl.Text = placeholder;
                    ctrl.ForeColor = Color.Gray;
                }
            };
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

            var easyQuestions = await firebaseHelper.GetQuestionsByTopicAndLevelAsync(type, "Easy");
            var mediumQuestions = await firebaseHelper.GetQuestionsByTopicAndLevelAsync(type, "Medium");
            var hardQuestions = await firebaseHelper.GetQuestionsByTopicAndLevelAsync(type, "Hard");

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


        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void InitializeCustomComponents()
        {
            this.BackColor = Color.Bisque;


            // numberQuestion (TextBox)
            numberQuestion = new TextBox();
            numberQuestion.Location = new Point(320, 80);
            numberQuestion.Size = new Size(200, 30);
            this.Controls.Add(numberQuestion);


            // typeofQ (ComboBox)
            typeofQ = new ComboBox();
            typeofQ.Location = new Point(320, 130);
            typeofQ.Size = new Size(200, 30);
            typeofQ.Items.AddRange(new string[] { "Algorithms","Software Testing","Statistics","Data Structures"});
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
        }

        private void AdaptiveSelectionForm_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources._33;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
