using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using System.Linq;
using PRO1;

namespace FirebaseTests
{
    [TestClass]
    public class AddQuestionIntegrationTests
    {
        private FirebaseHelper firebaseHelper;

        [TestInitialize]
        public void Setup()
        {
            firebaseHelper = new FirebaseHelper();
        }

        [TestMethod]
        public async Task AddQuestionAsync_ShouldAddQuestionToFirebase()
        {
            // Arrange
            string questionText = "כמה זה 2 + 2?";
            string correctAnswer = "4";
            string topic = "חשבון";
            string level = "קל";
            string answer1 = "3";
            string answer2 = "4";
            string answer3 = "5";
            string answer4 = "6";
            string type = "MultipleChoice";
            string teacherId = "teacher123";

            // Act – שליחת השאלה לפיירבייס
            await firebaseHelper.AddQuestionAsync(type, correctAnswer, topic, level, questionText,
                                                  answer1, answer2, answer3, answer4, teacherId);

            // שליפת כל השאלות
            var allQuestions = await firebaseHelper.GetAllQuestionsAsync();

            // חיפוש השאלה שהוספנו
            var foundQuestion = allQuestions.FirstOrDefault(q =>
                q.QuestionText == questionText &&
                q.CorrectAnswer == correctAnswer &&
                q.Topic == topic &&
                q.Level == level &&
                q.Type == type &&
                q.TeacherId == teacherId
            );

            // Assert – בדיקה שאכן נמצאה
            Assert.IsNotNull(foundQuestion, "השאלה לא נמצאה בבסיס הנתונים לאחר ההוספה");

            // ניקוי
            await firebaseHelper.DeleteQuestionAsync(foundQuestion.Id);
        }
    }
}
