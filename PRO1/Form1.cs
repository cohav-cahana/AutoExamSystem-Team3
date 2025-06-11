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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.White;

            labelWelcome.Font = new Font("Arial", 18, FontStyle.Bold);
            button1.Font= new Font("Arial", 12, FontStyle.Bold);
            button2.Font = new Font("Arial", 12, FontStyle.Bold);
            button3.Font = new Font("Arial", 8, FontStyle.Bold);
            button4.Font = new Font("Arial", 8, FontStyle.Bold);

            StyleLinenButton(btn_showExam);
            StyleLinenButton(button1);
            StyleLinenButton(button2);
            StyleLinenButton(button3);
            StyleLinenButton(button4);
            StyleTitleLabel(label1);

      


        }
        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            QuestionForm questionForm = new QuestionForm();
            questionForm.ShowDialog();  
            
        }
        private void StyleTitleLabel(Label label)
        {
            label.BackColor = Color.Transparent; 
            label.ForeColor = ColorTranslator.FromHtml("#3E2C23"); 
            label.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            label.TextAlign = ContentAlignment.MiddleCenter;
        }
        private void StyleLinenButton(Button button)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.BackColor = Color.Linen;
            button.ForeColor = ColorTranslator.FromHtml("#3E2C23");
            button.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            button.FlatAppearance.BorderSize = 0; // <--- בלי מסגרת
            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 239, 213); // Peach-like hover
            button.Cursor = Cursors.Hand;
            button.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelWelcome.Text = "Welcome  " + SessionManager.Username;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LecturerForm CreateExam = new LecturerForm();
            CreateExam.Show();
            this.Hide();
        }

        private void btn_showExam_Click(object sender, EventArgs e)
        {
            ExamManagerForm examManagerForm = new ExamManagerForm();
            examManagerForm.Show();
            examManagerForm.StartPosition = FormStartPosition.CenterScreen; // center the form
            this.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
