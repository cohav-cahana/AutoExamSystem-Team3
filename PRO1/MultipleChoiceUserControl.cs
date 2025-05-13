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
    public partial class MultipleChoiceUserControl : UserControl
    {
        public MultipleChoiceUserControl()
        {
            InitializeComponent();
        }

        private void uncheckRadioButtons()
        {
            foreach (Control control in this.Controls)
            {
                if (control is RadioButton radioButton)
                {
                    radioButton.BackColor = Color.Turquoise;
                }
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.uncheckRadioButtons();
            radioButton3.BackColor = Color.Teal;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.uncheckRadioButtons();
            radioButton2.BackColor = Color.Teal;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.uncheckRadioButtons();
            radioButton1.BackColor = Color.Teal;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            this.uncheckRadioButtons();
            radioButton4.BackColor = Color.Teal;
        }
    }
}
