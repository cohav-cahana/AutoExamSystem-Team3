using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO1
{
    public class Exam
    {
        public string Id { get; set; }
        public int QuestionCount { get; set; }
        public List<string> Topics { get; set; }
        public string Difficulty { get; set; }
        public int DurationInSeconds { get; set; }
        public List<Question> Questions { get; set; } = new List<Question>();


        public override string ToString()
        {
            return $"ID FOR THE TEST: {Id}, Questions: {QuestionCount}, Topic: {Topics[0]}, Level: {Difficulty}";
        }
    }
}
