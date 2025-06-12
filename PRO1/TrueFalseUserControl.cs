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
    public partial class TrueFalseUserControl : UserControl
    {
        string correctAnswer;
        int numQuestion;
        public TrueFalseUserControl(Question question, int numQuestion, int totalQuestions)
        {
            InitializeComponent();
            this.correctAnswer = question.CorrectAnswer;
            this.numQuestion = numQuestion;
            questionLbl.Text = question.QuestionText;
            FitTextToLabel(questionLbl);
            lblQuestionCounter.Text = $"Question {numQuestion + 1} of {totalQuestions}";
            questionPanel.BackColor = Color.FromArgb(120, Color.White);
            questionPanel.BorderStyle = BorderStyle.None;
            //lblQuestionCounter.BackColor = Color.Transparent;
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
        }

        private void uncheckRadioButtons()
        {
            foreach (Control control in this.Controls)
            {
                if (control is RadioButton radioButton)
                {
                    radioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
                }
            }
        }

        private void TrueButton_CheckedChanged(object sender, EventArgs e)
        {
            uncheckRadioButtons();
            TrueButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(101)))), ((int)(((byte)(29)))));
        }

        private void FalseButton_CheckedChanged(object sender, EventArgs e)
        {
            uncheckRadioButtons();
            FalseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(101)))), ((int)(((byte)(29)))));
        }

        public string GetSelectedAnswer()
        {
            if (TrueButton.Checked)
            {
                return TrueButton.Text;
            }
            else if (FalseButton.Checked)
            {
                return FalseButton.Text;
            }
            else
            {
                return null; // No option selected
            }
        }
        public bool IsAnswered()
        {
            return GetSelectedAnswer() != null;
        }

        public bool IsCorrect()
        {
            return GetSelectedAnswer() == correctAnswer;
        }

        private void TrueFalseUserControl_Load(object sender, EventArgs e)
        {

        }

        private void questionPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void questionLbl_Click(object sender, EventArgs e)
        {

        }

        private void lblQuestionCounter_Click(object sender, EventArgs e)
        {

        }
    }
}
