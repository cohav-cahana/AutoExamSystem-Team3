namespace PRO1
{
    partial class openQuestionPanel
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblQuestionCounter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox1.Location = new System.Drawing.Point(239, 165);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(452, 128);
            this.textBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(287, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(376, 50);
            this.label2.TabIndex = 5;
            this.label2.Text = "Question Number 1";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuestionCounter
            // 
            this.lblQuestionCounter.AutoSize = true;
            this.lblQuestionCounter.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestionCounter.Font = new System.Drawing.Font("Broadway", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionCounter.Location = new System.Drawing.Point(379, 326);
            this.lblQuestionCounter.Name = "lblQuestionCounter";
            this.lblQuestionCounter.Size = new System.Drawing.Size(166, 26);
            this.lblQuestionCounter.TabIndex = 6;
            this.lblQuestionCounter.Text = "שאלה 1 מתוך 20";
            // 
            // openQuestionPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblQuestionCounter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Name = "openQuestionPanel";
            this.Size = new System.Drawing.Size(931, 447);
            this.Load += new System.EventHandler(this.openQuestionPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblQuestionCounter;
    }
}
