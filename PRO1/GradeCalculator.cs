using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRO1
{
    public static class GradeCalculator
    {
        public static double CalculateAverage(List<object> grades)
        {
            double total = 0;
            int count = 0;

            foreach (var gradeObj in grades)
            {
                if (gradeObj != null && double.TryParse(gradeObj.ToString(), out double grade))
                {
                    total += grade;
                    count++;
                }
            }

            return count > 0 ? total / count : 0;
        }
    }

}
