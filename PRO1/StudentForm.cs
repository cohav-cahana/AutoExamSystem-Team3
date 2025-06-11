using DocumentFormat.OpenXml.Spreadsheet;
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
    public partial class StudentForm : Form
    {
        private frontPage login;
        private User currentUser;
        public StudentForm(User user, frontPage login)
        {
            InitializeComponent();
            this.currentUser = user;
            this.login = login;
            this.BackgroundImage = Properties.Resources.jeffrey;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            welcomeLbl.Text = "Welcome " + user.Username;
        }

        private void examBtn_Click(object sender, EventArgs e)
        {
            ExamSelection examSelection = new ExamSelection(currentUser, this);
            examSelection.Show();
            this.Hide();
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

        private void welcomeLbl_Click(object sender, EventArgs e)
        {

        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
