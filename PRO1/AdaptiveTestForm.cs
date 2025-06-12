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
    public partial class AdaptiveTestForm : Form
    {
        private User user;
        private AdaptiveSelectionForm adaptiveSelectionForm;
        private int number;
        private List<Question> easyQuestions;
        private List<Question> mediumQuestions;
        private List<Question> hardQuestions;
        private string type;
        public AdaptiveTestForm(User user, AdaptiveSelectionForm adaptiveSelectionForm, int number, List<Question> easyQuestions, List<Question> mediumQuestions, List<Question> hardQuestions, string type)
        {
            InitializeComponent();
            this.user = user;
            this.adaptiveSelectionForm = adaptiveSelectionForm;
            this.number = number;
            this.easyQuestions = easyQuestions;
            this.mediumQuestions = mediumQuestions;
            this.hardQuestions = hardQuestions;
            this.type = type;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // AdaptiveTestForm
            // 
            this.ClientSize = new System.Drawing.Size(1171, 522);
            this.Name = "AdaptiveTestForm";
            this.Load += new System.EventHandler(this.AdaptiveTestForm_Load);
            this.ResumeLayout(false);

        }

        private void AdaptiveTestForm_Load(object sender, EventArgs e)
        {

        }
    }
}
