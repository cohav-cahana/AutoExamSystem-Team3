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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_showExam = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Linen;
            this.button4.Location = new System.Drawing.Point(276, 304);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(160, 123);
            this.button4.TabIndex = 9;
            this.button4.Text = "Student Grades";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Linen;
            this.button3.Location = new System.Drawing.Point(676, 304);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 123);
            this.button3.TabIndex = 8;
            this.button3.Text = "View Statistics\n";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Linen;
            this.button2.Location = new System.Drawing.Point(477, 304);
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
            this.button1.Size = new System.Drawing.Size(160, 123);
            this.button1.TabIndex = 6;
            this.button1.Text = "Question Bank\n\n";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(400, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "(שם המרצה)WELCOM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_showExam
            // 
            this.btn_showExam.BackColor = System.Drawing.Color.Linen;
            this.btn_showExam.Location = new System.Drawing.Point(72, 304);
            this.btn_showExam.Name = "btn_showExam";
            this.btn_showExam.Size = new System.Drawing.Size(160, 123);
            this.btn_showExam.TabIndex = 10;
            this.btn_showExam.Text = "View Exams\n";
            this.btn_showExam.UseVisualStyleBackColor = false;
            this.btn_showExam.Click += new System.EventHandler(this.btn_showExam_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 676);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_showExam);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_showExam;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

