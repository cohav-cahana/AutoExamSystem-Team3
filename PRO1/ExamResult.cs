using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO1
{
    public class ExamResult
    {
        public string UserId { get; set; }
        public string ExamId { get; set; }
        public float Grade { get; set; }
        public DateTime TakenAt { get; set; }
        public bool IsAdaptive { get; set; }

        public string Subject { get; set; }
        public string Level { get; set; }
    }
}
