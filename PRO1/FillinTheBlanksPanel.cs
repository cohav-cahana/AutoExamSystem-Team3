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
    public partial class FillinTheBlanksPanel : UserControl
    {
        string correctAnswer;
        int numQuestion;
        public FillinTheBlanksPanel(Question question, int numQuestion, int totalQuestions)
        {
            InitializeComponent();
            this.correctAnswer = question.CorrectAnswer;
            this.numQuestion = numQuestion;
            questionLbl.Text = question.QuestionText;
            FitTextToLabel(questionLbl);
            lblQuestionCounter.Text = $"Question {numQuestion + 1} of {totalQuestions}";
            this.BackColor = Color.White;

        }

        private void FitTextToLabel(Label label)
        {
            int minFontSize = 6;
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

        public string GetUserAnswer()
        {
            return answerText.Text.Trim();
        }

        public bool IsAnswered()
        {
            return !string.IsNullOrEmpty(GetUserAnswer());
        }

        public bool IsCorrect()
        {
            return GetUserAnswer().Equals(correctAnswer, StringComparison.OrdinalIgnoreCase);
        }

        private void FillinTheBlanksPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
