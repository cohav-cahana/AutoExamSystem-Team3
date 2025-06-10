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
        string currentTeacherId = "123456789";
        public QuestionForm()
        {
            InitializeComponent();
            
            label1.Font = new Font("Arial", 12, FontStyle.Bold);

        }


        private async void QuestionForm_Load(object sender, EventArgs e)
        {
            FirebaseHelper firebaseHelper = new FirebaseHelper();
            string currentTeacherId = "123456789"; // ת"ז המרצה המחובר

            try
            {
                List<Question> questions = await firebaseHelper.GetQuestionsByTeacherIdAsync(currentTeacherId);
                //dataGridView1.DataSource = questions;
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
            
        }

    }

}
