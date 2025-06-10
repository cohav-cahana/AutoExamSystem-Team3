using System.Windows.Forms;

namespace PRO1
{
    public partial class LecturerForm : Form
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
            this.checkedListBoxType = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDifficulty = new System.Windows.Forms.ComboBox();
            this.btnCreatExam = new System.Windows.Forms.Button();
            this.listBoxExams = new System.Windows.Forms.ListBox();
            this.checkBoxRandomTopics = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_topic = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Timer = new System.Windows.Forms.TextBox();
            this.go_back = new System.Windows.Forms.Button();
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
            this.txtQuestionCount.Location = new System.Drawing.Point(267, 62);
            this.txtQuestionCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuestionCount.Name = "txtQuestionCount";
            this.txtQuestionCount.Size = new System.Drawing.Size(100, 22);
            this.txtQuestionCount.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "choose a type";
            // 
            // checkedListBoxType
            // 
            this.checkedListBoxType.FormattingEnabled = true;
            this.checkedListBoxType.Location = new System.Drawing.Point(267, 95);
            this.checkedListBoxType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkedListBoxType.Name = "checkedListBoxType";
            this.checkedListBoxType.Size = new System.Drawing.Size(224, 89);
            this.checkedListBoxType.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "difficulty level:";
            // 
            // cmbDifficulty
            // 
            this.cmbDifficulty.FormattingEnabled = true;
            this.cmbDifficulty.Location = new System.Drawing.Point(267, 233);
            this.cmbDifficulty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDifficulty.Name = "cmbDifficulty";
            this.cmbDifficulty.Size = new System.Drawing.Size(121, 24);
            this.cmbDifficulty.TabIndex = 5;
            // 
            // btnCreatExam
            // 
            this.btnCreatExam.Location = new System.Drawing.Point(409, 377);
            this.btnCreatExam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreatExam.Name = "btnCreatExam";
            this.btnCreatExam.Size = new System.Drawing.Size(115, 39);
            this.btnCreatExam.TabIndex = 6;
            this.btnCreatExam.Text = "Create Exam";
            this.btnCreatExam.UseVisualStyleBackColor = true;
            this.btnCreatExam.Click += new System.EventHandler(this.btnCreatExam_Click);
            // 
            // listBoxExams
            // 
            this.listBoxExams.FormattingEnabled = true;
            this.listBoxExams.ItemHeight = 16;
            this.listBoxExams.Location = new System.Drawing.Point(48, 332);
            this.listBoxExams.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxExams.Name = "listBoxExams";
            this.listBoxExams.Size = new System.Drawing.Size(120, 84);
            this.listBoxExams.TabIndex = 7;
            this.listBoxExams.SelectedIndexChanged += new System.EventHandler(this.listBoxExams_SelectedIndexChanged);
            // 
            // checkBoxRandomTopics
            // 
            this.checkBoxRandomTopics.AutoSize = true;
            this.checkBoxRandomTopics.Location = new System.Drawing.Point(272, 204);
            this.checkBoxRandomTopics.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxRandomTopics.Name = "checkBoxRandomTopics";
            this.checkBoxRandomTopics.Size = new System.Drawing.Size(117, 20);
            this.checkBoxRandomTopics.TabIndex = 8;
            this.checkBoxRandomTopics.Text = "Random types";
            this.checkBoxRandomTopics.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "topic";
            // 
            // cmb_topic
            // 
            this.cmb_topic.FormattingEnabled = true;
            this.cmb_topic.Location = new System.Drawing.Point(267, 25);
            this.cmb_topic.Name = "cmb_topic";
            this.cmb_topic.Size = new System.Drawing.Size(121, 24);
            this.cmb_topic.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Exam duration (in seconds) : ";
            // 
            // txt_Timer
            // 
            this.txt_Timer.Location = new System.Drawing.Point(267, 285);
            this.txt_Timer.Name = "txt_Timer";
            this.txt_Timer.Size = new System.Drawing.Size(100, 22);
            this.txt_Timer.TabIndex = 12;
            // 
            // go_back
            // 
            this.go_back.Location = new System.Drawing.Point(666, 377);
            this.go_back.Name = "go_back";
            this.go_back.Size = new System.Drawing.Size(122, 52);
            this.go_back.TabIndex = 13;
            this.go_back.Text = "back";
            this.go_back.UseVisualStyleBackColor = true;
            this.go_back.Click += new System.EventHandler(this.go_back_Click);
            // 
            // LecturerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 676);
            this.Controls.Add(this.go_back);
            this.Controls.Add(this.txt_Timer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_topic);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBoxRandomTopics);
            this.Controls.Add(this.listBoxExams);
            this.Controls.Add(this.btnCreatExam);
            this.Controls.Add(this.cmbDifficulty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkedListBoxType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQuestionCount);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.CheckedListBox checkedListBoxType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDifficulty;
        private System.Windows.Forms.Button btnCreatExam;
        private System.Windows.Forms.ListBox listBoxExams;
        private System.Windows.Forms.CheckBox checkBoxRandomTopics;
        private Label label4;
        private ComboBox cmb_topic;
        private Label label5;
        private TextBox txt_Timer;
        private Button go_back;
    }
}