namespace AutoExamSystem___
{
    partial class LecturerForm
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
            this.txtQuestionCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedListBoxTopics = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDifficulty = new System.Windows.Forms.ComboBox();
            this.btnCreatExam = new System.Windows.Forms.Button();
            this.listBoxExams = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose a number of questions:  ";
            // 
            // txtQuestionCount
            // 
            this.txtQuestionCount.Location = new System.Drawing.Point(266, 62);
            this.txtQuestionCount.Name = "txtQuestionCount";
            this.txtQuestionCount.Size = new System.Drawing.Size(100, 22);
            this.txtQuestionCount.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "choose a category";
            // 
            // checkedListBoxTopics
            // 
            this.checkedListBoxTopics.FormattingEnabled = true;
            this.checkedListBoxTopics.Location = new System.Drawing.Point(266, 95);
            this.checkedListBoxTopics.Name = "checkedListBoxTopics";
            this.checkedListBoxTopics.Size = new System.Drawing.Size(120, 55);
            this.checkedListBoxTopics.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "difficulty level:";
            // 
            // cmbDifficulty
            // 
            this.cmbDifficulty.FormattingEnabled = true;
            this.cmbDifficulty.Location = new System.Drawing.Point(266, 184);
            this.cmbDifficulty.Name = "cmbDifficulty";
            this.cmbDifficulty.Size = new System.Drawing.Size(121, 24);
            this.cmbDifficulty.TabIndex = 5;
            // 
            // btnCreatExam
            // 
            this.btnCreatExam.Location = new System.Drawing.Point(409, 377);
            this.btnCreatExam.Name = "btnCreatExam";
            this.btnCreatExam.Size = new System.Drawing.Size(115, 39);
            this.btnCreatExam.TabIndex = 6;
            this.btnCreatExam.Text = "Creat Exam";
            this.btnCreatExam.UseVisualStyleBackColor = true;
            this.btnCreatExam.Click += new System.EventHandler(this.btnCreatExam_Click);
            // 
            // listBoxExams
            // 
            this.listBoxExams.FormattingEnabled = true;
            this.listBoxExams.ItemHeight = 16;
            this.listBoxExams.Location = new System.Drawing.Point(165, 293);
            this.listBoxExams.Name = "listBoxExams";
            this.listBoxExams.Size = new System.Drawing.Size(120, 84);
            this.listBoxExams.TabIndex = 7;
            // 
            // LecturerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxExams);
            this.Controls.Add(this.btnCreatExam);
            this.Controls.Add(this.cmbDifficulty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkedListBoxTopics);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQuestionCount);
            this.Controls.Add(this.label1);
            this.Name = "LecturerForm";
            this.Text = "LecturerForm";
            this.Load += new System.EventHandler(this.LecturerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuestionCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkedListBoxTopics;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDifficulty;
        private System.Windows.Forms.Button btnCreatExam;
        private System.Windows.Forms.ListBox listBoxExams;
    }
}