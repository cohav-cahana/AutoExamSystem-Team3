using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PRO1.Tests
{
    [TestClass]
    public class AnswerSelectorTests
    {
        [TestMethod]
        public void GetCorrectAnswer_WithRadioButton1Checked_ReturnsAnswer1()
        {
            // Arrange
            bool[] checks = { true, false, false, false };
            string[] answers = { "Answer A", "Answer B", "Answer C", "Answer D" };

            // Act
            string result = AnswerSelector.GetCorrectAnswer(checks, answers);

            // Assert
            Assert.AreEqual("Answer A", result);
        }

        [TestMethod]
        public void GetCorrectAnswer_WithRadioButton3Checked_ReturnsAnswer3()
        {
            bool[] checks = { false, false, true, false };
            string[] answers = { "A", "B", "C", "D" };

            string result = AnswerSelector.GetCorrectAnswer(checks, answers);

            Assert.AreEqual("C", result);
        }

        [TestMethod]
        public void GetCorrectAnswer_WithNoneChecked_ReturnsEmptyString()
        {
            bool[] checks = { false, false, false, false };
            string[] answers = { "A", "B", "C", "D" };

            string result = AnswerSelector.GetCorrectAnswer(checks, answers);

            Assert.AreEqual(string.Empty, result);
        }
    }
}
