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
    public partial class TestForm : Form
    {
        private int timeLeftInSeconds;
        private User currentUser;
        private Exam currentExam;
        private int questionCounter = 0;
        private int correctAnswers = 0;
        private int totalQuestions;
        private ExamSelection examSelection;
        public TestForm(User user, Exam exam, ExamSelection examSelection)
        {
            InitializeComponent();
            this.examSelection = examSelection;
            timeLeftInSeconds = exam.DurationInSeconds;
            this.currentUser = user;
            this.currentExam = exam;
            this.totalQuestions = exam.QuestionCount;
            lblTimer.Text = FormatTime(timeLeftInSeconds);
            this.BackgroundImage = Properties.Resources.jeffrey;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        public static string FormatTime(int seconds)
        {
            int mins = seconds / 60;
            int secs = seconds % 60;
            return $"{mins:D2}:{secs:D2}";
        }

        private async void examTimer_Tick(object sender, EventArgs e)
        {
            timeLeftInSeconds--;

            if (timeLeftInSeconds <= 0)
            {
                examTimer.Stop();
                float score = (correctAnswers * 100) / totalQuestions;
                ExamResult result = new ExamResult
                {
                    UserId = currentUser.UserId,
                    ExamId = currentExam.Id,
                    Grade = score,
                    TakenAt = DateTime.Now
                };
                FirebaseHelper firebaseHelper = new FirebaseHelper();
                await firebaseHelper.SaveExamResultAsync(result);
                MessageBox.Show("Time is up!\nYour Grade Is: " + score +"\nThe test will now close.", "Time Expired", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Close the test form
            }
            else
            {
                if(timeLeftInSeconds <= 10)
                {
                    lblTimer.ForeColor = Color.LightPink; // Change color to red when time is low
                    lblTimer.BackColor = Color.Red;
                }
                else
                {
                    lblTimer.ForeColor = Color.LightGreen;
                    lblTimer.BackColor = Color.ForestGreen;
                }
                lblTimer.Text = FormatTime(timeLeftInSeconds);
            }
        }

        private void StartExam()
        {
            examTimer.Start();
            if (questionCounter < totalQuestions)
            {
                LoadQuestion();
            }
            else
            {
                MessageBox.Show("Exam Completed!");
                this.Close(); // Close the test form
            }
        }

        private void LoadQuestion()
        {
            panel1.Controls.Clear();

            Question currentQuestion = currentExam.Questions[questionCounter];
            UserControl control = null;

            if (currentQuestion.Type == "FillInTheBlanks")
            {
                control = new FillinTheBlanksPanel(currentQuestion, questionCounter, totalQuestions);
            }
            else if (currentQuestion.Type == "MultipleChoice")
            {
                control = new MultipleChoiceUserControl(currentQuestion, questionCounter, totalQuestions);
            }
            else if (currentQuestion.Type == "TrueFalse")
            {
                control = new TrueFalseUserControl(currentQuestion, questionCounter, totalQuestions);
            }
            else if (currentQuestion.Type == "OpenQuestion")
            {
                control = new OpenQuestionUserControl(currentQuestion, questionCounter, totalQuestions);
            }
            else
            {
                MessageBox.Show("Unknown question type.");
                return;
            }

            // Center the control in the panel
            control.Location = new Point(
                (panel1.Width - control.Width) / 2,
                (panel1.Height - control.Height) / 2
            );
            control.Anchor = AnchorStyles.None;

            panel1.Controls.Add(control);
        }

        private void examStartBtn_Click(object sender, EventArgs e)
        {
            examStartBtn.Visible = false;
            nextBtn.Visible = true;
            StartExam();
        }

        private async void nextBtn_Click(object sender, EventArgs e)
        {
            if (panel1.Controls[0] is MultipleChoiceUserControl mc)
            {
                if(!mc.IsAnswered())
                {
                    MessageBox.Show("Please answer the question before proceeding.");
                    return;
                }
                if(mc.IsCorrect())
                {
                    correctAnswers++;
                }
            }
            if (panel1.Controls[0] is TrueFalseUserControl tf)
            {
                if (!tf.IsAnswered())
                {
                    MessageBox.Show("Please answer the question before proceeding.");
                    return;
                }
                if (tf.IsCorrect())
                {
                    correctAnswers++;
                }
            }
            if(panel1.Controls[0] is FillinTheBlanksPanel fb)
            {
                if (!fb.IsAnswered())
                {
                    MessageBox.Show("Please answer the question before proceeding.");
                    return;
                }
                if (fb.IsCorrect())
                {
                    correctAnswers++;
                }
            }
            if(panel1.Controls[0] is OpenQuestionUserControl oq)
            {
                if (!oq.IsAnswered())
                {
                    MessageBox.Show("Please answer the question before proceeding.");
                    return;
                }
                if (oq.IsCorrect())
                {
                    correctAnswers++;
                }
            }
            questionCounter++;
            if (questionCounter < totalQuestions)
            {
                LoadQuestion();
            }
            else
            {
                float score = (correctAnswers * 100) / totalQuestions;
                ExamResult result = new ExamResult
                {
                    UserId = currentUser.UserId,
                    ExamId = currentExam.Id,
                    Grade = score,
                    TakenAt = DateTime.Now
                };
                FirebaseHelper firebaseHelper = new FirebaseHelper();
                await firebaseHelper.SaveExamResultAsync(result);
                MessageBox.Show("Exam Completed!\nYour Grade Is: " + score);
                examSelection.Show();
                this.Close(); // Close the test form
            }
        }

        private void TestForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
