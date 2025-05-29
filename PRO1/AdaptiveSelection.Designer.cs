namespace PRO1
{
    partial class AdaptiveSelection
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
            this.typeofQ = new System.Windows.Forms.ComboBox();
            this.numberQuestion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // typeofQ
            // 
            this.typeofQ.FormattingEnabled = true;
            this.typeofQ.Items.AddRange(new object[] {
            "אלגורתמים ",
            "בדיקות נתונים",
            "סטטיסטיקה",
            "מבנה נתונים"});
            this.typeofQ.Location = new System.Drawing.Point(553, 299);
            this.typeofQ.Name = "typeofQ";
            this.typeofQ.Size = new System.Drawing.Size(303, 39);
            this.typeofQ.TabIndex = 0;
            this.typeofQ.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // numberQuestion
            // 
            this.numberQuestion.Location = new System.Drawing.Point(553, 420);
            this.numberQuestion.Name = "numberQuestion";
            this.numberQuestion.Size = new System.Drawing.Size(303, 38);
            this.numberQuestion.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = " Type of Question";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "How Many Question";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1060, 1000);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 84);
            this.button1.TabIndex = 4;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Clickstart);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(72, 1010);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 84);
            this.button2.TabIndex = 5;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AdaptiveSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 1147);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberQuestion);
            this.Controls.Add(this.typeofQ);
            this.Name = "AdaptiveSelection";
            this.Text = "AdaptiveSelection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox typeofQ;
        private System.Windows.Forms.TextBox numberQuestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}