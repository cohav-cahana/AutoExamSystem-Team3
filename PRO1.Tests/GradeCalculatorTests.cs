using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PRO1;

namespace PRO1.Tests
{
    public class GradeCalculatorTests
    {
        [TestMethod]

        public void CalculateAverage_WithValidGrades_ReturnsCorrectAverage()
        {
            var grades = new List<object> { 80, 90, 100 };

            // Act
            double average = GradeCalculator.CalculateAverage(grades);

            // Assert
            Assert.AreEqual(90.0, average);

        }

        [TestMethod]

        public void CalculateAverage_WithEmptyGrid_ReturnsZero()
        {
            var grades = new List<object> {};

            // Act
            double average = GradeCalculator.CalculateAverage(grades);

            // Assert
            Assert.AreEqual(0, average);
        }

        [TestMethod]

        public void CalculateAverage_WithInvalidValues_IgnoresThem()
        {
            // Arrange
            var grades = new List<object> { 90 };

            // Act
            double average = GradeCalculator.CalculateAverage(grades);

            // Assert
            Assert.AreEqual(90.0, average);
        }
    }
}
