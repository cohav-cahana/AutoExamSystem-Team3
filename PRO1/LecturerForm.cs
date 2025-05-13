using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PRO1;

namespace PRO1
{
    public partial class LecturerForm : Form
    {
        public LecturerForm()
        {
            InitializeComponent();
        }

        private List<Question> allQuestions = new List<Question>();

        public class Exam
        {
            public string Id { get; set; }
            public int QuestionCount { get; set; }
            public List<string> Topics { get; set; }
            public string Difficulty { get; set; }

            public override string ToString()
            {
                return $"מבחן {Id} - {QuestionCount} שאלות, נושא: {string.Join(",", Topics)}, רמה: {Difficulty}";
            }
        }

        private List<Exam> exams = new List<Exam>();


        private async void btnCreatExam_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtQuestionCount.Text, out int questionCount))
            {
                MessageBox.Show("אנא הזיני מספר שאלות תקין");
                return;
            }

            string difficulty = cmbDifficulty.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(difficulty))
            {
                MessageBox.Show("אנא בחרי רמת קושי");
                return;
            }

            List<string> allTopics = checkedListBoxTopics.Items.Cast<string>().ToList();
            List<string> selectedTopics;

            if (checkBoxRandomTopics.Checked)
            {
                Random rand = new Random();
                selectedTopics = allTopics.OrderBy(x => rand.Next()).Take(2).ToList();
            }
            else
            {
                selectedTopics = checkedListBoxTopics.CheckedItems.Cast<string>().ToList();
            }

            List<Question> selectedQuestions = allQuestions
                .Where(q => selectedTopics.Contains(q.Topic) && q.Level == difficulty)
                .OrderBy(q => Guid.NewGuid()) // ערבוב
                .Take(questionCount)
                .ToList();

            if (selectedQuestions.Count < questionCount)
            {
                MessageBox.Show("אין מספיק שאלות מתאימות במסד הנתונים");
                return;
            }

            Exam newExam = new Exam
            {
                Id = Guid.NewGuid().ToString().Substring(0, 6),
                QuestionCount = questionCount,
                Topics = selectedTopics,
                Difficulty = difficulty
            };

            exams.Add(newExam);
            listBoxExams.Items.Add(newExam);

            MessageBox.Show($"המבחן נוצר עם {selectedQuestions.Count} שאלות!");

        }

        private async void LecturerForm_Load(object sender, EventArgs e)
        {
            FirebaseHelper firebaseHelper = new FirebaseHelper();
            allQuestions = await firebaseHelper.GetAllQuestionsAsync();

            var topics = allQuestions
       .Select(q => q.Topic)
       .Where(topic => !string.IsNullOrEmpty(topic))
       .Distinct()
       .ToList();

            checkedListBoxTopics.Items.Clear();
            foreach (var topic in topics)
                checkedListBoxTopics.Items.Add(topic);


            checkedListBoxTopics.Items.Clear();
            checkedListBoxTopics.Items.Add("True/False");
            checkedListBoxTopics.Items.Add("Open Question");
            checkedListBoxTopics.Items.Add("Fill in the Blanks");
            checkedListBoxTopics.Items.Add("Multiple Choice");

            cmbDifficulty.Items.Clear();
            cmbDifficulty.Items.Add("קל");
            cmbDifficulty.Items.Add("בינוני");
            cmbDifficulty.Items.Add("קשה");
        }
    }
    
}
