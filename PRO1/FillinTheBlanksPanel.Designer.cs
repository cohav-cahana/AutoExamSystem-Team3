﻿namespace PRO1
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
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.questionLbl.Click += new System.EventHandler(this.questionLbl_Click);
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
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(149, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 433);
            this.panel1.TabIndex = 8;
            // 
            // FillinTheBlanksPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblQuestionCounter);
            this.Controls.Add(this.answerText);
            this.Controls.Add(this.questionLbl);
            this.Controls.Add(this.panel1);
            this.Name = "FillinTheBlanksPanel";
            this.Size = new System.Drawing.Size(1064, 652);
            this.Load += new System.EventHandler(this.FillinTheBlanksPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionLbl;
        private System.Windows.Forms.TextBox answerText;
        private System.Windows.Forms.Label lblQuestionCounter;
        private System.Windows.Forms.Panel panel1;
    }
}
