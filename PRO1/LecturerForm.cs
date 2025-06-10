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
        private FirebaseHelper firebaseHelper = new FirebaseHelper();

        public LecturerForm()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            label4.Font = new Font("Arial", 12, FontStyle.Bold);
            label1.Font = new Font("Arial", 12, FontStyle.Bold);
            label2.Font = new Font("Arial", 12, FontStyle.Bold);
            label3.Font = new Font("Arial", 12, FontStyle.Bold);
            label5.Font = new Font("Arial", 12, FontStyle.Bold);


        }

        private List<Question> allQuestions = new List<Question>();

      

        private List<Exam> exams = new List<Exam>();


        private async void btnCreatExam_Click(object sender, EventArgs e)
        {
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

                string selectedTopic;

                if (checkBoxRandomTopics.Checked)
                {
                    List<string> allTopics = cmb_topic.Items.Cast<string>().ToList();
                    if (allTopics.Count == 0)
                    {
                        MessageBox.Show("אין נושאים זמינים במסד הנתונים");
                        return;
                    }

                    Random rand = new Random();
                    selectedTopic = allTopics[rand.Next(allTopics.Count)];
                    MessageBox.Show("נבחר נושא אקראי:\n" + selectedTopic);
                    cmb_topic.SelectedItem = selectedTopic; // תצוגה ויזואלית
                }
                else
                {
                    selectedTopic = cmb_topic.SelectedItem?.ToString();
                    if (string.IsNullOrEmpty(selectedTopic))
                    {
                        MessageBox.Show("אנא בחרי נושא");
                        return;
                    }
                }

                List<string> selectedTypes = checkedListBoxType.CheckedItems.Cast<string>().ToList();
                if (selectedTypes.Count == 0)
                {
                    MessageBox.Show("אנא בחרי לפחות סוג שאלה אחד");
                    return;
                }

                if (!int.TryParse(txt_Timer.Text, out int examDuration))
                {
                    MessageBox.Show("אנא הזיני זמן בשניות (מספר בלבד)");
                    return;
                }

                List<Question> selectedQuestions = allQuestions
                    .Where(q =>
                        q.Topic?.Trim() == selectedTopic.Trim() &&
                        selectedTypes.Any(t => t.Trim() == q.Type?.Trim()) &&
                        string.Equals(q.Level?.Trim(), difficulty.Trim(), StringComparison.OrdinalIgnoreCase)
                    )
                    .OrderBy(q => Guid.NewGuid())
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
                    Topics = new List<string> { selectedTopic },
                    Difficulty = difficulty,
                    DurationInSeconds = examDuration,
                    Questions = selectedQuestions
                };

                exams.Add(newExam);
                listBoxExams.Items.Add(newExam);
                MessageBox.Show("המבחן נוצר בהצלחה!");
                await firebaseHelper.SaveExamAsync(newExam);
            }
        }

        private async void LecturerForm_Load(object sender, EventArgs e)
        {
            FirebaseHelper firebaseHelper = new FirebaseHelper();
            allQuestions = await firebaseHelper.GetAllQuestionsAsync();

            var topics = allQuestions
                .Select(q => q.Topic)
                .Where(topic => !string.IsNullOrWhiteSpace(topic))
                .Distinct()
                .ToList();

            cmb_topic.Items.Clear();
            foreach (var topic in topics)
                cmb_topic.Items.Add(topic);


            var types = allQuestions
                .Select(q => q.Type)
                .Where(type => !string.IsNullOrWhiteSpace(type))
                .Distinct()
                .ToList();

            checkedListBoxType.Items.Clear();
            foreach (var type in types)
                checkedListBoxType.Items.Add(type);



            var levels = allQuestions
                           .Select(q => q.Level)
                           .Where(level => !string.IsNullOrWhiteSpace(level))
                           .Distinct()
                           .ToList();

            cmbDifficulty.Items.Clear();
            foreach (var level in levels)
                cmbDifficulty.Items.Add(level);
        }


        private void listBoxExams_SelectedIndexChanged(object sender, EventArgs e)
        {

         }
        private void go_back_Click(object sender, EventArgs e)
        {
            Form1 go_back1 = new Form1();
            go_back1.Show();
            this.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            form1.Show();
            this.Close();

        }
    }

}
