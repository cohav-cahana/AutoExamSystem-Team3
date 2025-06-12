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
    public partial class MultipleChoiceUserControl : UserControl
    {
        private List<string> options = new List<string>();
        string correctAnswer;
        int numQuestion;
        public MultipleChoiceUserControl(Question question, int numQuestion, int totalQuestions)
        {
            InitializeComponent();
            this.numQuestion = numQuestion;
            options.Add(question.Answer1);
            options.Add(question.Answer2);
            options.Add(question.Answer3);
            options.Add(question.Answer4);
            this.correctAnswer = question.CorrectAnswer;
            questionLbl.Text = question.QuestionText;
            FitTextToLabel(questionLbl);
            lblQuestionCounter.Text = $"Question {numQuestion + 1} of {totalQuestions}";

            var shuffledOptions = ShuffleOptions(options);
            radioButton1.Text = shuffledOptions[0];
            radioButton2.Text = shuffledOptions[1];
            radioButton3.Text = shuffledOptions[2];
            radioButton4.Text = shuffledOptions[3];
            panel1.BackColor = Color.FromArgb(120, Color.White); // שקיפות עדינה
            panel1.BorderStyle = BorderStyle.None;
            lblQuestionCounter.BackColor = Color.FromArgb(120, Color.White);

        }

        private void FitTextToLabel(Label label)
        {
            int minFontSize = 12;
            int maxFontSize = label.Font.Size > 20 ? (int)label.Font.Size : 20;
            Size proposedSize = label.Size;

            using (Graphics g = label.CreateGraphics())
            {
                for (int fontSize = maxFontSize; fontSize >= minFontSize; fontSize--)
                {
                    Font testFont = new Font(label.Font.FontFamily, fontSize, label.Font.Style);
                    SizeF textSize = g.MeasureString(label.Text, testFont);
                    if (textSize.Width <= proposedSize.Width && textSize.Height <= proposedSize.Height)
                    {
                        label.Font = testFont;
                        break;
                    }
                }
            }
            questionPanel.BackColor = Color.FromArgb(120, Color.White); // שקיפות עדינה
            questionPanel.BorderStyle = BorderStyle.None;

        }
        private List<string> ShuffleOptions(List<string> options)
        {
            Random rng = new Random();
            return options.OrderBy(x => rng.Next()).ToList();
        }

        private void uncheckRadioButtons()
        {
            foreach (Control control in this.Controls)
            {
                if (control is RadioButton radioButton)
                {
                    radioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0))))); ;
                }
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.uncheckRadioButtons();
            radioButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(101)))), ((int)(((byte)(29)))));
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.uncheckRadioButtons();
            radioButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(101)))), ((int)(((byte)(29)))));
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.uncheckRadioButtons();
            radioButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(101)))), ((int)(((byte)(29)))));
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            this.uncheckRadioButtons();
            radioButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(101)))), ((int)(((byte)(29)))));
        }

        public string GetSelectedAnswer()
        {
            if (radioButton1.Checked) return radioButton1.Text;
            if (radioButton2.Checked) return radioButton2.Text;
            if (radioButton3.Checked) return radioButton3.Text;
            if (radioButton4.Checked) return radioButton4.Text;
            return null;
        }
        public bool IsAnswered()
        {
            return GetSelectedAnswer() != null;
        }

        public bool IsCorrect()
        {
            return GetSelectedAnswer() == correctAnswer;
        }

        private void MultipleChoiceUserControl_Load(object sender, EventArgs e)
        {

        }

        private void questionLbl_Click(object sender, EventArgs e)
        {

        }

        private void lblQuestionCounter_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
