using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PRO1;
using PRO1.Properties;


namespace PRO1
{
    public partial class frontPage : Form
    {
        public frontPage()
        {
            InitializeComponent();
        }

        private void signup_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void login_Click(object sender, EventArgs e)
        {
            string username = txtusername_log.Text.Trim();
            string password = txtpassword_log.Text.Trim();

            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Users.xlsx");



            if (!File.Exists(filePath))
            {
                MessageBox.Show("קובץ המשתמשים לא נמצא.");
                return;
            }

            var workbook = new XLWorkbook(filePath);
            var worksheet = workbook.Worksheet("Users");

            bool found = false;

            foreach (var row in worksheet.RowsUsed().Skip(1)) // לדלג על שורת כותרות
            {
                string excelUser = row.Cell(1).GetValue<string>();
                string excelPass = row.Cell(2).GetValue<string>();
                string excelRole = row.Cell(5).GetValue<string>();

                if (excelUser == username && excelPass == password)
                {
                    found = true;
                    User user = new User
                    {
                        Username = username,
                        Password = password,
                        UserId = row.Cell(3).GetValue<string>(),
                        Email = row.Cell(4).GetValue<string>(),
                        Role = excelRole
                    };

                    if (excelRole.ToLower() == "student")
                    {
                        MessageBox.Show("ברוך הבא סטודנט!");
                        StudentForm studentForm = new StudentForm(user, this);
                        studentForm.Show();
                        this.Hide();
                    }
                    else if (excelRole.ToLower() == "lecture")
                    {
                        MessageBox.Show("שלום מרצה!");
                        Form1 lecturerForm = new Form1();
                        lecturerForm.Show();
                        this.Hide();
                    }

                    break;
                }
            }

            if (!found)
            {
                MessageBox.Show("שם המשתמש או הסיסמה שגויים.");
            }
        }
        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = Color.Gray;

            if (textBox == txtpassword_log)
                textBox.UseSystemPasswordChar = false;


            textBox.Enter += (s, e) =>
            {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                    if (textBox == txtpassword_log)
                        textBox.UseSystemPasswordChar = true;
                }
            };

            textBox.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = Color.Gray;
                }
            };
        }


        private void frontPage_Load(object sender, EventArgs e)
        {
            SetPlaceholder(txtusername_log, "Username");
            SetPlaceholder(txtpassword_log, "Password");
            txtpassword_log.UseSystemPasswordChar = true;
            btnShowPassword.Image = Image.FromFile("Resources/icons8-closed-eye-32x32.png");

            panelRight.BackgroundImageLayout = ImageLayout.Stretch;


        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please contact your instructor to reset your password.", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        bool passwordVisible = false;

        private void btnShowPassword_Click(object sender, EventArgs e)
        {

            passwordVisible = !passwordVisible;

            txtpassword_log.UseSystemPasswordChar = !passwordVisible;

            if (passwordVisible)
            {
                btnShowPassword.Image = Image.FromFile("Resources/icons8-open-eye-32x32.png");
            }
            else
            {
                btnShowPassword.Image = Image.FromFile("Resources/icons8-closed-eye-32x32.png");
            }
        }
    }

}