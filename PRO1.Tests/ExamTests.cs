using Microsoft.VisualStudio.TestTools.UnitTesting;
using PRO1;
using System.Collections.Generic;

namespace PRO1.Tests  // <-- Add a proper namespace
{
    // Simplified Question class for testing purposes

    // Simplified AdaptiveTestForm
    public class AdaptiveTestForm
    {
        public List<Question> easy = new List<Question>();
        public List<Question> medium = new List<Question>();
        public List<Question> hard = new List<Question>();
        public List<Question> allQuestions = new List<Question>();

        public int count;

        public Question pullNextQuestion()
        {
            Question q = null;
            if (count == 0 && easy.Count > 0)
            {
                q = easy[0];
                easy.RemoveAt(0);
            }
            else if (count == 3 && medium.Count > 0)
            {
                q = medium[0];
                medium.RemoveAt(0);
            }
            else if (count == 5 && hard.Count > 0)
            {
                q = hard[0];
                hard.RemoveAt(0);
            }

            if (q != null)
                allQuestions.Add(q);

            return q;
        }
    }

    // Score helper class
    public static class ScoreHelper
    {
        public static float CalculateScore(int correctAnswers, int totalQuestions)
        {
            if (totalQuestions == 0) return 0;
            return (correctAnswers * 100f) / totalQuestions;
        }
    }

    [TestClass]
    public class CombinedTests
    {
        // ---------- Tests for TestForm.FormatTime ----------
        [DataTestMethod]
        [DataRow(0, "00:00")]
        [DataRow(75, "01:15")]
        [DataRow(3599, "59:59")]
        [DataRow(3600, "60:00")]
        public void FormatTime_ReturnsCorrectFormat(int inputSeconds, string expected)
        {
            string actual = TestForm.FormatTime(inputSeconds);
            Assert.AreEqual(expected, actual);
        }

        // ---------- Tests for ScoreHelper.CalculateScore ----------
        [DataTestMethod]
        [DataRow(0, 10, 0)]
        [DataRow(5, 10, 50)]
        [DataRow(10, 10, 100)]
        [DataRow(3, 0, 0)]
        public void CalculateScore_ReturnsExpected(int correct, int total, float expected)
        {
            float actual = ScoreHelper.CalculateScore(correct, total);
            Assert.AreEqual(expected, actual);
        }

        // ---------- Tests for AdaptiveTestForm.pullNextQuestion ----------
        private AdaptiveTestForm form;

        [TestInitialize]
        public void Setup()
        {
            form = new AdaptiveTestForm();

            form.easy = new List<Question> { new Question { QuestionText = "Easy Question" } };
            form.medium = new List<Question> { new Question { QuestionText = "Medium Question" } };
            form.hard = new List<Question> { new Question { QuestionText = "Hard Question" } };
            form.allQuestions = new List<Question>();

            form.count = 0;
        }

        [TestMethod]
        public void PullNextQuestion_ReturnsAndRemovesEasyQuestion_WhenCountIs0()
        {
            form.count = 0;
            var q = form.pullNextQuestion();

            Assert.IsNotNull(q);
            Assert.AreEqual("Easy Question", q.QuestionText);
            Assert.AreEqual(0, form.easy.Count);
            Assert.AreEqual(1, form.allQuestions.Count);
            Assert.AreSame(q, form.allQuestions[0]);
        }

        [TestMethod]
        public void PullNextQuestion_ReturnsAndRemovesMediumQuestion_WhenCountIs3()
        {
            form.count = 3;
            var q = form.pullNextQuestion();

            Assert.IsNotNull(q);
            Assert.AreEqual("Medium Question", q.QuestionText);
            Assert.AreEqual(0, form.medium.Count);
            Assert.AreEqual(1, form.allQuestions.Count);
            Assert.AreSame(q, form.allQuestions[0]);
        }

        [TestMethod]
        public void PullNextQuestion_ReturnsAndRemovesHardQuestion_WhenCountIs5()
        {
            form.count = 5;
            var q = form.pullNextQuestion();

            Assert.IsNotNull(q);
            Assert.AreEqual("Hard Question", q.QuestionText);
            Assert.AreEqual(0, form.hard.Count);
            Assert.AreEqual(1, form.allQuestions.Count);
            Assert.AreSame(q, form.allQuestions[0]);
        }
    }
}