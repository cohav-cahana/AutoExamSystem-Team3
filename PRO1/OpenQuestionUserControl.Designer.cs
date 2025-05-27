namespace PRO1
{
    partial class OpenQuestionUserControl
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
            this.answerText = new System.Windows.Forms.TextBox();
            this.questionLbl = new System.Windows.Forms.Label();
            this.lblQuestionCounter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // answerText
            // 
            this.answerText.BackColor = System.Drawing.Color.White;
            this.answerText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.answerText.Location = new System.Drawing.Point(239, 165);
            this.answerText.Multiline = true;
            this.answerText.Name = "answerText";
            this.answerText.Size = new System.Drawing.Size(452, 128);
            this.answerText.TabIndex = 4;
            // 
            // questionLbl
            // 
            this.questionLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.questionLbl.BackColor = System.Drawing.Color.Transparent;
            this.questionLbl.Font = new System.Drawing.Font("Britannic Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLbl.ForeColor = System.Drawing.Color.Black;
            this.questionLbl.Location = new System.Drawing.Point(125, 38);
            this.questionLbl.Name = "questionLbl";
            this.questionLbl.Size = new System.Drawing.Size(672, 84);
            this.questionLbl.TabIndex = 5;
            this.questionLbl.Text = "Question Number 1";
            this.questionLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuestionCounter
            // 
            this.lblQuestionCounter.AutoSize = true;
            this.lblQuestionCounter.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestionCounter.Font = new System.Drawing.Font("Broadway", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionCounter.Location = new System.Drawing.Point(385, 368);
            this.lblQuestionCounter.Name = "lblQuestionCounter";
            this.lblQuestionCounter.Size = new System.Drawing.Size(166, 26);
            this.lblQuestionCounter.TabIndex = 6;
            this.lblQuestionCounter.Text = "שאלה 1 מתוך 20";
            // 
            // OpenQuestionUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblQuestionCounter);
            this.Controls.Add(this.questionLbl);
            this.Controls.Add(this.answerText);
            this.Name = "OpenQuestionUserControl";
            this.Size = new System.Drawing.Size(931, 447);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox answerText;
        private System.Windows.Forms.Label questionLbl;
        private System.Windows.Forms.Label lblQuestionCounter;
    }
}