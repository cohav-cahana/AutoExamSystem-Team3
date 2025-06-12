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
    public partial class QuestionForm : Form
    {
        string currentTeacherId;
        private BindingList<Question> questionsList;
        private Question editingQuestion = null;
        private string teacherId;
        private FirebaseHelper firebaseHelper = new FirebaseHelper();

        public QuestionForm()
        {
            InitializeComponent();
            
            label1.Font = new Font("Arial", 12, FontStyle.Bold);
            label2.Font = new Font("Arial", 12, FontStyle.Bold);
            panelMain.Paint += panelMain_Paint;
            panelMain.BackColor = Color.Transparent;
            StyleWarmButton(button2);
            StyleLabel(label2, true);  
            StyleLabel(label1);

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.BackColor = Color.White;
            comboBox1.ForeColor = ColorTranslator.FromHtml("#3E2C23");
            comboBox1.Font = new Font("Segoe UI", 10, FontStyle.Regular);

            StyleDataGridView(dataGridView1);

        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {
            Color semiTransparentWhite = Color.FromArgb(160, Color.White);
            using (SolidBrush brush = new SolidBrush(semiTransparentWhite))
            {
                e.Graphics.FillRectangle(brush, panelMain.ClientRectangle);
            }
        }
        private void StyleLabel(Label label, bool isTitle = false)
        {
            label.ForeColor = ColorTranslator.FromHtml("#3E2C23");
            label.BackColor = Color.Transparent;
            label.Font = isTitle
                ? new Font("Segoe UI", 16, FontStyle.Bold)
                : new Font("Segoe UI", 11, FontStyle.Regular);
            label.TextAlign = ContentAlignment.MiddleLeft;
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
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "deleteButton")
            {
                DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                cell.Style.BackColor = Color.FromArgb(220, 80, 80); // אדום בהיר
                cell.Style.ForeColor = Color.White;
                cell.Style.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            }

            if (dataGridView1.Columns[e.ColumnIndex].Name == "editButton")
            {
                DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                cell.Style.BackColor = Color.FromArgb(230, 230, 230); // אפור בהיר
                cell.Style.ForeColor = Color.Black;
                cell.Style.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            }
        }
        private async void QuestionForm_Load(object sender, EventArgs e)
        {
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            FirebaseHelper firebaseHelper = new FirebaseHelper();
            this.currentTeacherId = SessionManager.TeacherId;

            try
            {
                List<Question> questions = await firebaseHelper.GetQuestionsByTeacherIdAsync(currentTeacherId);
                questionsList = new BindingList<Question>(questions);
                dataGridView1.DataSource = questionsList;

                // רק אם עדיין לא נוספו הכפתורים:
                if (!dataGridView1.Columns.Contains("editButton"))
                {
                    DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
                    editButtonColumn.Name = "editButton";
                    editButtonColumn.HeaderText = "Edit";
                    editButtonColumn.Text = "Edit";
                    editButtonColumn.UseColumnTextForButtonValue = true;
                    dataGridView1.Columns.Add(editButtonColumn);
                }

                if (!dataGridView1.Columns.Contains("deleteButton"))
                {
                    DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
                    deleteButtonColumn.Name = "deleteButton";
                    deleteButtonColumn.HeaderText = "Delete";
                    deleteButtonColumn.Text = "Delete";
                    deleteButtonColumn.UseColumnTextForButtonValue = true;
                    dataGridView1.Columns.Add(deleteButtonColumn);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה בטעינת שאלות: " + ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Hide();

            // בודקים איזו אפשרות נבחרה מתוך ה-ComboBox
            if (comboBox1.SelectedIndex == 0) // אם הבחירה הראשונה
            {
                // פותחים את ה-Form של MultipleChoice
                MultipleChoice multipleChoiceForm = new MultipleChoice(currentTeacherId);
                multipleChoiceForm.ShowDialog();

            }
            else if (comboBox1.SelectedIndex == 1) // אם הבחירה השנייה
            {
                // פותחים את ה-Form של OpenQuestion
                OpenQuestion openQuestionForm = new OpenQuestion();
                openQuestionForm.ShowDialog();
            }
            else if (comboBox1.SelectedIndex == 2) // אם הבחירה השלישית
            {
                // פותחים את ה-Form של TrueFalse
                TrueFalse trueFalseForm = new TrueFalse();
                trueFalseForm.ShowDialog();
            }
            else if (comboBox1.SelectedIndex == 3) // אם הבחירה הרביעית
            {
                // פותחים את ה-Form של FillInTheBlanks
                FillInTheBlanks fillInTheBlanksForm = new FillInTheBlanks();
                fillInTheBlanksForm.ShowDialog();
            }
        }
        private void StyleDataGridView(DataGridView dgv)
        {
            dgv.BorderStyle = BorderStyle.None;
            dgv.BackgroundColor = Color.White;
            dgv.EnableHeadersVisualStyles = false;
            dgv.GridColor = Color.LightGray;

            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(217, 160, 102); // חום בהיר
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;

            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#3E2C23");
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(230, 215, 200);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.ColumnHeadersHeight = 35;

            dgv.RowTemplate.Height = 30;
            dgv.AllowUserToAddRows = false;
            dgv.RowHeadersVisible = false;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();


            Form1 form = new Form1();


            form.Show();
        }

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var selectedQuestion = dataGridView1.Rows[e.RowIndex].DataBoundItem as Question;

            if (dataGridView1.Columns[e.ColumnIndex].Name == "deleteButton")
            {
                var confirm = MessageBox.Show("האם אתה בטוח שברצונך למחוק את השאלה?", "אישור מחיקה", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    FirebaseHelper firebaseHelper = new FirebaseHelper();

                    try
                    {
                        await firebaseHelper.DeleteQuestionAsync(selectedQuestion.Id);
                        questionsList.Remove(selectedQuestion);  // <-- זה מעדכן אוטומטית את ה־DataGridView
                        MessageBox.Show("השאלה נמחקה בהצלחה.");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("שגיאה במחיקה: " + ex.Message);
                    }
                }
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "editButton")
            {
                switch (selectedQuestion.Type)
                {
                    case "MultipleChoice":
                        MultipleChoice editMC = new MultipleChoice(currentTeacherId, selectedQuestion);
                        editMC.ShowDialog();
                        break;

                    case "OpenQuestion":
                        OpenQuestion editOpen = new OpenQuestion(selectedQuestion);
                        editOpen.ShowDialog();
                        break;

                    case "TrueFalse":
                        TrueFalse editTF = new TrueFalse(selectedQuestion);
                        editTF.ShowDialog();
                        break;

                    case "FillInTheBlanks":
                        FillInTheBlanks editFill = new FillInTheBlanks(selectedQuestion);
                        editFill.ShowDialog();
                        break;

                    default:
                        MessageBox.Show("סוג שאלה לא נתמך לעריכה.");
                        break;
                }

                QuestionForm_Load(sender, e);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

}
