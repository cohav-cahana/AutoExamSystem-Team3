namespace PRO1
{
    partial class LoginControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.btnShowPassword = new System.Windows.Forms.Button();
            this.txtpassword_log = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.txtusername_log = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(224, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 45);
            this.label3.TabIndex = 15;
            this.label3.Text = "Welcome back!";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.BackColor = System.Drawing.Color.White;
            this.btnShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowPassword.FlatAppearance.BorderSize = 0;
            this.btnShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPassword.Location = new System.Drawing.Point(427, 232);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(46, 28);
            this.btnShowPassword.TabIndex = 20;
            this.btnShowPassword.TabStop = false;
            this.btnShowPassword.UseVisualStyleBackColor = false;
            this.btnShowPassword.Click += new System.EventHandler(this.btnShowPassword_Click);
            // 
            // txtpassword_log
            // 
            this.txtpassword_log.BackColor = System.Drawing.Color.White;
            this.txtpassword_log.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpassword_log.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword_log.ForeColor = System.Drawing.Color.DimGray;
            this.txtpassword_log.Location = new System.Drawing.Point(232, 227);
            this.txtpassword_log.Name = "txtpassword_log";
            this.txtpassword_log.Size = new System.Drawing.Size(250, 38);
            this.txtpassword_log.TabIndex = 19;
            this.txtpassword_log.TextChanged += new System.EventHandler(this.txtpassword_log_TextChanged);
            // 
            // login
            // 
            this.login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.login.BackColor = System.Drawing.Color.Sienna;
            this.login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.login.ForeColor = System.Drawing.Color.White;
            this.login.Location = new System.Drawing.Point(256, 290);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(198, 40);
            this.login.TabIndex = 21;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // txtusername_log
            // 
            this.txtusername_log.BackColor = System.Drawing.Color.White;
            this.txtusername_log.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtusername_log.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername_log.ForeColor = System.Drawing.Color.DimGray;
            this.txtusername_log.Location = new System.Drawing.Point(232, 183);
            this.txtusername_log.Name = "txtusername_log";
            this.txtusername_log.Size = new System.Drawing.Size(250, 38);
            this.txtusername_log.TabIndex = 18;
            this.txtusername_log.TextChanged += new System.EventHandler(this.txtusername_log_TextChanged);
            // 
            // LoginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnShowPassword);
            this.Controls.Add(this.txtusername_log);
            this.Controls.Add(this.login);
            this.Controls.Add(this.txtpassword_log);
            this.Controls.Add(this.label3);
            this.Name = "LoginControl";
            this.Size = new System.Drawing.Size(782, 624);
            this.Load += new System.EventHandler(this.LoginControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnShowPassword;
        private System.Windows.Forms.TextBox txtpassword_log;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox txtusername_log;
    }
}
