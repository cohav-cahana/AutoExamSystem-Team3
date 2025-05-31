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
            this.BackgroundImage = Properties.Resources.jeffrey;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private async void RegisterB_Click(object sender, EventArgs e)
        {
            FirebaseHelper firebaseHelper = new FirebaseHelper();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string id = txtID.Text.Trim();
            string email = txtEmail.Text.Trim();
            string role = cmbRole.SelectedItem?.ToString();

            if (!ValidationHelper.IsValidUsername(username))
            { 
                MessageBox.Show("שם המשתמש חייב להכיל 6–8 תווים, עד שתי ספרות וכל השאר אותיות באנגלית.");
                return;
            }

            if (!ValidationHelper.IsValidPassword(password))
            {
                MessageBox.Show("הסיסמה חייבת להכיל 8–10 תווים, לפחות אות אחת, ספרה אחת ותו מיוחד.");
                return;
            }

            if (!ValidationHelper.IsValidID(id))
            {
                MessageBox.Show("מספר ת\"ז לא תקין. חייב להיות 9 ספרות.");
                return;
            }

            if (!ValidationHelper.IsValidEmail(email))
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
            this.Close();
      
            
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
