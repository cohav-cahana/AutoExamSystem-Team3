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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.back2;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            label1.Font = new Font("Arial", 12, FontStyle.Bold);
            button1.Font= new Font("Arial", 12, FontStyle.Bold);
            button2.Font = new Font("Arial", 12, FontStyle.Bold);
            button3.Font = new Font("Arial", 8, FontStyle.Bold);
            button4.Font = new Font("Arial", 8, FontStyle.Bold);



        }
        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();

            QuestionForm questionForm = new QuestionForm();

            
            questionForm.ShowDialog();  
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
