using PRO1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO1
{
    public class QuestionManager
    {
        private List<Question> questions = new List<Question>();

        public void AddQuestion(Question question)
        {
            questions.Add(question);
        }

        public int GetQuestionCount()
        {
            return questions.Count;
        }

        public List<Question> GetQuestionsByType(string type)
        {
            return questions.Where(q => q.Type == type).ToList();
        }

        public List<Question> GetAllQuestions()
        {
            return new List<Question>(questions);
        }

        public List<Question> GenerateExam(int numberOfQuestions)
        {
            return questions.Take(numberOfQuestions).ToList(); // דוגמה פשוטה
        }

        public void ClearAllQuestions()
        {
            questions.Clear();
        }
  
    }
    public static class GlobalState
    {
        public static QuestionManager QuestionManager = new QuestionManager();
    }
}

