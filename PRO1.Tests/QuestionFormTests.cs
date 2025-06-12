using Microsoft.VisualStudio.TestTools.UnitTesting;
using PRO1;
using System.ComponentModel;

namespace PRO1.Tests
{
    [TestClass]
    public class QuestionFormTests
    {
        [TestMethod]
        public void RemoveQuestion_RemovesQuestionFromList()
        {
            // Arrange
            var question1 = new Question { Id = "1", QuestionText = "What is 2+2?" };
            var question2 = new Question { Id = "2", QuestionText = "What is the capital of France?" };
            var questionsList = new BindingList<Question> { question1, question2 };

            // Act
            questionsList.Remove(question1);

            // Assert
            Assert.AreEqual(1, questionsList.Count);
            Assert.AreEqual("2", questionsList[0].Id);
        }
    }
}
