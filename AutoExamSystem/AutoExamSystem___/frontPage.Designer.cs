namespace AutoExamSystem___
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // signup
            // 
            this.signup.Location = new System.Drawing.Point(334, 304);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(132, 72);
            this.signup.TabIndex = 0;
            this.signup.Text = "SIGN UP";
            this.signup.UseVisualStyleBackColor = true;
            this.signup.Click += new System.EventHandler(this.signup_Click);
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(334, 226);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(132, 72);
            this.login.TabIndex = 1;
            this.login.Text = "LOG IN";
            this.login.UseVisualStyleBackColor = true;
            // 
            // txtusername_log
            // 
            this.txtusername_log.Location = new System.Drawing.Point(303, 104);
            this.txtusername_log.Name = "txtusername_log";
            this.txtusername_log.Size = new System.Drawing.Size(185, 22);
            this.txtusername_log.TabIndex = 2;
            // 
            // txtpassword_log
            // 
            this.txtpassword_log.Location = new System.Drawing.Point(303, 141);
            this.txtpassword_log.Name = "txtpassword_log";
            this.txtpassword_log.Size = new System.Drawing.Size(185, 22);
            this.txtpassword_log.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "User name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "password";
            // 
            // frontPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpassword_log);
            this.Controls.Add(this.txtusername_log);
            this.Controls.Add(this.login);
            this.Controls.Add(this.signup);
            this.Name = "frontPage";
            this.Text = "frontPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signup;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox txtusername_log;
        private System.Windows.Forms.TextBox txtpassword_log;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}