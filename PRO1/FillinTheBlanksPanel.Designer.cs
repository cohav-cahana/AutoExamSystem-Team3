namespace PRO1
{
    partial class FillinTheBlanksPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.questionLbl = new System.Windows.Forms.Label();
            this.answerText = new System.Windows.Forms.TextBox();
            this.lblQuestionCounter = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // questionLbl
            // 
            this.questionLbl.Font = new System.Drawing.Font("Elephant", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLbl.Location = new System.Drawing.Point(207, 153);
            this.questionLbl.Name = "questionLbl";
            this.questionLbl.Size = new System.Drawing.Size(672, 84);
            this.questionLbl.TabIndex = 0;
            this.questionLbl.Text = "Question order \r\n";
            this.questionLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // answerText
            // 
            this.answerText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.answerText.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.answerText.Location = new System.Drawing.Point(284, 294);
            this.answerText.Multiline = true;
            this.answerText.Name = "answerText";
            this.answerText.Size = new System.Drawing.Size(489, 107);
            this.answerText.TabIndex = 1;
            // 
            // lblQuestionCounter
            // 
            this.lblQuestionCounter.AutoSize = true;
            this.lblQuestionCounter.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionCounter.Location = new System.Drawing.Point(439, 475);
            this.lblQuestionCounter.Name = "lblQuestionCounter";
            this.lblQuestionCounter.Size = new System.Drawing.Size(192, 30);
            this.lblQuestionCounter.TabIndex = 2;
            this.lblQuestionCounter.Text = "שאלה 1 מתוך 20";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PRO1.Properties.Resources._338;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1173, 720);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FillinTheBlanksPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblQuestionCounter);
            this.Controls.Add(this.answerText);
            this.Controls.Add(this.questionLbl);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FillinTheBlanksPanel";
            this.Size = new System.Drawing.Size(1179, 723);
            this.Load += new System.EventHandler(this.FillinTheBlanksPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionLbl;
        private System.Windows.Forms.TextBox answerText;
        private System.Windows.Forms.Label lblQuestionCounter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
