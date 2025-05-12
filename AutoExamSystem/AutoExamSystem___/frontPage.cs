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

namespace AutoExamSystem___
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

                    if (excelRole.ToLower() == "student")
                    {
                        MessageBox.Show("ברוך הבא סטודנט!");
                        StudentForm studentForm = new StudentForm();
                        studentForm.Show();
                        this.Hide();
                    }
                    else if (excelRole.ToLower() == "lecturer")
                    {
                        MessageBox.Show("שלום מרצה!");
                        LecturerForm lecturerForm = new LecturerForm();
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
    }
}
