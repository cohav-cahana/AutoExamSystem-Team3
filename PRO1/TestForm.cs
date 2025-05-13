using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRO1

{
    public partial class TestForm : Form
    {
        private int timeLeftInSeconds = 15;
        public TestForm()
        {
            InitializeComponent();
            lblTimer.Text = FormatTime(timeLeftInSeconds);
            examTimer.Start();
            panel1.Controls.Add(new MultipleChoiceUserControl());
        }
        private string FormatTime(int seconds)
        {
            int mins = seconds / 60;
            int secs = seconds % 60;
            return $"{mins:D2}:{secs:D2}";
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TestFrom_Load(object sender, EventArgs e)
        {

        }

        private void examTimer_Tick(object sender, EventArgs e)
        {
            timeLeftInSeconds--;

            if (timeLeftInSeconds <= 0)
            {
                examTimer.Stop();
                MessageBox.Show("Time is up! The test will now close.", "Time Expired", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Close the test form
            }
            else
            {
                if(timeLeftInSeconds <= 10)
                {
                    lblTimer.ForeColor = Color.LightPink; // Change color to red when time is low
                    lblTimer.BackColor = Color.Red;
                }
                else
                {
                    lblTimer.ForeColor = Color.LightGreen;
                    lblTimer.BackColor = Color.ForestGreen;
                }
                lblTimer.Text = FormatTime(timeLeftInSeconds);
            }
        }

        private void lblQuestionCounter_Click(object sender, EventArgs e)
        {

        }

        private void lblTimer_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
