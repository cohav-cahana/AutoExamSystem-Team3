﻿using System;
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
          //  this.BackgroundImage = Image.FromFile(@"C:\Users\maimo\source\repos\HM2\HM2\Images\back2.jpg");
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

            // יצירת אובייקט של ה-Form של השאלות
            QuestionForm questionForm = new QuestionForm();

            // הצגת ה-Form של השאלות
            questionForm.ShowDialog();  // אם תרצה שה-Form יהיה מודאלי
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
