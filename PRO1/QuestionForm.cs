using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRO1
{
    public partial class QuestionForm : Form
    {
        string currentTeacherId;
        private BindingList<Question> questionsList;

        public QuestionForm()
        {
            InitializeComponent();
            
            label1.Font = new Font("Arial", 12, FontStyle.Bold);
            label2.Font = new Font("Arial", 12, FontStyle.Bold);


        }


        private async void QuestionForm_Load(object sender, EventArgs e)
        {
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
                    editButtonColumn.HeaderText = "ערוך";
                    editButtonColumn.Text = "ערוך";
                    editButtonColumn.UseColumnTextForButtonValue = true;
                    dataGridView1.Columns.Add(editButtonColumn);
                }

                if (!dataGridView1.Columns.Contains("deleteButton"))
                {
                    DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
                    deleteButtonColumn.Name = "deleteButton";
                    deleteButtonColumn.HeaderText = "מחק";
                    deleteButtonColumn.Text = "מחק";
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
                // פתח טופס עריכה בהתאם לסוג השאלה
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

                // טען מחדש את הטבלה לאחר עריכה
                QuestionForm_Load(sender, e);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

}
