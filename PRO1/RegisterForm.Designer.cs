using System.Windows.Forms;

namespace PRO1
{
    public partial class RegisterForm : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.RegisterB = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.btnPasswordTip = new System.Windows.Forms.Button();
            this.btnUsernameTip = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtUsername.Location = new System.Drawing.Point(236, 104);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(112, 30);
            this.txtUsername.TabIndex = 4;
            this.txtUsername.MouseEnter += new System.EventHandler(this.cmbRole_MouseEnter);
            this.txtUsername.MouseLeave += new System.EventHandler(this.cmbRole_MouseLeave);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPassword.Location = new System.Drawing.Point(236, 172);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(112, 30);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.MouseEnter += new System.EventHandler(this.cmbRole_MouseEnter);
            this.txtPassword.MouseLeave += new System.EventHandler(this.cmbRole_MouseLeave);
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtID.Location = new System.Drawing.Point(236, 243);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(112, 30);
            this.txtID.TabIndex = 6;
            this.txtID.MouseEnter += new System.EventHandler(this.cmbRole_MouseEnter);
            this.txtID.MouseLeave += new System.EventHandler(this.cmbRole_MouseLeave);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmail.Location = new System.Drawing.Point(236, 302);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(112, 30);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.MouseEnter += new System.EventHandler(this.cmbRole_MouseEnter);
            this.txtEmail.MouseLeave += new System.EventHandler(this.cmbRole_MouseLeave);
            // 
            // RegisterB
            // 
            this.RegisterB.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.RegisterB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterB.FlatAppearance.BorderSize = 0;
            this.RegisterB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterB.ForeColor = System.Drawing.Color.White;
            this.RegisterB.Location = new System.Drawing.Point(385, 461);
            this.RegisterB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RegisterB.Name = "RegisterB";
            this.RegisterB.Size = new System.Drawing.Size(127, 40);
            this.RegisterB.TabIndex = 8;
            this.RegisterB.Text = "sign up";
            this.RegisterB.UseVisualStyleBackColor = false;
            this.RegisterB.Click += new System.EventHandler(this.RegisterB_Click);
            this.RegisterB.MouseEnter += new System.EventHandler(this.cmbRole_MouseEnter);
            this.RegisterB.MouseLeave += new System.EventHandler(this.cmbRole_MouseLeave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Role";
            // 
            // cmbRole
            // 
            this.cmbRole.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRole.ForeColor = System.Drawing.Color.Black;
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "Student",
            "Lecture"});
            this.cmbRole.Location = new System.Drawing.Point(236, 377);
            this.cmbRole.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(136, 31);
            this.cmbRole.TabIndex = 10;
            this.cmbRole.MouseEnter += new System.EventHandler(this.cmbRole_MouseEnter);
            this.cmbRole.MouseLeave += new System.EventHandler(this.cmbRole_MouseLeave);
            // 
            // btnPasswordTip
            // 
            this.btnPasswordTip.Location = new System.Drawing.Point(354, 175);
            this.btnPasswordTip.Name = "btnPasswordTip";
            this.btnPasswordTip.Size = new System.Drawing.Size(42, 27);
            this.btnPasswordTip.TabIndex = 12;
            this.btnPasswordTip.Text = "?";
            this.btnPasswordTip.UseVisualStyleBackColor = true;
            // 
            // btnUsernameTip
            // 
            this.btnUsernameTip.Location = new System.Drawing.Point(366, 110);
            this.btnUsernameTip.Name = "btnUsernameTip";
            this.btnUsernameTip.Size = new System.Drawing.Size(42, 27);
            this.btnUsernameTip.TabIndex = 13;
            this.btnUsernameTip.Text = "?";
            this.btnUsernameTip.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(543, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(356, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(900, 647);
            this.Controls.Add(this.btnUsernameTip);
            this.Controls.Add(this.btnPasswordTip);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RegisterB);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button RegisterB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbRole;
        private PictureBox pictureBox1;
        private Button btnPasswordTip;
        private Button btnUsernameTip;
    }
}