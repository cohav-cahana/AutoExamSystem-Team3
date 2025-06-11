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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // examList
            // 
            this.examList.FormattingEnabled = true;
            this.examList.Location = new System.Drawing.Point(307, 152);
            this.examList.Name = "examList";
            this.examList.Size = new System.Drawing.Size(501, 24);
            this.examList.TabIndex = 0;
            this.examList.SelectedIndexChanged += new System.EventHandler(this.examList_SelectedIndexChanged);
            // 
            // topLbl
            // 
            this.topLbl.AutoSize = true;
            this.topLbl.BackColor = System.Drawing.Color.Transparent;
            this.topLbl.Location = new System.Drawing.Point(453, 104);
            this.topLbl.Name = "topLbl";
            this.topLbl.Size = new System.Drawing.Size(207, 16);
            this.topLbl.TabIndex = 1;
            this.topLbl.Text = "Select an exam from the list below";
            // 
            // topicLbl
            // 
            this.topicLbl.AutoSize = true;
            this.topicLbl.BackColor = System.Drawing.Color.Transparent;
            this.topicLbl.Location = new System.Drawing.Point(195, 230);
            this.topicLbl.Name = "topicLbl";
            this.topicLbl.Size = new System.Drawing.Size(76, 16);
            this.topicLbl.TabIndex = 2;
            this.topicLbl.Text = ":Exam topic";
            this.topicLbl.Visible = false;
            this.topicLbl.Click += new System.EventHandler(this.topicLbl_Click);
            // 
            // topicPlaceholder
            // 
            this.topicPlaceholder.AutoSize = true;
            this.topicPlaceholder.BackColor = System.Drawing.Color.Transparent;
            this.topicPlaceholder.Location = new System.Drawing.Point(519, 230);
            this.topicPlaceholder.Name = "topicPlaceholder";
            this.topicPlaceholder.Size = new System.Drawing.Size(80, 16);
            this.topicPlaceholder.TabIndex = 3;
            this.topicPlaceholder.Text = "Placeholder";
            this.topicPlaceholder.Visible = false;
            this.topicPlaceholder.Click += new System.EventHandler(this.topicPlaceholder_Click);
            // 
            // numQuestionLbl
            // 
            this.numQuestionLbl.AutoSize = true;
            this.numQuestionLbl.BackColor = System.Drawing.Color.Transparent;
            this.numQuestionLbl.Location = new System.Drawing.Point(195, 337);
            this.numQuestionLbl.Name = "numQuestionLbl";
            this.numQuestionLbl.Size = new System.Drawing.Size(130, 16);
            this.numQuestionLbl.TabIndex = 4;
            this.numQuestionLbl.Text = ":Amount of questions";
            this.numQuestionLbl.Visible = false;
            this.numQuestionLbl.Click += new System.EventHandler(this.numQuestionLbl_Click);
            // 
            // numQuestionPlaceholder
            // 
            this.numQuestionPlaceholder.AutoSize = true;
            this.numQuestionPlaceholder.BackColor = System.Drawing.Color.Transparent;
            this.numQuestionPlaceholder.Location = new System.Drawing.Point(519, 337);
            this.numQuestionPlaceholder.Name = "numQuestionPlaceholder";
            this.numQuestionPlaceholder.Size = new System.Drawing.Size(80, 16);
            this.numQuestionPlaceholder.TabIndex = 5;
            this.numQuestionPlaceholder.Text = "Placeholder";
            this.numQuestionPlaceholder.Visible = false;
            // 
            // difficultyLbl
            // 
            this.difficultyLbl.AutoSize = true;
            this.difficultyLbl.BackColor = System.Drawing.Color.Transparent;
            this.difficultyLbl.Location = new System.Drawing.Point(195, 283);
            this.difficultyLbl.Name = "difficultyLbl";
            this.difficultyLbl.Size = new System.Drawing.Size(59, 16);
            this.difficultyLbl.TabIndex = 6;
            this.difficultyLbl.Text = ":Difficulty";
            this.difficultyLbl.Visible = false;
            // 
            // difficultyPlaceholder
            // 
            this.difficultyPlaceholder.AutoSize = true;
            this.difficultyPlaceholder.BackColor = System.Drawing.Color.Transparent;
            this.difficultyPlaceholder.Location = new System.Drawing.Point(522, 283);
            this.difficultyPlaceholder.Name = "difficultyPlaceholder";
            this.difficultyPlaceholder.Size = new System.Drawing.Size(80, 16);
            this.difficultyPlaceholder.TabIndex = 7;
            this.difficultyPlaceholder.Text = "Placeholder";
            this.difficultyPlaceholder.Visible = false;
            this.difficultyPlaceholder.Click += new System.EventHandler(this.difficultyPlaceholder_Click);
            // 
            // durationLbl
            // 
            this.durationLbl.AutoSize = true;
            this.durationLbl.BackColor = System.Drawing.Color.Transparent;
            this.durationLbl.Location = new System.Drawing.Point(198, 390);
            this.durationLbl.Name = "durationLbl";
            this.durationLbl.Size = new System.Drawing.Size(60, 16);
            this.durationLbl.TabIndex = 8;
            this.durationLbl.Text = ":Duration";
            this.durationLbl.Visible = false;
            // 
            // durationPlaceholder
            // 
            this.durationPlaceholder.AutoSize = true;
            this.durationPlaceholder.BackColor = System.Drawing.Color.Transparent;
            this.durationPlaceholder.Location = new System.Drawing.Point(522, 389);
            this.durationPlaceholder.Name = "durationPlaceholder";
            this.durationPlaceholder.Size = new System.Drawing.Size(80, 16);
            this.durationPlaceholder.TabIndex = 9;
            this.durationPlaceholder.Text = "Placeholder";
            this.durationPlaceholder.Visible = false;
            // 
            // startExamBtn
            // 
            this.startExamBtn.Location = new System.Drawing.Point(599, 406);
            this.startExamBtn.Name = "startExamBtn";
            this.startExamBtn.Size = new System.Drawing.Size(225, 52);
            this.startExamBtn.TabIndex = 10;
            this.startExamBtn.Text = "Start Selected Exam";
            this.startExamBtn.UseVisualStyleBackColor = true;
            this.startExamBtn.Click += new System.EventHandler(this.startExamBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(198, 483);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(122, 52);
            this.backBtn.TabIndex = 11;
            this.backBtn.Text = "Back ";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Linen;
            this.panel1.Controls.Add(this.startExamBtn);
            this.panel1.Location = new System.Drawing.Point(143, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 485);
            this.panel1.TabIndex = 19;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PRO1.Properties.Resources._332;
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1158, 674);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ExamSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 676);
            this.Controls.Add(this.backBtn);
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
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ExamSelection";
            this.Text = "ExamSelection";
            this.Load += new System.EventHandler(this.ExamSelection_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}