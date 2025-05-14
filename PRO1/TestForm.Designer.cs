namespace PRO1
{
    partial class TestForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.examTimer = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Freestyle Script", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(262, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(550, 142);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to Your Adaptive Test\n\n";
            // 
            // examTimer
            // 
            this.examTimer.Interval = 1000;
            this.examTimer.Tick += new System.EventHandler(this.examTimer_Tick);
            // 
            // lblTimer
            // 
            this.lblTimer.BackColor = System.Drawing.Color.ForestGreen;
            this.lblTimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTimer.Font = new System.Drawing.Font("Engravers MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.LightGreen;
            this.lblTimer.Location = new System.Drawing.Point(884, 44);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(143, 31);
            this.lblTimer.TabIndex = 4;
            this.lblTimer.Text = "00:00\r\n";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblTimer.Click += new System.EventHandler(this.lblTimer_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(96, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(931, 447);
            this.panel1.TabIndex = 6;
            // 
            // TestForm
            // 
            this.AccessibleName = "test";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::PRO1.Properties.Resources.projec1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1099, 637);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TestForm";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Text = "Test";
            this.Load += new System.EventHandler(this.TestFrom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer examTimer;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Panel panel1;
    }
}