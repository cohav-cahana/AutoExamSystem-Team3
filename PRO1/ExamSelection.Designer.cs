namespace PRO1
{
    partial class ExamSelection
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
            this.examList = new System.Windows.Forms.ComboBox();
            this.topLbl = new System.Windows.Forms.Label();
            this.topicLbl = new System.Windows.Forms.Label();
            this.topicPlaceholder = new System.Windows.Forms.Label();
            this.numQuestionLbl = new System.Windows.Forms.Label();
            this.numQuestionPlaceholder = new System.Windows.Forms.Label();
            this.difficultyLbl = new System.Windows.Forms.Label();
            this.difficultyPlaceholder = new System.Windows.Forms.Label();
            this.durationLbl = new System.Windows.Forms.Label();
            this.durationPlaceholder = new System.Windows.Forms.Label();
            this.startExamBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.AdaptiveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // examList
            // 
            this.examList.FormattingEnabled = true;
            this.examList.Location = new System.Drawing.Point(145, 86);
            this.examList.Name = "examList";
            this.examList.Size = new System.Drawing.Size(501, 24);
            this.examList.TabIndex = 0;
            this.examList.SelectedIndexChanged += new System.EventHandler(this.examList_SelectedIndexChanged);
            // 
            // topLbl
            // 
            this.topLbl.AutoSize = true;
            this.topLbl.Location = new System.Drawing.Point(293, 30);
            this.topLbl.Name = "topLbl";
            this.topLbl.Size = new System.Drawing.Size(207, 16);
            this.topLbl.TabIndex = 1;
            this.topLbl.Text = "Select an exam from the list below";
            // 
            // topicLbl
            // 
            this.topicLbl.AutoSize = true;
            this.topicLbl.Location = new System.Drawing.Point(33, 156);
            this.topicLbl.Name = "topicLbl";
            this.topicLbl.Size = new System.Drawing.Size(76, 16);
            this.topicLbl.TabIndex = 2;
            this.topicLbl.Text = "Exam topic:";
            this.topicLbl.Visible = false;
            // 
            // topicPlaceholder
            // 
            this.topicPlaceholder.AutoSize = true;
            this.topicPlaceholder.Location = new System.Drawing.Point(357, 156);
            this.topicPlaceholder.Name = "topicPlaceholder";
            this.topicPlaceholder.Size = new System.Drawing.Size(80, 16);
            this.topicPlaceholder.TabIndex = 3;
            this.topicPlaceholder.Text = "Placeholder";
            this.topicPlaceholder.Visible = false;
            // 
            // numQuestionLbl
            // 
            this.numQuestionLbl.AutoSize = true;
            this.numQuestionLbl.Location = new System.Drawing.Point(33, 263);
            this.numQuestionLbl.Name = "numQuestionLbl";
            this.numQuestionLbl.Size = new System.Drawing.Size(130, 16);
            this.numQuestionLbl.TabIndex = 4;
            this.numQuestionLbl.Text = "Amount of questions:";
            this.numQuestionLbl.Visible = false;
            // 
            // numQuestionPlaceholder
            // 
            this.numQuestionPlaceholder.AutoSize = true;
            this.numQuestionPlaceholder.Location = new System.Drawing.Point(357, 263);
            this.numQuestionPlaceholder.Name = "numQuestionPlaceholder";
            this.numQuestionPlaceholder.Size = new System.Drawing.Size(80, 16);
            this.numQuestionPlaceholder.TabIndex = 5;
            this.numQuestionPlaceholder.Text = "Placeholder";
            this.numQuestionPlaceholder.Visible = false;
            // 
            // difficultyLbl
            // 
            this.difficultyLbl.AutoSize = true;
            this.difficultyLbl.Location = new System.Drawing.Point(33, 209);
            this.difficultyLbl.Name = "difficultyLbl";
            this.difficultyLbl.Size = new System.Drawing.Size(59, 16);
            this.difficultyLbl.TabIndex = 6;
            this.difficultyLbl.Text = "Difficulty:";
            this.difficultyLbl.Visible = false;
            // 
            // difficultyPlaceholder
            // 
            this.difficultyPlaceholder.AutoSize = true;
            this.difficultyPlaceholder.Location = new System.Drawing.Point(360, 209);
            this.difficultyPlaceholder.Name = "difficultyPlaceholder";
            this.difficultyPlaceholder.Size = new System.Drawing.Size(80, 16);
            this.difficultyPlaceholder.TabIndex = 7;
            this.difficultyPlaceholder.Text = "Placeholder";
            this.difficultyPlaceholder.Visible = false;
            // 
            // durationLbl
            // 
            this.durationLbl.AutoSize = true;
            this.durationLbl.Location = new System.Drawing.Point(36, 316);
            this.durationLbl.Name = "durationLbl";
            this.durationLbl.Size = new System.Drawing.Size(60, 16);
            this.durationLbl.TabIndex = 8;
            this.durationLbl.Text = "Duration:";
            this.durationLbl.Visible = false;
            // 
            // durationPlaceholder
            // 
            this.durationPlaceholder.AutoSize = true;
            this.durationPlaceholder.Location = new System.Drawing.Point(360, 315);
            this.durationPlaceholder.Name = "durationPlaceholder";
            this.durationPlaceholder.Size = new System.Drawing.Size(80, 16);
            this.durationPlaceholder.TabIndex = 9;
            this.durationPlaceholder.Text = "Placeholder";
            this.durationPlaceholder.Visible = false;
            // 
            // startExamBtn
            // 
            this.startExamBtn.Location = new System.Drawing.Point(625, 409);
            this.startExamBtn.Name = "startExamBtn";
            this.startExamBtn.Size = new System.Drawing.Size(152, 29);
            this.startExamBtn.TabIndex = 10;
            this.startExamBtn.Text = "Start Selected Exam";
            this.startExamBtn.UseVisualStyleBackColor = true;
            this.startExamBtn.Click += new System.EventHandler(this.startExamBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(36, 409);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(161, 23);
            this.backBtn.TabIndex = 11;
            this.backBtn.Text = "Back To Student Page";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // AdaptiveButton
            // 
            this.AdaptiveButton.Location = new System.Drawing.Point(323, 406);
            this.AdaptiveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AdaptiveButton.Name = "AdaptiveButton";
            this.AdaptiveButton.Size = new System.Drawing.Size(158, 29);
            this.AdaptiveButton.TabIndex = 12;
            this.AdaptiveButton.Text = "Start Adaptive Exam";
            this.AdaptiveButton.UseVisualStyleBackColor = true;
            this.AdaptiveButton.Click += new System.EventHandler(this.AdaptiveButton_Click);
            // 
            // ExamSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AdaptiveButton);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.startExamBtn);
            this.Controls.Add(this.durationPlaceholder);
            this.Controls.Add(this.durationLbl);
            this.Controls.Add(this.difficultyPlaceholder);
            this.Controls.Add(this.difficultyLbl);
            this.Controls.Add(this.numQuestionPlaceholder);
            this.Controls.Add(this.numQuestionLbl);
            this.Controls.Add(this.topicPlaceholder);
            this.Controls.Add(this.topicLbl);
            this.Controls.Add(this.topLbl);
            this.Controls.Add(this.examList);
            this.Name = "ExamSelection";
            this.Text = "ExamSelection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox examList;
        private System.Windows.Forms.Label topLbl;
        private System.Windows.Forms.Label topicLbl;
        private System.Windows.Forms.Label topicPlaceholder;
        private System.Windows.Forms.Label numQuestionLbl;
        private System.Windows.Forms.Label numQuestionPlaceholder;
        private System.Windows.Forms.Label difficultyLbl;
        private System.Windows.Forms.Label difficultyPlaceholder;
        private System.Windows.Forms.Label durationLbl;
        private System.Windows.Forms.Label durationPlaceholder;
        private System.Windows.Forms.Button startExamBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button AdaptiveButton;
    }
}