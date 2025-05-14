namespace PRO1
{
    partial class GradeFrom
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvScores = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDifficulty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScores)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Freestyle Script", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(406, 34);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(448, 190);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Your Exam Results\r\n\r\n";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 700);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1317, 44);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(1302, 38);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "Test Project";
            // 
            // dgvScores
            // 
            this.dgvScores.AllowUserToAddRows = false;
            this.dgvScores.AllowUserToDeleteRows = false;
            this.dgvScores.BackgroundColor = System.Drawing.Color.White;
            this.dgvScores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.colDate,
            this.colScore,
            this.colSubject,
            this.colDifficulty});
            this.dgvScores.Location = new System.Drawing.Point(295, 162);
            this.dgvScores.Name = "dgvScores";
            this.dgvScores.ReadOnly = true;
            this.dgvScores.RowHeadersWidth = 51;
            this.dgvScores.RowTemplate.Height = 24;
            this.dgvScores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvScores.Size = new System.Drawing.Size(671, 513);
            this.dgvScores.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "שם";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // colDate
            // 
            this.colDate.HeaderText = "ת\"ז";
            this.colDate.MinimumWidth = 6;
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            this.colDate.Width = 125;
            // 
            // colScore
            // 
            this.colScore.HeaderText = "ציון";
            this.colScore.MinimumWidth = 6;
            this.colScore.Name = "colScore";
            this.colScore.ReadOnly = true;
            this.colScore.Width = 125;
            // 
            // colSubject
            // 
            this.colSubject.HeaderText = "מקצוע";
            this.colSubject.MinimumWidth = 6;
            this.colSubject.Name = "colSubject";
            this.colSubject.ReadOnly = true;
            this.colSubject.Width = 125;
            // 
            // colDifficulty
            // 
            this.colDifficulty.HeaderText = "רמת קושי";
            this.colDifficulty.MinimumWidth = 6;
            this.colDifficulty.Name = "colDifficulty";
            this.colDifficulty.ReadOnly = true;
            this.colDifficulty.Width = 125;
            // 
            // GradeFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PRO1.Properties.Resources.projec1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1317, 744);
            this.Controls.Add(this.dgvScores);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.linkLabel1);
            this.Name = "GradeFrom";
            this.Text = "GradeFrom";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataGridView dgvScores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDifficulty;
    }
}