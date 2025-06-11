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
            this.btnShowPassword = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpassword_log = new System.Windows.Forms.TextBox();
            this.txtusername_log = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.signup = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();

            // btnShowPassword
            this.btnShowPassword.BackColor = System.Drawing.Color.White;
            this.btnShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowPassword.FlatAppearance.BorderSize = 0;
            this.btnShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPassword.Location = new System.Drawing.Point(339, 187);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(46, 28);
            this.btnShowPassword.TabIndex = 17;
            this.btnShowPassword.TabStop = false;
            this.btnShowPassword.UseVisualStyleBackColor = false;
            this.btnShowPassword.Click += new System.EventHandler(this.btnShowPassword_Click);

            // label3
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(139, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 45);
            this.label3.TabIndex = 14;
            this.label3.Text = "Welcome back!";
            this.label3.Click += new System.EventHandler(this.label3_Click);

            // login
            this.login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.login.BackColor = System.Drawing.Color.Sienna;
            this.login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.login.ForeColor = System.Drawing.Color.White;
            this.login.Location = new System.Drawing.Point(164, 280);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(198, 40);
            this.login.TabIndex = 11;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);

            // label1
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(214, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Forget Password?";
            this.label1.Click += new System.EventHandler(this.label1_Click);

            // txtusername_log
            this.txtusername_log.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtusername_log.BackColor = System.Drawing.Color.White;
            this.txtusername_log.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtusername_log.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername_log.ForeColor = System.Drawing.Color.DimGray;
            this.txtusername_log.Location = new System.Drawing.Point(144, 138);
            this.txtusername_log.Name = "txtusername_log";
            this.txtusername_log.Size = new System.Drawing.Size(250, 38);
            this.txtusername_log.TabIndex = 12;

            // txtpassword_log
            this.txtpassword_log.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtpassword_log.BackColor = System.Drawing.Color.White;
            this.txtpassword_log.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpassword_log.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword_log.ForeColor = System.Drawing.Color.DimGray;
            this.txtpassword_log.Location = new System.Drawing.Point(144, 182);
            this.txtpassword_log.Name = "txtpassword_log";
            this.txtpassword_log.Size = new System.Drawing.Size(250, 38);
            this.txtpassword_log.TabIndex = 13;

            // signup
            this.signup.BackColor = System.Drawing.Color.White;
            this.signup.Location = new System.Drawing.Point(196, 341);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(132, 25);
            this.signup.TabIndex = 10;
            this.signup.Text = "Register Here";
            this.signup.UseVisualStyleBackColor = false;
            this.signup.Click += new System.EventHandler(this.signup_Click);

            // panel1
            this.panel1.Controls.Add(this.btnShowPassword);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtpassword_log);
            this.panel1.Controls.Add(this.txtusername_log);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.login);
            this.panel1.Controls.Add(this.signup);
            this.panel1.Location = new System.Drawing.Point(296, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 429);
            this.panel1.TabIndex = 18;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);

            // frontPage
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1151, 641);
            this.Controls.Add(this.panel1);
            this.Name = "frontPage";
            this.Text = "frontPage";
            this.Load += new System.EventHandler(this.frontPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }


        #endregion

        private System.Windows.Forms.Button btnShowPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpassword_log;
        private System.Windows.Forms.TextBox txtusername_log;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button signup;
    }
}