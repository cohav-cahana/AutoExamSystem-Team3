using System;
using ClosedXML.Excel;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace AutoExamSystem___
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void signup_click_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text.Trim();
            string password = txtpassword.Text.Trim();
            string email = txtemail.Text.Trim();
            string id = txtid.Text.Trim();
            if (username.Length < 6 || username.Length > 8 || username.Count(char.IsDigit) > 2)
            {
                lblMessage.Text = "שם משתמש חייב להכיל 6–8 תווים ולכל היותר 2 ספרות.";
                return;
            }

            if (!Regex.IsMatch(password, @"^(?=.*[A-Za-z])(?=.*\d)(?=.*[!@#$%^&]).{8,10}$"))
            {
                lblMessage.Text = "סיסמה חייבת להכיל 8–10 תווים, כולל אות, ספרה ותו מיוחד.";
                return;
            }

            if (!email.Contains("@") || !email.Contains("."))
            {
                lblMessage.Text = "כתובת מייל לא תקינה.";
                return;
            }

            if (!Regex.IsMatch(id, @"^\d{9}$"))
            {
                lblMessage.Text = "מספר תעודת זהות לא תקין.";
                return;
            }
            Directory.CreateDirectory(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data"));

            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "users.xlsx");

            if (!File.Exists(filePath))
            {
                var newWb = new XLWorkbook();
                var newWs = newWb.Worksheets.Add("Users");
                newWs.Cell(1, 1).Value = "Username";
                newWs.Cell(1, 2).Value = "Password";
                newWs.Cell(1, 3).Value = "ID";
                newWs.Cell(1, 4).Value = "Email";
                newWb.SaveAs(filePath);
            }
            var wb = new XLWorkbook(filePath);
            var ws = wb.Worksheet(1);
            var lastRow = ws.LastRowUsed().RowNumber() + 1;

            ws.Cell(lastRow, 1).Value = username;
            ws.Cell(lastRow, 2).Value = password;
            ws.Cell(lastRow, 3).Value = id;
            ws.Cell(lastRow, 4).Value = email;

            wb.Save();

            MessageBox.Show("נרשמת בהצלחה!");
            this.Close();
            // שמירה לקובץ CSV
            try
            {
                string line = $"{username},{ password},{ email},{ id}";
                File.AppendAllText("users.csv", line + Environment.NewLine);
                lblMessage.Text ="נרשמת בהצלחה!";
            }
            catch (Exception ex)
            {
                lblMessage.Text = "שגיאה בשמירת הנתונים: " + ex.Message;
            }
        }
    }
}
        



        