using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms;

namespace UnitTestAlgorithms
{
    [TestClass]
    public class ArraysAndFriends_UnitTests
    {
        [TestMethod]
        public void ArrayMultiply_Test()
        {
            // Arrange
            int[] arr = new int[] { 2, 4, 3, 6 };

            // Act
            int[] result = ArraysAndFriends.ArrayMultiply(arr);
            int[] expected = new int[] { 72, 36, 48, 24 };

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
