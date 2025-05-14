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

namespace AutoExamSystem___
{
    public partial class LecturerForm : Form
    {
        public LecturerForm()
        {
            InitializeComponent();
        }
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
        

        private void btnCreatExam_Click(object sender, EventArgs e)
        {
            int questionCount = int.Parse(txtQuestionCount.Text);
            List<string> selectedTopics = checkedListBoxTopics.CheckedItems.Cast<string>().ToList();
            List<string> allTopics = checkedListBoxTopics.Items.Cast<string>().ToList();

            string difficulty = cmbDifficulty.SelectedItem.ToString();
            if (checkBoxRandomTopics.Checked)
            {
                Random rand = new Random();
                selectedTopics = allTopics.OrderBy(x => rand.Next()).Take(2).ToList();
            }
            else
            {
                selectedTopics = checkedListBoxTopics.CheckedItems.Cast<string>().ToList();
            }

            Exam newExam = new Exam
            {
                Id = Guid.NewGuid().ToString().Substring(0, 6), // מזהה ייחודי קצר
                QuestionCount = questionCount,
                Topics = selectedTopics,
                Difficulty = difficulty
            };

            exams.Add(newExam);
            listBoxExams.Items.Add(newExam);
            MessageBox.Show("המבחן נוצר בהצלחה!");
        }

        private void LecturerForm_Load(object sender, EventArgs e)
        {
            checkedListBoxTopics.Items.Clear();
            checkedListBoxTopics.Items.Add("True/False");
            checkedListBoxTopics.Items.Add("Open Question");
            checkedListBoxTopics.Items.Add("Fill in the Blanks");
            checkedListBoxTopics.Items.Add("Multiple Choice");
            cmbDifficulty.Items.Clear();
            cmbDifficulty.Items.Add("Easy");
            cmbDifficulty.Items.Add("Medium");
            cmbDifficulty.Items.Add("Hard");
        }
    }
    
}
