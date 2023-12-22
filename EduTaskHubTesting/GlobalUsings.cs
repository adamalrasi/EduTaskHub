
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;

namespace SimpleTests
{
    [TestClass]
    public class MathTests
    {
        [TestMethod]
        public void Add_TwoNumbers_ReturnsSum()
        {
            // Arrange
            int num1 = 5;
            int num2 = 10;

            // Act
            int result = Math.Add(num1, num2);

            // Assert
            Assert.AreEqual(15, result); // Verify the expected sum
        }
    }
}