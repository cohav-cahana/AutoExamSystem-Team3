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
using DocumentFormat.OpenXml.Drawing.Charts;


namespace PRO1
{
    public partial class RegisterForm : Form
    {
        ToolTip tip = new ToolTip();

        public RegisterForm()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.jeffrey;
            this.BackgroundImageLayout = ImageLayout.Stretch;

        }
        public static List<string> ReadAllIDs(string filePath)
        {
            List<string> ids = new List<string>();

            using (var workbook = new XLWorkbook(filePath))
            {
                var worksheet = workbook.Worksheet(1); 
                var rows = worksheet.RangeUsed().RowsUsed();

                foreach (var row in rows.Skip(1))
                {
                    string id = row.Cell(3).GetValue<string>().Trim();
                    if (!string.IsNullOrEmpty(id))
                    {
                        ids.Add(id);
                    }
                }
            }

            return ids;
        }

        private async void RegisterB_Click(object sender, EventArgs e)
        {
            FirebaseHelper firebaseHelper = new FirebaseHelper();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string id = txtID.Text.Trim();
            string email = txtEmail.Text.Trim();
            string role = cmbRole.SelectedItem?.ToString();
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
            List<string> existingIDs = ReadAllIDs(filePath);


            if (!ValidationHelper.IsValidUsername(username))
            {
                MessageBox.Show("Username must be 6–8 characters long, contain up to two digits, and the rest letters.");
                return;
            }

            if (!ValidationHelper.IsValidPassword(password))
            {
                MessageBox.Show("Password must be 8–10 characters long, with at least one letter, one digit, and one special character.");
                return;
            }

            if (!ValidationHelper.IsValidID(id))
            {
                MessageBox.Show("Invalid ID. It must be exactly 9 digits.");
                return;
            }
            else if (!ValidationHelper.IsUniqueID(id, existingIDs))
            {
                MessageBox.Show("This ID already exists in the system. Please enter a unique ID.");
                return;
            }

            if (!ValidationHelper.IsValidEmail(email))
            {
                MessageBox.Show("Invalid email address.");
                return;
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


            MessageBox.Show("User saved successfully!");
            MainPage mainpage = new MainPage();
            mainpage.Show();

            this.Close();


        }
        private void AddPlaceholders()
        {
            txtUsername.Text = "Enter username";
            txtUsername.ForeColor = Color.Gray;
            txtUsername.GotFocus += RemovePlaceholderUsername;
            txtUsername.LostFocus += SetPlaceholderUsername;

            txtPassword.Text = "Enter password";
            txtPassword.ForeColor = Color.Gray;
            txtPassword.GotFocus += RemovePlaceholderPassword;
            txtPassword.LostFocus += SetPlaceholderPassword;

            txtID.Text = "Enter ID";
            txtID.ForeColor = Color.Gray;
            txtID.GotFocus += RemovePlaceholderID;
            txtID.LostFocus += SetPlaceholderID;

            txtEmail.Text = "Enter email";
            txtEmail.ForeColor = Color.Gray;
            txtEmail.GotFocus += RemovePlaceholderEmail;
            txtEmail.LostFocus += SetPlaceholderEmail;
        }
        // Username
        private void RemovePlaceholderUsername(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Enter username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }
        }

        private void SetPlaceholderUsername(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                txtUsername.Text = "Enter username";
                txtUsername.ForeColor = Color.Gray;
            }
        }

        // Password
        private void RemovePlaceholderPassword(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Enter password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
                txtPassword.PasswordChar = '●';
            }
        }

        private void SetPlaceholderPassword(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.PasswordChar = '\0';
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.Text = "Enter password";
                txtPassword.ForeColor = Color.Gray;
            }
        }

        // ID
        private void RemovePlaceholderID(object sender, EventArgs e)
        {
            if (txtID.Text == "Enter ID")
            {
                txtID.Text = "";
                txtID.ForeColor = Color.Black;
            }
        }

        private void SetPlaceholderID(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                txtID.Text = "Enter ID";
                txtID.ForeColor = Color.Gray;
            }
        }

        // Email
        private void RemovePlaceholderEmail(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Enter email")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void SetPlaceholderEmail(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                txtEmail.Text = "Enter email";
                txtEmail.ForeColor = Color.Gray;
            }
        }



        private void RegisterForm_Load(object sender, EventArgs e)
        {
            AddPlaceholders();
            tip.SetToolTip(btnUsernameTip, "Username must be 6–8 characters long, contain up to two digits, and the rest letters (English).");
            tip.SetToolTip(btnPasswordTip, "Password must be 8–10 characters long, with at least one letter, one digit, and one special character.");




        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Close();
        }
    }
}
