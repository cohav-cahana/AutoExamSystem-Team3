namespace PRO1
{
    partial class TrueFalseUserControl
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
            this.lblQuestionCounter = new System.Windows.Forms.Label();
            this.TrueButton = new System.Windows.Forms.RadioButton();
            this.FalseButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // questionLbl
            // 
            this.questionLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.questionLbl.BackColor = System.Drawing.Color.Transparent;
            this.questionLbl.Font = new System.Drawing.Font("Britannic Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLbl.ForeColor = System.Drawing.Color.Black;
            this.questionLbl.Location = new System.Drawing.Point(116, 45);
            this.questionLbl.Name = "questionLbl";
            this.questionLbl.Size = new System.Drawing.Size(672, 84);
            this.questionLbl.TabIndex = 4;
            this.questionLbl.Text = "Question Number 1";
            this.questionLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuestionCounter
            // 
            this.lblQuestionCounter.AutoSize = true;
            this.lblQuestionCounter.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestionCounter.Font = new System.Drawing.Font("Broadway", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionCounter.Location = new System.Drawing.Point(320, 384);
            this.lblQuestionCounter.Name = "lblQuestionCounter";
            this.lblQuestionCounter.Size = new System.Drawing.Size(262, 26);
            this.lblQuestionCounter.TabIndex = 7;
            this.lblQuestionCounter.Text = "Question X out of Y";
            // 
            // TrueButton
            // 
            this.TrueButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.TrueButton.BackColor = System.Drawing.Color.Turquoise;
            this.TrueButton.Location = new System.Drawing.Point(271, 248);
            this.TrueButton.Name = "TrueButton";
            this.TrueButton.Size = new System.Drawing.Size(136, 56);
            this.TrueButton.TabIndex = 8;
            this.TrueButton.TabStop = true;
            this.TrueButton.Text = "True";
            this.TrueButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TrueButton.UseVisualStyleBackColor = false;
            this.TrueButton.CheckedChanged += new System.EventHandler(this.TrueButton_CheckedChanged);
            // 
            // FalseButton
            // 
            this.FalseButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.FalseButton.BackColor = System.Drawing.Color.Turquoise;
            this.FalseButton.Location = new System.Drawing.Point(505, 248);
            this.FalseButton.Name = "FalseButton";
            this.FalseButton.Size = new System.Drawing.Size(127, 56);
            this.FalseButton.TabIndex = 9;
            this.FalseButton.TabStop = true;
            this.FalseButton.Text = "False";
            this.FalseButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FalseButton.UseVisualStyleBackColor = false;
            this.FalseButton.CheckedChanged += new System.EventHandler(this.FalseButton_CheckedChanged);
            // 
            // TrueFalseUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.FalseButton);
            this.Controls.Add(this.TrueButton);
            this.Controls.Add(this.lblQuestionCounter);
            this.Controls.Add(this.questionLbl);
            this.Location = new System.Drawing.Point(282, 19);
            this.Name = "TrueFalseUserControl";
            this.Size = new System.Drawing.Size(931, 447);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionLbl;
        private System.Windows.Forms.Label lblQuestionCounter;
        private System.Windows.Forms.RadioButton TrueButton;
        private System.Windows.Forms.RadioButton FalseButton;
    }
}
