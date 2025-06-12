using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PRO1
{
    
    public partial class Form1 : Form
    {
        private  User currentUser;
        private frontPage login;

        public Form1() : this(new User(), null)
        {
        }
        public Form1(User user, frontPage login)
        {
            InitializeComponent();
            this.currentUser = user;
            this.login = login;
            //this.labelWelcome.Text = "Welcome " + user.Username;
            
            this.BackColor = Color.White;
            this.BackColor = Color.White;

            labelWelcome.Font = new Font("Arial", 18, FontStyle.Bold);
            button1.Font= new Font("Arial", 12, FontStyle.Bold);
            button2.Font = new Font("Arial", 12, FontStyle.Bold);
            button4.Font = new Font("Arial", 8, FontStyle.Bold);
            welcomeLbl.Text = "Welcome " + SessionManager.Username;
            StyleLinenButton(btn_showExam);
            StyleLinenButton(button1);
            StyleLinenButton(button2);
            StyleLinenButton(button4);
            StyleWarmButton(button3);
            SetRoundedRegion(panel1, 20);



        }
        private void SetRoundedRegion(Control control, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = control.ClientRectangle;

            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();

            control.Region = new Region(path);
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



        private void btn_createQ_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuestionForm questionForm = new QuestionForm();
            questionForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GradeFormTeacher gradeFormTeacher = new GradeFormTeacher();
            gradeFormTeacher.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frontPage front = new frontPage();
            this.Hide();
            front.Show();
        }

        private void welcomeLbl_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
