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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            this.Text = "College System";
            this.Load += MainPage_Load;
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.MouseEnter += Btn_MouseEnter;
                    btn.MouseLeave += Btn_MouseLeave;
                    btn.Click += Btn_Click;
                }
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.BackColor = Color.White;
                    btn.ForeColor = Color.Black;
                }
            }

            Button clicked = (Button)sender;
            clicked.BackColor = Color.RoyalBlue;
            clicked.ForeColor = Color.White;
        }

        private void Btn_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.RoyalBlue)
                btn.BackColor = Color.LightBlue;
        }

        private void Btn_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.RoyalBlue)
            {
                btn.BackColor = Color.White;
                btn.ForeColor = Color.Black;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frontPage login = new frontPage();
            login.Show();
            this.Hide();
        }

       

      

        private void btnContact_Click(object sender, EventArgs e)
        {
            lblContactInfo.Visible = true;
        }

        private void btnSignup_Click_1(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();

        }
    }
}