using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Bibliography;
//using DocumentFormat.OpenXml.Office.SpreadSheetML.Y2023.MsForms;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using DocumentFormat.OpenXml.Packaging;

namespace PRO1

{

    public partial class AdaptiveTestForm : Form
    {
        private int timeLeftInSeconds;
        int count;
        private User currentUser;
        private int questionCounter = 0;
        private int correctAnswers = 0;
        private int totalQuestions;
        private String topic;
        private AdaptiveSelectionForm examSelection;
        private List<Question> easy = new List<Question>();
        private List<Question> medium = new List<Question>();
        private List<Question> hard = new List<Question>();
        private List<Question> allQuestions = new List<Question>();
        public AdaptiveTestForm(User user, AdaptiveSelectionForm examSelection, int totalQuestions, List<Question> easy, List<Question> medium,
            List<Question> hard, String topic)
        {
            InitializeComponent();
            this.examSelection = examSelection;
            this.currentUser = user;
            this.timeLeftInSeconds = 30 * totalQuestions;
            lblTimer.Text = FormatTime(timeLeftInSeconds);
            this.totalQuestions = totalQuestions;
            this.easy = easy;
            this.medium = medium;
            this.hard = hard;
            this.topic = topic;
            StyleWarmButton(examStartBtn);
            StyleWarmButton(nextBtn);

            int[] options = { 2, 3, 6 };
            Random random = new Random();
            count = options[random.Next(options.Length)];
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
                AdaptiveExam exam = new AdaptiveExam
                {
                    Id = Guid.NewGuid().ToString().Substring(0, 6),
                    QuestionCount = totalQuestions,
                    Topics = new List<string> { topic },
                    DurationInSeconds = 30 * totalQuestions,
                    Questions = allQuestions,
                };
                ExamResult result = new ExamResult
                {
                    UserId = currentUser.UserId,
                    ExamId = exam.Id,
                    Grade = score,
                    TakenAt = DateTime.Now,
                    IsAdaptive = true
                };
                FirebaseHelper firebaseHelper = new FirebaseHelper();
                await firebaseHelper.SaveAdaptiveExamAsync(exam);
                await firebaseHelper.SaveExamResultAsync(result);
                MessageBox.Show("Time is up!\nYour Grade Is: " + score + "\nThe test will now close.", "Time Expired", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Close the test form
            }
            else
            {
                if (timeLeftInSeconds <= 10)
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
            FirebaseHelper firebase = new FirebaseHelper();
            Question question = new Question();

            Question currentQuestion = pullNextQuestion();
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
                if (!mc.IsAnswered())
                {
                    MessageBox.Show("Please answer the question before proceeding.");
                    return;
                }
                if (mc.IsCorrect())
                {
                    correctAnswers++;
                    if (count < 8)
                        count++;
                }
                else if (count > 0)
                    count--;
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
                    if (count < 8)
                        count++;
                }
                else if (count > 0)
                    count--;
            }
            if (panel1.Controls[0] is FillinTheBlanksPanel fb)
            {
                if (!fb.IsAnswered())
                {
                    MessageBox.Show("Please answer the question before proceeding.");
                    return;
                }
                if (fb.IsCorrect())
                {
                    correctAnswers++;
                    if (count < 8)
                        count++;
                }
                else if (count > 0)
                    count--;
            }
            if (panel1.Controls[0] is OpenQuestionUserControl oq)
            {
                if (!oq.IsAnswered())
                {
                    MessageBox.Show("Please answer the question before proceeding.");
                    return;
                }
                if (oq.IsCorrect())
                {
                    correctAnswers++;
                    if (count < 8)
                        count++;
                }
                else if (count > 0)
                    count--;
            }
            questionCounter++;
            if (questionCounter < totalQuestions)
            {
                LoadQuestion();
            }
            else
            {
                examTimer.Stop();
                float score = (correctAnswers * 100) / totalQuestions;
                AdaptiveExam exam = new AdaptiveExam
                {
                    Id = Guid.NewGuid().ToString().Substring(0, 6),
                    QuestionCount = totalQuestions,
                    Topics = new List<string> { topic },
                    DurationInSeconds = 30 * totalQuestions,
                    Questions = allQuestions,
                };
                ExamResult result = new ExamResult
                {
                    UserId = currentUser.UserId,
                    ExamId = Guid.NewGuid().ToString().Substring(0, 6),
                    Grade = score,
                    TakenAt = DateTime.Now,
                    IsAdaptive = true
                };
                FirebaseHelper firebaseHelper = new FirebaseHelper();
                await firebaseHelper.SaveAdaptiveExamAsync(exam);
                await firebaseHelper.SaveExamResultAsync(result);
                MessageBox.Show("Exam Completed!\nYour Grade Is: " + score);
                examSelection.Show();
                this.Close(); // Close the test form
            }
        }

        public Question pullNextQuestion()
        {
            Random random = new Random();
            if (count <= 2)
            {
                if (easy.Count > 0)
                {
                    int index = random.Next(easy.Count); // בוחר אינדקס רנדומלי
                    Question randomQuestion = easy[index]; // לוקח את האיבר
                    easy.RemoveAt(index); // מוחק את האיבר מהרשימה
                    allQuestions.Add(randomQuestion); // מוסיף את השאלה לרשימת כל השאלות
                    return randomQuestion;
                }
            }
            else if (count <= 4)
            {
                if (medium.Count > 0)
                {
                    int index = random.Next(medium.Count); // בוחר אינדקס רנדומלי
                    Question randomQuestion = medium[index]; // לוקח את האיבר
                    medium.RemoveAt(index); // מוחק את האיבר מהרשימה
                    allQuestions.Add(randomQuestion); // מוסיף את השאלה לרשימת כל השאלות
                    return randomQuestion;
                }
            }
            else
            {
                if (hard.Count > 0)
                {
                    int index = random.Next(hard.Count); // בוחר אינדקס רנדומלי
                    Question randomQuestion = hard[index]; // לוקח את האיבר
                    hard.RemoveAt(index); // מוחק את האיבר מהרשימה
                    allQuestions.Add(randomQuestion); // מוסיף את השאלה לרשימת כל השאלות
                    return randomQuestion;
                }
            }
            return null; // No more questions available
        }
        private void StyleWarmButton(Button button)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.BackColor = ColorTranslator.FromHtml("#D9A066"); // חום בהיר
            button.ForeColor = Color.White;
            button.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#B86F50"); // חום כהה יותר בהובר
            button.Cursor = Cursors.Hand;
        }
        private void AdaptiveTestForm_Load(object sender, EventArgs e)
        {

        }
    }
}