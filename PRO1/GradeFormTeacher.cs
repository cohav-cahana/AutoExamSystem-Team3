using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace PRO1
{
    public partial class GradeFormTeacher : Form
    {
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



            string firebaseUrl = "https://questions-sce-default-rtdb.firebaseio.com/users.json";


            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(firebaseUrl);

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();

                    var allUsers = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, object>>>(json);

                    foreach (var user in allUsers)
                    {
                        string userId = user.Key;
                        var userData = user.Value;

                        if (userData.ContainsKey("grades"))
                        {
                            string username = userData.ContainsKey("Username") ? userData["Username"].ToString() : userId;

                            var gradesJson = JsonConvert.SerializeObject(userData["grades"]);
                            var grades = JsonConvert.DeserializeObject<Dictionary<string, Grade>>(gradesJson);

                            foreach (var grade in grades.Values)
                            {
                                dgvScores.Rows.Add(
                                    username,         // שם
                                    userId,           // ת"ז
                                    grade.score,      // ציון
                                    grade.subject,    // מקצוע
                                    grade.level       // רמת קושי
                                );
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("שגיאה בשליפת נתונים מה־Firebase.");
                }
            }
        }
    }
}
