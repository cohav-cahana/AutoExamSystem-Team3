using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Windows.Forms;

namespace PRO1
{
    public partial class GradeFormTeacher : Form
    {

        private int high = 0;
        private int mid = 0;
        private int low = 0;

        public GradeFormTeacher()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.GradeFormTeacher_Load);
            StyleWarmButton(btnShowChart);
            StyleWarmButton(btn_back2);



        }

        private void dgvScores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private async void GradeFormTeacher_Load(object sender, EventArgs e)
        {
            dgvScores.Rows.Clear();

            FirebaseHelper firebaseHelper = new FirebaseHelper();

            try
            {
                var allGrades = await firebaseHelper.GetAllGradesAsync();


                high = 0;
                mid = 0;
                low = 0;

                foreach (var (username, userId, examResult) in allGrades)
                {
                    dgvScores.Rows.Add(
                        username,
                        userId,
                        examResult.Score,
                        examResult.Subject,
                        examResult.Level
                    );


                    if (examResult.Score >= 85)
                        high++;
                    else if (examResult.Score >= 56)
                        mid++;
                    else
                        low++;
                }
                dgvScores.ClearSelection();
                dgvScores.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Error loading grades: " + ex.Message);
            }
        }
        private void StyleWarmButton(Button button)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.BackColor = ColorTranslator.FromHtml("#D9A066");
            button.ForeColor = Color.White;
            button.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#B86F50");
            button.Cursor = Cursors.Hand;
        }
        private void btnShowChart_Click(object sender, EventArgs e)
        {
            GradeChartForm chartForm = new GradeChartForm(high, mid, low);
            chartForm.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void btn_back2_Click_1(object sender, EventArgs e)
        {
            Form1 lecture1 = new Form1();
            lecture1.Show();
            this.Hide();
        }
    }
}