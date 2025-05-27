using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace PRO1
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private async void RegisterB_Click(object sender, EventArgs e)
        {
            FirebaseHelper firebaseHelper = new FirebaseHelper();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string id = txtID.Text.Trim();
            string email = txtEmail.Text.Trim();
            string role = cmbRole.SelectedItem?.ToString();

            if (username.Length < 6 || username.Length > 8 || !System.Text.RegularExpressions.Regex.IsMatch(username, @"^[a-zA-Z]*\d{0,2}$"))
            {
                MessageBox.Show("שם המשתמש חייב להכיל 6–8 תווים, עד שתי ספרות וכל השאר אותיות באנגלית.");
                return;
            }

            if (password.Length < 8 || password.Length > 10 ||
                !System.Text.RegularExpressions.Regex.IsMatch(password, @"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]+$"))
            {
                MessageBox.Show("הסיסמה חייבת להכיל 8–10 תווים, לפחות אות אחת, ספרה אחת ותו מיוחד.");
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(id, @"^\d{9}$"))
            {
                MessageBox.Show("מספר ת\"ז לא תקין. חייב להיות 9 ספרות.");
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("כתובת מייל לא תקינה.");
                return;
            }

            MessageBox.Show("הרשמה הושלמה בהצלחה!");


            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Users.xlsx");




            if (!File.Exists(filePath))
            {
                var wb = new XLWorkbook();
                var ws = wb.Worksheets.Add("Users");
                ws.Cell(1, 1).Value = "Username";
                ws.Cell(1, 2).Value = "Password";
                ws.Cell(1, 3).Value = "ID";
                ws.Cell(1, 4).Value = "Email";
                ws.Cell(1, 5).Value = "Role";
                wb.SaveAs(filePath);
            }


            var workbook = new XLWorkbook(filePath);
            var worksheet = workbook.Worksheet("Users");

            int lastRow = worksheet.LastRowUsed().RowNumber() + 1;
            worksheet.Cell(lastRow, 1).Value = txtUsername.Text;
            worksheet.Cell(lastRow, 2).Value = txtPassword.Text;
            worksheet.Cell(lastRow, 3).Value = txtID.Text;
            worksheet.Cell(lastRow, 4).Value = txtEmail.Text;
            worksheet.Cell(lastRow, 5).Value = role;

            workbook.Save();

            await firebaseHelper.AddUserAsync(username, password, id, email, role);


            MessageBox.Show("המשתמש נשמר בהצלחה!");
      
            
        }
    }
}
