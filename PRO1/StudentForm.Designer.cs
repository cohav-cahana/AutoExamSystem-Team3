using System.Windows.Forms;

namespace PRO1
{
    public partial class StudentForm : Form
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
            this.examBtn = new System.Windows.Forms.Button();
            this.welcomeLbl = new System.Windows.Forms.Label();
            this.gradeBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // examBtn
            // 
            this.examBtn.BackColor = System.Drawing.Color.White;
            this.examBtn.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.examBtn.Location = new System.Drawing.Point(414, 304);
            this.examBtn.Name = "examBtn";
            this.examBtn.Size = new System.Drawing.Size(628, 78);
            this.examBtn.TabIndex = 1;
            this.examBtn.Text = "כפתור לבחירת מבחן";
            this.examBtn.UseVisualStyleBackColor = false;
            this.examBtn.Click += new System.EventHandler(this.examBtn_Click);
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.AutoSize = true;
            this.welcomeLbl.BackColor = System.Drawing.Color.White;
            this.welcomeLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.welcomeLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.welcomeLbl.Location = new System.Drawing.Point(1247, 37);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(189, 26);
            this.welcomeLbl.TabIndex = 2;
            this.welcomeLbl.Text = "שלום + USERNAME";
            // 
            // gradeBtn
            // 
            this.gradeBtn.BackColor = System.Drawing.Color.White;
            this.gradeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gradeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gradeBtn.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.gradeBtn.ForeColor = System.Drawing.Color.Black;
            this.gradeBtn.Location = new System.Drawing.Point(414, 409);
            this.gradeBtn.Name = "gradeBtn";
            this.gradeBtn.Size = new System.Drawing.Size(628, 80);
            this.gradeBtn.TabIndex = 3;
            this.gradeBtn.Text = "כפתור הצגת נתונים ";
            this.gradeBtn.UseVisualStyleBackColor = false;
            // 
            // backBtn
            // 
            this.backBtn.AutoSize = true;
            this.backBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.backBtn.Location = new System.Drawing.Point(12, 29);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(189, 34);
            this.backBtn.TabIndex = 4;
            this.backBtn.Text = "חזרה לדף הכניסה";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
           // this.BackgroundImage = global::PRO1.Properties.Resources.projec1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1448, 803);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.gradeBtn);
            this.Controls.Add(this.welcomeLbl);
            this.Controls.Add(this.examBtn);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button examBtn;
        private Label welcomeLbl;
        private Button gradeBtn;
        private Button backBtn;
    }
}