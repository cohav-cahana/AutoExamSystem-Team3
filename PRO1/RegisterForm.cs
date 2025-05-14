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
using System.Drawing.Drawing2D;


namespace PRO1
{
    public partial class RegisterForm : Form
    {
        ToolTip tip = new ToolTip();
        private Point originalSmileyLocation;
        private Point originalSadSmileyLocation;


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
            string role = cmbRole.SelectedItem?.ToString();

            if (username.Length < 6 || username.Length > 8 || !System.Text.RegularExpressions.Regex.IsMatch(username, @"^[a-zA-Z]*\d{0,2}$"))
            {
                JumpSmiley(picSmileySad, originalSadSmileyLocation);
                MessageBox.Show("שם המשתמש חייב להכיל 6–8 תווים, עד שתי ספרות וכל השאר אותיות באנגלית.");
                return;
            }

            if (password.Length < 8 || password.Length > 10 ||
                !System.Text.RegularExpressions.Regex.IsMatch(password, @"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]+$"))
            {
                JumpSmiley(picSmileySad, originalSadSmileyLocation);
                MessageBox.Show("הסיסמה חייבת להכיל 8–10 תווים, לפחות אות אחת, ספרה אחת ותו מיוחד.");
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(id, @"^\d{9}$"))
            {
                JumpSmiley(picSmileySad, originalSadSmileyLocation);
                MessageBox.Show("מספר תז לא תקין. חייב להיות 9 ספרות.");
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                JumpSmiley(picSmileySad, originalSadSmileyLocation);
                MessageBox.Show("כתובת מייל לא תקינה.");
                return;
            }
            JumpSmiley(picSmiley, originalSmileyLocation);
            MessageBox.Show("  ההרשמה בוצעה בהצלחה! ");


         



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
            //debug
          // MessageBox.Show("המשתמש נשמר בהצלחה!");
      
            
        }

        private void cmbRole_MouseEnter(object sender, EventArgs e)
        {
            RegisterB.BackColor = Color.SlateBlue;


        }

        private void cmbRole_MouseLeave(object sender, EventArgs e)
        {
            RegisterB.BackColor = Color.MediumSlateBlue;

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.2;
            Timer fadeTimer = new Timer();
            fadeTimer.Interval = 15;
            fadeTimer.Tick += (s, args) =>
            {
                if (this.Opacity < 1)
                    this.Opacity += 0.05;
                else
                    fadeTimer.Stop();
            };
            fadeTimer.Start();

            // button to show password tip
            btnPasswordTip.FlatStyle = FlatStyle.Flat;
            btnPasswordTip.FlatAppearance.BorderSize = 0;
            btnPasswordTip.BackColor = Color.MediumSlateBlue;
            btnPasswordTip.ForeColor = Color.White;
            btnPasswordTip.Width = 22;
            btnPasswordTip.Height = 22;
            btnPasswordTip.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnPasswordTip.Location = new Point(txtPassword.Right + 5, txtPassword.Top);
            btnPasswordTip.Cursor = Cursors.Hand;

            // make it round
            GraphicsPath circlePath = new GraphicsPath();
            circlePath.AddEllipse(0, 0, btnPasswordTip.Width, btnPasswordTip.Height);
            btnPasswordTip.Region = new Region(circlePath);
            // add the tooltip
            tip.SetToolTip(btnPasswordTip, "הסיסמה צריכה להכיל 8-10 תווים, לפחות אות אחת, מספר ותו מיוחד.");

            //button to show UserName tip
            btnUsernameTip.FlatStyle = FlatStyle.Flat;
            btnUsernameTip.FlatAppearance.BorderSize = 0;
            btnUsernameTip.BackColor = Color.MediumSlateBlue;
            btnUsernameTip.ForeColor = Color.White;
            btnUsernameTip.Width = 22;
            btnUsernameTip.Height = 22;
            btnUsernameTip.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnUsernameTip.Location = new Point(txtUsername.Right + 5, txtUsername.Top);
            btnUsernameTip.Cursor = Cursors.Hand;

            //make it round
            GraphicsPath circlePath2 = new GraphicsPath();
            circlePath2.AddEllipse(0, 0, btnUsernameTip.Width, btnUsernameTip.Height);
            btnUsernameTip.Region = new Region(circlePath2);

            // add the tooltip
            tip.SetToolTip(btnUsernameTip, "שם המשתמש חייב להכיל 6–8 תווים, עד שתי ספרות וכל השאר אותיות באנגלית.");
            



            // make the Register button round
                        GraphicsPath path = new GraphicsPath();
            int radius = 50; 
            Rectangle rect = new Rectangle(0, 0, RegisterB.Width, RegisterB.Height);

            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();

            RegisterB.Region = new Region(path);


            //smiley icon
            picSmiley.Image = Properties.Resources.icon_smiley_small; 
            picSmiley.SizeMode = PictureBoxSizeMode.StretchImage;
            picSmiley.Size = new Size(40, 40);
            picSmiley.Location = new Point(RegisterB.Right + 5, RegisterB.Top);
            originalSmileyLocation = picSmiley.Location;

            //sad smiley icon
            picSmileySad.Image = Properties.Resources.sad_smiley_small;
            picSmileySad.SizeMode = PictureBoxSizeMode.StretchImage;
            picSmileySad.Size = new Size(40, 40);
            originalSadSmileyLocation = picSmileySad.Location;



        }
        private void JumpSmiley(PictureBox pic, Point original)
        {
            pic.Visible = true;
            int count = 0;
            int offset = 6;

            Timer t = new Timer();
            t.Interval = 60;
            t.Tick += (s, e) =>
            {
                if (count >= 6)
                {
                    pic.Location = original;
                    t.Stop();
                    Timer hide = new Timer();
                    hide.Interval = 1000;
                    hide.Tick += (ss, ee) =>
                    {
                        pic.Visible = false;
                        hide.Stop();
                    };
                    hide.Start();
                }
                else
                {
                    int dy = (count % 2 == 0) ? -offset : offset;
                    pic.Location = new Point(original.X, original.Y + dy);
                    count++;
                }
            };
            t.Start();
        }
     

    }
}
