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
            StyleWarmButton(btnCreatExam);
            StyleWarmButton(go_back);

            StyleLabel(label4);
            StyleLabel(label2);
            StyleLabel(label3);

            StyleTextBox(txtQuestionCount);
            StyleTextBox(txt_Timer);
            StyleComboBox(cmb_topic);
            StyleComboBox(cmbDifficulty);

            panel1.BackColor = Color.FromArgb(150, Color.White);
            panel1.BorderStyle = BorderStyle.None;
            StyleListBox(listBoxExams);

        }

        private List<Question> allQuestions = new List<Question>();



        private List<Exam> exams = new List<Exam>();


        private async void btnCreatExam_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtQuestionCount.Text, out int questionCount))
            {
                MessageBox.Show("Please enter a valid number of questions.");
                return;
            }

            string difficulty = cmbDifficulty.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(difficulty))
            {
                MessageBox.Show("Please select a difficulty level.");
                return;
            }

            string selectedTopic;

            if (checkBoxRandomTopics.Checked)
            {
                List<string> allTopics = cmb_topic.Items.Cast<string>().ToList();
                if (allTopics.Count == 0)
                {
                    MessageBox.Show("No available topics in the database.");
                    return;
                }

                Random rand = new Random();
                selectedTopic = allTopics[rand.Next(allTopics.Count)];
                MessageBox.Show("Random topic selected:\n" + selectedTopic);
                cmb_topic.SelectedItem = selectedTopic; // visual display
            }
            else
            {
                selectedTopic = cmb_topic.SelectedItem?.ToString();
                if (string.IsNullOrEmpty(selectedTopic))
                {
                    MessageBox.Show("Please select a topic.");
                    return;
                }
            }

            List<string> selectedTypes = checkedListBoxType.CheckedItems.Cast<string>().ToList();
            if (selectedTypes.Count == 0)
            {
                MessageBox.Show("Please select at least one question type.");
                return;
            }

            if (!int.TryParse(txt_Timer.Text, out int examDuration))
            {
                MessageBox.Show("Please enter exam duration in seconds (numbers only).");
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
                MessageBox.Show("Not enough suitable questions in the database.");
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
            MessageBox.Show("Exam created successfully!");
            await firebaseHelper.SaveExamAsync(newExam);
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

            //cmb_topic.Items.Clear();
            //foreach (var topic in topics)
            //    cmb_topic.Items.Add(topic);


            var types = allQuestions
                .Select(q => q.Type)
                .Where(type => !string.IsNullOrWhiteSpace(type))
                .Distinct()
                .ToList();

            checkedListBoxType.Items.Clear();
            foreach (var type in types)
                checkedListBoxType.Items.Add(type);



            var levels = allQuestions
                           .Select(q => q.Level?.Trim())
                           .Where(level => !string.IsNullOrWhiteSpace(level))
                           .Distinct(StringComparer.OrdinalIgnoreCase)
                           .ToList();

            cmbDifficulty.Items.Clear();
            foreach (var level in levels)
                cmbDifficulty.Items.Add(level);

            SetPlaceholder(txtQuestionCount, "Number of questions");
            SetPlaceholder(txt_Timer, "Exam duration");
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
        private void StyleLabel(Label label, bool isTitle = false)
        {
            label.ForeColor = ColorTranslator.FromHtml(isTitle ? "#5C3A21" : "#3E2C23");
            label.BackColor = Color.Transparent;
            label.Font = isTitle
                ? new Font("Segoe UI", 16, FontStyle.Bold)
                : new Font("Segoe UI", 11, FontStyle.Regular);
            label.TextAlign = ContentAlignment.MiddleRight;
            label.RightToLeft = RightToLeft.Yes;
        }

        private void StyleTextBox(TextBox textBox)
        {
            textBox.BorderStyle = BorderStyle.FixedSingle;
            textBox.BackColor = Color.White;
            textBox.ForeColor = ColorTranslator.FromHtml("#3E2C23");
            textBox.Font = new Font("Segoe UI", 10, FontStyle.Regular);
        }
        private void StyleComboBox(ComboBox comboBox)
        {
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.BackColor = Color.White;
            comboBox.ForeColor = ColorTranslator.FromHtml("#3E2C23");
            comboBox.Font = new Font("Segoe UI", 10, FontStyle.Regular);
        }
        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = Color.Gray;

            textBox.GotFocus += (s, e) =>
            {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                }
            };

            textBox.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = Color.Gray;
                }
            };
        }

        private void StyleListBox(ListBox listBox)
        {
            listBox.BorderStyle = BorderStyle.FixedSingle;
            listBox.BackColor = Color.White;
            listBox.ForeColor = ColorTranslator.FromHtml("#3E2C23");
            listBox.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            listBox.ItemHeight = 30;
        }

        private void listBoxExams_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            ListBox listBox = sender as ListBox;
            string text = listBox.Items[e.Index].ToString();

            bool selected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;
            Color backColor = selected ? Color.FromArgb(217, 160, 102) : Color.White;
            Color textColor = selected ? Color.White : Color.FromArgb(62, 44, 35);

            e.Graphics.FillRectangle(new SolidBrush(backColor), e.Bounds);
            TextRenderer.DrawText(e.Graphics, text, new Font("Segoe UI", 10, FontStyle.Bold),
                e.Bounds, textColor, TextFormatFlags.Left | TextFormatFlags.VerticalCenter);

            e.DrawFocusRectangle();
        }

        private void cmb_topic_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbDifficulty_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
