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
using System.Drawing.Drawing2D;

using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;

namespace PRO1
{
    public partial class StudentForm : Form
    {
        private frontPage login;
        private User currentUser;
        public StudentForm(User user, frontPage login)
        {
            InitializeComponent();
            this.currentUser = user;
            this.login = login;
            
            welcomeLbl.Text = "Welcome " + user.Username;


            panel1.Paint += panel1_Paint;

            this.BackColor = System.Drawing.Color.White;
            StyleWarmButton(backBtn);
            StyleWarmButton(examBtn);
            StyleWarmButton(gradeBtn);




        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel == null) return;

            int radius = 20; // כמה עגולים יהיו הקצוות

            GraphicsPath path = new GraphicsPath();
            Rectangle rect = panel.ClientRectangle;

            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();

            panel.Region = new Region(path);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        }


        private void examBtn_Click(object sender, EventArgs e)
        {
            ExamSelection examSelection = new ExamSelection(currentUser, this);
            examSelection.Show();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            login.Show();
            this.Close();

            
        }

        private void gradeBtn_Click(object sender, EventArgs e)
        {
            GradesForm gradesForm = new GradesForm(currentUser, login);
            gradesForm.Show();
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

        private void welcomeLbl_Click(object sender, EventArgs e)
        {

        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        
         

    }
}

