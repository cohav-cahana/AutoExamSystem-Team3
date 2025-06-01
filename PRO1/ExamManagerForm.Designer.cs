namespace PRO1
{
    partial class ExamManagerForm
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
            this.lstExams = new System.Windows.Forms.ListBox();
            this.btnDeleteExam = new System.Windows.Forms.Button();
            this.lstExamQuestions = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "list of Exams";
            // 
            // lstExams
            // 
            this.lstExams.FormattingEnabled = true;
            this.lstExams.ItemHeight = 16;
            this.lstExams.Location = new System.Drawing.Point(208, 157);
            this.lstExams.Name = "lstExams";
            this.lstExams.Size = new System.Drawing.Size(280, 244);
            this.lstExams.TabIndex = 1;
            this.lstExams.SelectedIndexChanged += new System.EventHandler(this.lstExams_SelectedIndexChanged);
            // 
            // btnDeleteExam
            // 
            this.btnDeleteExam.Location = new System.Drawing.Point(426, 466);
            this.btnDeleteExam.Name = "btnDeleteExam";
            this.btnDeleteExam.Size = new System.Drawing.Size(116, 37);
            this.btnDeleteExam.TabIndex = 2;
            this.btnDeleteExam.Text = "Delete Exam";
            this.btnDeleteExam.UseVisualStyleBackColor = true;
            this.btnDeleteExam.Click += new System.EventHandler(this.btnDeleteExam_Click);
            // 
            // lstExamQuestions
            // 
            this.lstExamQuestions.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lstExamQuestions.FormattingEnabled = true;
            this.lstExamQuestions.ItemHeight = 19;
            this.lstExamQuestions.Location = new System.Drawing.Point(577, 157);
            this.lstExamQuestions.Name = "lstExamQuestions";
            this.lstExamQuestions.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstExamQuestions.Size = new System.Drawing.Size(355, 251);
            this.lstExamQuestions.TabIndex = 3;
            // 
            // ExamManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 641);
            this.Controls.Add(this.lstExamQuestions);
            this.Controls.Add(this.btnDeleteExam);
            this.Controls.Add(this.lstExams);
            this.Controls.Add(this.label1);
            this.Name = "ExamManagerForm";
            this.Text = "ExamManagerForm";
            this.Load += new System.EventHandler(this.ExamManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstExams;
        private System.Windows.Forms.Button btnDeleteExam;
        private System.Windows.Forms.ListBox lstExamQuestions;
    }
}