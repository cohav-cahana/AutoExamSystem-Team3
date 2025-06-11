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
    public partial class OpenQuestion : Form
    {
        public OpenQuestion()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile(@"C:\Users\maimo\source\repos\HM2\HM2\Images\back2.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void OpenQuestion_Load(object sender, EventArgs e)
        {

        }
    }
}
