using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;


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
        /// 
        private void cmbRole_MouseEnter(object sender, EventArgs e)
        {
            // למשל שינוי צבע או טולטיפ
        }

        private void cmbRole_MouseLeave(object sender, EventArgs e)
        {
        }
        private void InitializeComponent()
        {
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.RegisterB = new System.Windows.Forms.Button();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.lblRegister = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.BACKpanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtUsername.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(389, 182);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(240, 38);
            this.txtUsername.TabIndex = 4;
            this.txtUsername.MouseEnter += new System.EventHandler(this.cmbRole_MouseEnter);
            this.txtUsername.MouseLeave += new System.EventHandler(this.cmbRole_MouseLeave);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPassword.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(389, 244);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(240, 38);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.MouseEnter += new System.EventHandler(this.cmbRole_MouseEnter);
            this.txtPassword.MouseLeave += new System.EventHandler(this.cmbRole_MouseLeave);
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtID.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(389, 304);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(240, 38);
            this.txtID.TabIndex = 6;
            this.txtID.MouseEnter += new System.EventHandler(this.cmbRole_MouseEnter);
            this.txtID.MouseLeave += new System.EventHandler(this.cmbRole_MouseLeave);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmail.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(389, 370);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(240, 38);
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
            this.RegisterB.Location = new System.Drawing.Point(389, 482);
            this.RegisterB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RegisterB.Name = "RegisterB";
            this.RegisterB.Size = new System.Drawing.Size(240, 40);
            this.RegisterB.TabIndex = 8;
            this.RegisterB.Text = "sign up";
            this.RegisterB.UseVisualStyleBackColor = false;
            this.RegisterB.Click += new System.EventHandler(this.RegisterB_Click);
            this.RegisterB.MouseEnter += new System.EventHandler(this.cmbRole_MouseEnter);
            this.RegisterB.MouseLeave += new System.EventHandler(this.cmbRole_MouseLeave);
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
            this.cmbRole.Location = new System.Drawing.Point(389, 431);
            this.cmbRole.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(240, 31);
            this.cmbRole.TabIndex = 10;
            this.cmbRole.MouseEnter += new System.EventHandler(this.cmbRole_MouseEnter);
            this.cmbRole.MouseLeave += new System.EventHandler(this.cmbRole_MouseLeave);
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblRegister.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblRegister.Location = new System.Drawing.Point(388, 114);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(230, 45);
            this.lblRegister.TabIndex = 16;
            this.lblRegister.Text = "Register Here";
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(26, 555);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(124, 52);
            this.btn_back.TabIndex = 17;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.button1_Click);
            // 
            // BACKpanel
            // 
            this.BACKpanel.BackColor = System.Drawing.Color.White;
            this.BACKpanel.Location = new System.Drawing.Point(240, 84);
            this.BACKpanel.Name = "BACKpanel";
            this.BACKpanel.Size = new System.Drawing.Size(536, 483);
            this.BACKpanel.TabIndex = 18;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::PRO1.Properties.Resources._33;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 628);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lblRegister);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.RegisterB);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.BACKpanel);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button RegisterB;
        private System.Windows.Forms.ComboBox cmbRole;
        private Label lblRegister;
        private Button btn_back;
        private Panel BACKpanel;
    }
}