namespace PRO1
{
    partial class frontPage
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
            this.signup = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Button();
            this.txtusername_log = new System.Windows.Forms.TextBox();
            this.txtpassword_log = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnShowPassword = new System.Windows.Forms.Button();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // signup
            // 
            this.signup.Location = new System.Drawing.Point(179, 394);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(132, 25);
            this.signup.TabIndex = 0;
            this.signup.Text = "Register Here";
            this.signup.UseVisualStyleBackColor = true;
            this.signup.Click += new System.EventHandler(this.signup_Click);
            // 
            // login
            // 
            this.login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.login.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.login.ForeColor = System.Drawing.Color.White;
            this.login.Location = new System.Drawing.Point(145, 258);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(198, 40);
            this.login.TabIndex = 1;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // txtusername_log
            // 
            this.txtusername_log.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtusername_log.BackColor = System.Drawing.Color.White;
            this.txtusername_log.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtusername_log.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername_log.ForeColor = System.Drawing.Color.DimGray;
            this.txtusername_log.Location = new System.Drawing.Point(114, 135);
            this.txtusername_log.Name = "txtusername_log";
            this.txtusername_log.Size = new System.Drawing.Size(250, 38);
            this.txtusername_log.TabIndex = 2;
            // 
            // txtpassword_log
            // 
            this.txtpassword_log.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtpassword_log.BackColor = System.Drawing.Color.White;
            this.txtpassword_log.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpassword_log.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword_log.ForeColor = System.Drawing.Color.DimGray;
            this.txtpassword_log.Location = new System.Drawing.Point(114, 179);
            this.txtpassword_log.Name = "txtpassword_log";
            this.txtpassword_log.Size = new System.Drawing.Size(250, 38);
            this.txtpassword_log.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(103, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 45);
            this.label3.TabIndex = 6;
            this.label3.Text = "Welcome back!";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(106, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(262, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "Log in to AutoExam System:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(244, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Forget Password?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.btnShowPassword);
            this.panelLeft.Controls.Add(this.signup);
            this.panelLeft.Controls.Add(this.label3);
            this.panelLeft.Controls.Add(this.login);
            this.panelLeft.Controls.Add(this.label1);
            this.panelLeft.Controls.Add(this.label4);
            this.panelLeft.Controls.Add(this.txtpassword_log);
            this.panelLeft.Controls.Add(this.txtusername_log);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(450, 450);
            this.panelLeft.TabIndex = 9;
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.BackColor = System.Drawing.Color.White;
            this.btnShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowPassword.FlatAppearance.BorderSize = 0;
            this.btnShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPassword.Location = new System.Drawing.Point(305, 182);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(53, 33);
            this.btnShowPassword.TabIndex = 9;
            this.btnShowPassword.TabStop = false;
            this.btnShowPassword.UseVisualStyleBackColor = false;
            this.btnShowPassword.Click += new System.EventHandler(this.btnShowPassword_Click);
            // 
            // panelRight
            // 
            this.panelRight.BackgroundImage = global::PRO1.Properties.Resources.AutoExamLogo;
            this.panelRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(450, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(350, 450);
            this.panelRight.TabIndex = 10;
            // 
            // frontPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Name = "frontPage";
            this.Text = "frontPage";
            this.Load += new System.EventHandler(this.frontPage_Load);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button signup;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox txtusername_log;
        private System.Windows.Forms.TextBox txtpassword_log;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Button btnShowPassword;
    }
}