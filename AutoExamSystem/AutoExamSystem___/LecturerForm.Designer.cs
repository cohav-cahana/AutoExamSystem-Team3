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
            this.checkBoxRandomTopics = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose a number of questions:  ";
            // 
            // txtQuestionCount
            // 
            this.txtQuestionCount.Location = new System.Drawing.Point(200, 50);
            this.txtQuestionCount.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuestionCount.Name = "txtQuestionCount";
            this.txtQuestionCount.Size = new System.Drawing.Size(76, 20);
            this.txtQuestionCount.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "choose a category";
            // 
            // checkedListBoxTopics
            // 
            this.checkedListBoxTopics.FormattingEnabled = true;
            this.checkedListBoxTopics.Location = new System.Drawing.Point(200, 77);
            this.checkedListBoxTopics.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListBoxTopics.Name = "checkedListBoxTopics";
            this.checkedListBoxTopics.Size = new System.Drawing.Size(91, 34);
            this.checkedListBoxTopics.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "difficulty level:";
            // 
            // cmbDifficulty
            // 
            this.cmbDifficulty.FormattingEnabled = true;
            this.cmbDifficulty.Location = new System.Drawing.Point(200, 150);
            this.cmbDifficulty.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDifficulty.Name = "cmbDifficulty";
            this.cmbDifficulty.Size = new System.Drawing.Size(92, 21);
            this.cmbDifficulty.TabIndex = 5;
            // 
            // btnCreatExam
            // 
            this.btnCreatExam.Location = new System.Drawing.Point(307, 306);
            this.btnCreatExam.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreatExam.Name = "btnCreatExam";
            this.btnCreatExam.Size = new System.Drawing.Size(86, 32);
            this.btnCreatExam.TabIndex = 6;
            this.btnCreatExam.Text = "Creat Exam";
            this.btnCreatExam.UseVisualStyleBackColor = true;
            this.btnCreatExam.Click += new System.EventHandler(this.btnCreatExam_Click);
            // 
            // listBoxExams
            // 
            this.listBoxExams.FormattingEnabled = true;
            this.listBoxExams.Location = new System.Drawing.Point(124, 238);
            this.listBoxExams.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxExams.Name = "listBoxExams";
            this.listBoxExams.Size = new System.Drawing.Size(91, 69);
            this.listBoxExams.TabIndex = 7;
            // 
            // checkBoxRandomTopics
            // 
            this.checkBoxRandomTopics.AutoSize = true;
            this.checkBoxRandomTopics.Location = new System.Drawing.Point(200, 117);
            this.checkBoxRandomTopics.Name = "checkBoxRandomTopics";
            this.checkBoxRandomTopics.Size = new System.Drawing.Size(80, 17);
            this.checkBoxRandomTopics.TabIndex = 8;
            this.checkBoxRandomTopics.Text = "checkBox1";
            this.checkBoxRandomTopics.UseVisualStyleBackColor = true;
            // 
            // LecturerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.checkBoxRandomTopics);
            this.Controls.Add(this.listBoxExams);
            this.Controls.Add(this.btnCreatExam);
            this.Controls.Add(this.cmbDifficulty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkedListBoxTopics);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQuestionCount);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.CheckBox checkBoxRandomTopics;
    }
}