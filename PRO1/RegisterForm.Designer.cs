using System;
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
            this.btnPasswordTip = new System.Windows.Forms.Button();
            this.btnUsernameTip = new System.Windows.Forms.Button();
            this.picSmileySad = new System.Windows.Forms.PictureBox();
            this.picSmiley = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblRegister = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picSmileySad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSmiley)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtUsername.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(197, 97);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(112, 38);
            this.txtUsername.TabIndex = 4;
           // this.txtUsername.MouseEnter += new System.EventHandler(this.cmbRole_MouseEnter);
           // this.txtUsername.MouseLeave += new System.EventHandler(this.cmbRole_MouseLeave);
            // 

            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPassword.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(197, 165);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(112, 38);
            this.txtPassword.TabIndex = 5;
           // this.txtPassword.MouseEnter += new System.EventHandler(this.cmbRole_MouseEnter);
            //this.txtPassword.MouseLeave += new System.EventHandler(this.cmbRole_MouseLeave);
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtID.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(197, 236);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(112, 38);
            this.txtID.TabIndex = 6;
           // this.txtID.MouseEnter += new System.EventHandler(this.cmbRole_MouseEnter);
            //this.txtID.MouseLeave += new System.EventHandler(this.cmbRole_MouseLeave);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmail.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(197, 295);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(112, 38);
            this.txtEmail.TabIndex = 7;
          //  this.txtEmail.MouseEnter += new System.EventHandler(this.cmbRole_MouseEnter);
            //this.txtEmail.MouseLeave += new System.EventHandler(this.cmbRole_MouseLeave);
            // 
            // RegisterB
            // 
            this.RegisterB.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.RegisterB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterB.FlatAppearance.BorderSize = 0;
            this.RegisterB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterB.ForeColor = System.Drawing.Color.White;
            this.RegisterB.Location = new System.Drawing.Point(346, 454);
            this.RegisterB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RegisterB.Name = "RegisterB";
            this.RegisterB.Size = new System.Drawing.Size(127, 40);
            this.RegisterB.TabIndex = 8;
            this.RegisterB.Text = "sign up";
            this.RegisterB.UseVisualStyleBackColor = false;
            this.RegisterB.Click += new System.EventHandler(this.RegisterB_Click);
           // this.RegisterB.MouseEnter += new System.EventHandler(this.cmbRole_MouseEnter);
            //this.RegisterB.MouseLeave += new System.EventHandler(this.cmbRole_MouseLeave);
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
            this.cmbRole.Location = new System.Drawing.Point(197, 370);
            this.cmbRole.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(136, 31);
            this.cmbRole.TabIndex = 10;
            //this.cmbRole.MouseEnter += new System.EventHandler(this.cmbRole_MouseEnter);
            //this.cmbRole.MouseLeave += new System.EventHandler(this.cmbRole_MouseLeave);
            // 
            // btnPasswordTip
            // 
            this.btnPasswordTip.Location = new System.Drawing.Point(315, 168);
            this.btnPasswordTip.Name = "btnPasswordTip";
            this.btnPasswordTip.Size = new System.Drawing.Size(42, 27);
            this.btnPasswordTip.TabIndex = 12;
            this.btnPasswordTip.Text = "?";
            this.btnPasswordTip.UseVisualStyleBackColor = true;
            // 
            // btnUsernameTip
            // 
            this.btnUsernameTip.Location = new System.Drawing.Point(327, 103);
            this.btnUsernameTip.Name = "btnUsernameTip";
            this.btnUsernameTip.Size = new System.Drawing.Size(42, 27);
            this.btnUsernameTip.TabIndex = 13;
            this.btnUsernameTip.Text = "?";
            this.btnUsernameTip.UseVisualStyleBackColor = true;
            // 
            // picSmileySad
            // 
            this.picSmileySad.BackColor = System.Drawing.Color.Transparent;
        //    this.picSmileySad.Image = global::PRO1.Properties.Resources.sad_smiley_small;
            this.picSmileySad.Location = new System.Drawing.Point(287, 454);
            this.picSmileySad.Name = "picSmileySad";
            this.picSmileySad.Size = new System.Drawing.Size(53, 61);
            this.picSmileySad.TabIndex = 15;
            this.picSmileySad.TabStop = false;
            this.picSmileySad.Visible = false;
            // 
            // picSmiley
            // 
          //  this.picSmiley.Image = global::PRO1.Properties.Resources.icon_smiley_small;
            this.picSmiley.Location = new System.Drawing.Point(479, 444);
            this.picSmiley.Name = "picSmiley";
            this.picSmiley.Size = new System.Drawing.Size(100, 50);
            this.picSmiley.TabIndex = 14;
            this.picSmiley.TabStop = false;
            this.picSmiley.Visible = false;
            // 
            // pictureBox1
            // 
     //       this.pictureBox1.Image = global::PRO1.Properties.Resources.scelogo;
            this.pictureBox1.Location = new System.Drawing.Point(543, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(356, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblRegister.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblRegister.Location = new System.Drawing.Point(157, 23);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(246, 46);
            this.lblRegister.TabIndex = 16;
            this.lblRegister.Text = "Register Here!";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(900, 647);
            this.Controls.Add(this.lblRegister);
            this.Controls.Add(this.picSmileySad);
            this.Controls.Add(this.picSmiley);
            this.Controls.Add(this.btnUsernameTip);
            this.Controls.Add(this.btnPasswordTip);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.RegisterB);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
<<<<<<< Updated upstream
          //  this.Load += new System.EventHandler(this.RegisterForm_Load);
=======
            //this.Load += new System.EventHandler(this.RegisterForm_Load);
>>>>>>> Stashed changes
            ((System.ComponentModel.ISupportInitialize)(this.picSmileySad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSmiley)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private PictureBox pictureBox1;
        private Button btnPasswordTip;
        private Button btnUsernameTip;
        private PictureBox picSmiley;
        private PictureBox picSmileySad;
        private Label lblRegister;
    }
}