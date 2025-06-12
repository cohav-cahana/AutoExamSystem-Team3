namespace PRO1
{
    partial class Form1
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
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.btn_showExam = new System.Windows.Forms.Button();
            this.btn_createQ = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.welcomeLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Linen;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Location = new System.Drawing.Point(391, 304);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(155, 123);
            this.button4.TabIndex = 9;
            this.button4.Text = "Student Grades";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Linen;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(609, 304);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 123);
            this.button2.TabIndex = 7;
            this.button2.Text = "Create Exam\n";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Linen;
            this.button1.Location = new System.Drawing.Point(872, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 123);
            this.button1.TabIndex = 6;
            this.button1.Text = "Question Bank\n\n";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.BackColor = System.Drawing.Color.Transparent;
            this.labelWelcome.Location = new System.Drawing.Point(454, 131);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(0, 16);
            this.labelWelcome.TabIndex = 5;
            this.labelWelcome.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_showExam
            // 
            this.btn_showExam.BackColor = System.Drawing.Color.Linen;
            this.btn_showExam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_showExam.Location = new System.Drawing.Point(164, 304);
            this.btn_showExam.Name = "btn_showExam";
            this.btn_showExam.Size = new System.Drawing.Size(160, 123);
            this.btn_showExam.TabIndex = 10;
            this.btn_showExam.Text = "View Exams\n";
            this.btn_showExam.UseVisualStyleBackColor = false;
            this.btn_showExam.Click += new System.EventHandler(this.btn_showExam_Click);
            // 
            // btn_createQ
            // 
            this.btn_createQ.BackColor = System.Drawing.Color.Linen;
            this.btn_createQ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_createQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_createQ.Location = new System.Drawing.Point(836, 304);
            this.btn_createQ.Name = "btn_createQ";
            this.btn_createQ.Size = new System.Drawing.Size(160, 123);
            this.btn_createQ.TabIndex = 12;
            this.btn_createQ.Text = "Create Question";
            this.btn_createQ.UseVisualStyleBackColor = false;
            this.btn_createQ.Click += new System.EventHandler(this.btn_createQ_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PRO1.Properties.Resources._331;
            this.pictureBox1.Location = new System.Drawing.Point(-5, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1166, 679);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(47, 589);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 48);
            this.button3.TabIndex = 13;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Linen;
            this.panel1.Controls.Add(this.welcomeLbl);
            this.panel1.Location = new System.Drawing.Point(899, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 38);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.AutoSize = true;
            this.welcomeLbl.BackColor = System.Drawing.Color.Linen;
            this.welcomeLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.welcomeLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.welcomeLbl.Location = new System.Drawing.Point(7, 7);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(193, 24);
            this.welcomeLbl.TabIndex = 3;
            this.welcomeLbl.Text = "שלום + USERNAME.";
            this.welcomeLbl.Click += new System.EventHandler(this.welcomeLbl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 676);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_createQ);
            this.Controls.Add(this.btn_showExam);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Lecturer Main Page";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button btn_showExam;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_createQ;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label welcomeLbl;
    }
}

