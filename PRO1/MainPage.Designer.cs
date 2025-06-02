namespace PRO1
{
    partial class MainPage
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnLearn = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.btnSignup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnContact = new System.Windows.Forms.Button();
            this.lblContactInfo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitle.Location = new System.Drawing.Point(67, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(266, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "COLLEGE SYSTEM";
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.White;
            this.btnApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApply.FlatAppearance.BorderSize = 0;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnApply.ForeColor = System.Drawing.Color.Black;
            this.btnApply.Location = new System.Drawing.Point(482, 31);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(166, 35);
            this.btnApply.TabIndex = 2;
            this.btnApply.Text = "Apply Now";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnLearn
            // 
            this.btnLearn.BackColor = System.Drawing.Color.White;
            this.btnLearn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLearn.FlatAppearance.BorderSize = 0;
            this.btnLearn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLearn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnLearn.ForeColor = System.Drawing.Color.Black;
            this.btnLearn.Location = new System.Drawing.Point(654, 31);
            this.btnLearn.Name = "btnLearn";
            this.btnLearn.Size = new System.Drawing.Size(146, 34);
            this.btnLearn.TabIndex = 3;
            this.btnLearn.Text = "Learn More";
            this.btnLearn.UseVisualStyleBackColor = false;
            // 
            // btnLogin
            // 
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnLogin.Location = new System.Drawing.Point(962, 31);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(85, 34);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login ";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // sidePanel
            // 
            this.sidePanel.Controls.Add(this.btnSignup);
            this.sidePanel.Controls.Add(this.btnLogin);
            this.sidePanel.Controls.Add(this.lblTitle);
            this.sidePanel.Controls.Add(this.btnApply);
            this.sidePanel.Controls.Add(this.btnLearn);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(1161, 100);
            this.sidePanel.TabIndex = 5;
            // 
            // btnSignup
            // 
            this.btnSignup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignup.FlatAppearance.BorderSize = 0;
            this.btnSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignup.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSignup.Location = new System.Drawing.Point(822, 31);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(118, 34);
            this.btnSignup.TabIndex = 5;
            this.btnSignup.Text = "Sign up";
            this.btnSignup.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(314, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(526, 76);
            this.label1.TabIndex = 7;
            this.label1.Text = "\"Learning is a treasure that will follow \r\nits owner everywhere.\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnContact
            // 
            this.btnContact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContact.FlatAppearance.BorderSize = 0;
            this.btnContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContact.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnContact.ForeColor = System.Drawing.Color.Black;
            this.btnContact.Location = new System.Drawing.Point(498, 211);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(150, 40);
            this.btnContact.TabIndex = 6;
            this.btnContact.Text = "Contact Us";
            this.btnContact.UseVisualStyleBackColor = true;
            this.btnContact.Click += new System.EventHandler(this.btnContact_Click);
            // 
            // lblContactInfo
            // 
            this.lblContactInfo.AutoSize = true;
            this.lblContactInfo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblContactInfo.Location = new System.Drawing.Point(464, 254);
            this.lblContactInfo.Name = "lblContactInfo";
            this.lblContactInfo.Size = new System.Drawing.Size(220, 46);
            this.lblContactInfo.TabIndex = 8;
            this.lblContactInfo.Text = "Phone: 052-1234567\r\nEmail: contact@college.edu";
            this.lblContactInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblContactInfo.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PRO1.Properties.Resources.students_banner_cropped;
            this.pictureBox1.Location = new System.Drawing.Point(0, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1161, 848);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1161, 676);
            this.Controls.Add(this.lblContactInfo);
            this.Controls.Add(this.btnContact);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.sidePanel.ResumeLayout(false);
            this.sidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnLearn;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnContact;
        private System.Windows.Forms.Label lblContactInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}