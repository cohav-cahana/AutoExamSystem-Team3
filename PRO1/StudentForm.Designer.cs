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
            this.backBtn = new System.Windows.Forms.Button();
            this.gradeBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // examBtn
            // 
            this.examBtn.BackColor = System.Drawing.Color.Linen;
            this.examBtn.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.examBtn.Image = global::PRO1.Properties.Resources.icons8_user_50;
            this.examBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.examBtn.Location = new System.Drawing.Point(581, 245);
            this.examBtn.Name = "examBtn";
            this.examBtn.Size = new System.Drawing.Size(338, 114);
            this.examBtn.TabIndex = 1;
            this.examBtn.Text = "Start Test";
            this.examBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.examBtn.UseVisualStyleBackColor = false;
            this.examBtn.Click += new System.EventHandler(this.examBtn_Click);
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.AutoSize = true;
            this.welcomeLbl.BackColor = System.Drawing.Color.Linen;
            this.welcomeLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.welcomeLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.welcomeLbl.Location = new System.Drawing.Point(903, 61);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(193, 24);
            this.welcomeLbl.TabIndex = 2;
            this.welcomeLbl.Text = "שלום + USERNAME.";
            this.welcomeLbl.Click += new System.EventHandler(this.welcomeLbl_Click);
            // 
            // backBtn
            // 
            this.backBtn.AutoSize = true;
            this.backBtn.BackColor = System.Drawing.Color.Linen;
            this.backBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.backBtn.Location = new System.Drawing.Point(12, 575);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(189, 34);
            this.backBtn.TabIndex = 4;
            this.backBtn.Text = "חזרה לדף הכניסה";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // gradeBtn
            // 
            this.gradeBtn.BackColor = System.Drawing.Color.Linen;
            this.gradeBtn.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.gradeBtn.ForeColor = System.Drawing.Color.Black;
            this.gradeBtn.Image = global::PRO1.Properties.Resources.icons8_test_50;
            this.gradeBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.gradeBtn.Location = new System.Drawing.Point(266, 245);
            this.gradeBtn.Name = "gradeBtn";
            this.gradeBtn.Size = new System.Drawing.Size(293, 114);
            this.gradeBtn.TabIndex = 3;
            this.gradeBtn.Text = " My Info";
            this.gradeBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.gradeBtn.UseVisualStyleBackColor = false;
            this.gradeBtn.Click += new System.EventHandler(this.gradeBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PRO1.Properties.Resources._333;
            this.pictureBox2.Location = new System.Drawing.Point(-16, -5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1215, 651);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Linen;
            this.panel1.Location = new System.Drawing.Point(898, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 38);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1151, 641);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.gradeBtn);
            this.Controls.Add(this.welcomeLbl);
            this.Controls.Add(this.examBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button gradeBtn;
        private Button backBtn;
        private Label welcomeLbl;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Button examBtn;
    }
}