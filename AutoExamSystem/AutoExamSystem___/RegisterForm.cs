using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoExamSystem___
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterB_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string id = txtID.Text.Trim();
            string email = txtEmail.Text.Trim();

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
        }
    }
}
