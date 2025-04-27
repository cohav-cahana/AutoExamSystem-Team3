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
        public QuestionForm()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile(@"C:\Users\maimo\source\repos\HM2\HM2\Images\back2.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void QuestionForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // בודקים איזו אפשרות נבחרה מתוך ה-ComboBox
            if (comboBox1.SelectedIndex == 0) // אם הבחירה הראשונה
            {
                // פותחים את ה-Form של MultipleChoice
                MultipleChoice multipleChoiceForm = new MultipleChoice();
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


    }
    
}
