using System;
using System.Collections.Generic;
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
            this.BackgroundImage = Properties.Resources.jeffrey;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Load += new System.EventHandler(this.GradeFormTeacher_Load);
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

        private void btnShowChart_Click(object sender, EventArgs e)
        {
            GradeChartForm chartForm = new GradeChartForm(high, mid, low);
            chartForm.ShowDialog();
        }
    }
}