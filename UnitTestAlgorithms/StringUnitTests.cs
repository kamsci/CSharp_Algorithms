using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms;

namespace UnitTestAlgorithms
{
    [TestClass]
    public class StringUnitTests
    {
        /// <summary>
        /// Test basic Remove method
        /// </summary>
        [TestMethod]
        public void Remove_Null_Test()
        {
            // Arrange
            string test = null;

            // Act
            string result = Strings.Remove(test);

            // Assert
            Assert.AreEqual("no string", result);
        }
        [TestMethod]
        public void Remove_acEnd_Test()
        {
            // Arrange
            string test = "defac";

            // Act
            string result = Strings.Remove(test);

            // Assert
            Assert.AreEqual("def", result);
        }
        [TestMethod]
        public void Remove_bEnd_Test()
        {
            // Arrange
            string test = "facbdb";

            // Act
            string result = Strings.Remove(test);

            // Assert
            Assert.AreEqual("fd", result);   
        }
        [TestMethod]
        public void Remove_acBegin_Test()
        {
            // Arrange
            string test = "acbfg";

            // Act
            string result = Strings.Remove(test);

            // Assert
            Assert.AreEqual("fg", result);
        }
        [TestMethod]
        public void Remove_bStart_Test()
        {
            // Arrange
            string test = "bacnzbc";

            // Act
            string result = Strings.Remove(test);

            // Assert
            Assert.AreEqual("nzc", result);
        }
        [TestMethod]
        public void Remove_acSplit_Test()
        {
            // Arrange
            string test = "asaaaaaccccccc";

            // Act
            string result = Strings.Remove(test);

            // Assert
            Assert.AreEqual("ascc", result);
        }
        [TestMethod]
        public void Remove_acRemain_Test()
        {
            // Arrange
            string test = "acbacac";

            // Act
            string result = Strings.Remove(test);

            // Assert
            Assert.AreEqual("", result);
        }
        [TestMethod]
        public void Remove_bRemain_Test()
        {
            // Arrange
            string test = "acbacb";

            // Act
            string result = Strings.Remove(test);

            // Assert
            Assert.AreEqual("", result);
        }
        [TestMethod]
        public void Remove_cLeft_Test()
        {
            // Arrange
            string test = "abcabcc";

            // Act
            string result = Strings.Remove(test);

            // Assert
            Assert.AreEqual("c", result);
        }
        [TestMethod]
        public void Remove_Case_Test()
        {
            // Arrange
            string test = "ACBDabcd";

            // Act
            string result = Strings.Remove(test);

            //Assert
            Assert.AreEqual("Dd", result);
        }
        [TestMethod]
        public void Remove_bacOrder_Test()
        {
            // Arrange
            string test = "bacgacb";

            // Act
            string result = Strings.Remove(test);

            // Assert
            Assert.AreEqual("g", result);
        }

        /// <summary>
        /// Test single string variable RemoveInput method
        /// </summary>
        [TestMethod]
        public void RemoveInput_stringEmpty_Test()
        {
            // Arrange
            string testRemove = "";
            string testString = "a";

            // Act
            string result = Strings.RemoveInput(testRemove, testString);

            // Assert
            Assert.AreEqual(result, "a");
        }
        [TestMethod]
        public void RemoveInput_stringLength1_resultEmpty_Test()
        {
            // Arrange
            string testRemove = "a";
            string testString = "a";

            // Act
            string result = Strings.RemoveInput(testRemove, testString);

            // Assert
            Assert.AreEqual(result, "");
        }
        [TestMethod]
        public void RemoveInput_stringLength1_Front_Test()
        {
            // Arrange
            string testRemove = "a";
            string testString = "abc";

            // Act
            string result = Strings.RemoveInput(testRemove, testString);

            // Assert
            Assert.AreEqual(result, "bc");
        }
        [TestMethod]
        public void RemoveInput_stringLength2_Front_resultEmpty_Test()
        {
            // Arrange
            string testRemove = "ab";
            string testString = "ab";

            // Act
            string result = Strings.RemoveInput(testRemove, testString);

            // Assert
            Assert.AreEqual(result, "");
        }
        [TestMethod]
        public void RemoveInput_stringLength2_Front_Test()
        {
            // Arrange
            string testRemove = "ab";
            string testString = "abc";

            // Act
            string result = Strings.RemoveInput(testRemove, testString);

            // Assert
            Assert.AreEqual(result, "c");
        }
        [TestMethod]
        public void RemoveInput_stringLength2_Multiple_Test()
        {
            // Arrange
            string testRemove = "ab";
            string testString = "abcab";

            // Act
            string result = Strings.RemoveInput(testRemove, testString);

            // Assert
            Assert.AreEqual(result, "c");
        }
        [TestMethod]
        public void RemoveInput_stringLength2_Part_Test()
        {
            // Arrange
            string testRemove = "ab";
            string testString = "abbc";

            // Act
            string result = Strings.RemoveInput(testRemove, testString);

            // Assert
            Assert.AreEqual(result, "bc");
        }
        [TestMethod]
        public void RemoveInput_stringLength2_split_Test()
        {
            // Arrange
            string testRemove = "ab";
            string testString = "aabbg";

            // Act
            string result = Strings.RemoveInput(testRemove, testString);

            // Assert
            Assert.AreEqual(result, "g");
        }
        /// <summary>
        /// Test HasAllUniqueChar method
        /// </summary>
        [TestMethod]
        public void HasAllUniqueChar_EmptyString_Test()
        {
            // Arrange
            string testString = "";

            // Act
            bool result = Strings.HasAllUniqueChar(testString);

            // Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void HasAllUniqueChar_True_Test()
        {
            // Arrange
            string testString = "lskdjfy";

            // Act
            bool result = Strings.HasAllUniqueChar(testString);

            // Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void HasAllUniqueChar_False_Test()
        {
            // Arrange
            string testString = "chodcl";

            // Act
            bool result = Strings.HasAllUniqueChar(testString);

            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void HasUniqueChar_Nums_True_Test()
        {
            // Arrange
            string testString = "19736d";

            // Act
            bool result = Strings.HasAllUniqueChar(testString);

            // Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void HasAllUniqueChar_Nums_False_Test()
        {
            // Arrange
            string testString = "1r8371";

            // Act
            bool result = Strings.HasAllUniqueChar(testString);

            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void HasAllUniqueChar_Caps_Test()
        {
            // Arrange
            string testString = "akdK23";

            // Act
            bool result = Strings.HasAllUniqueChar(testString);

            // Assert
            Assert.IsTrue(result);
        }
        /// <summary>
        /// Test Reverse method
        /// </summary>
        [TestMethod]
        public void Reverse_Even_Test()
        {
            // Arrange
            string testString = "wons";

            // Act
            string result = Strings.ReverseString(testString);

            // Assert
            Assert.AreEqual("snow", result);
        }
        [TestMethod]
        public void Reverse_Odd_Test()
        {
            // Arrange
            string testString = "tliuq";

            // Act
            string result = Strings.ReverseString(testString);

            // Assert
            Assert.AreEqual("quilt", result);
        }
        /// <summary>
        /// Tests for ReverseWords method
        /// </summary>
        [TestMethod]
        public void ReverseWords_NULL_Test()
        {
            // Arrange
            string testString = "";

            // Act
            string result = Strings.ReverseWords(testString);

            // Assert
            Assert.AreEqual("", result);
        }
        [TestMethod]
        public void ReverseWords_Test()
        {
            // Arrange
            string testString = "This is fun";

            // Act
            string result = Strings.ReverseWords(testString);

            // Assert
            Assert.AreEqual("fun is This", result);
        }
        [TestMethod]
        public void IsPermutation_True_Test()
        {
            // Arrange
            string testFirstString = "gator";
            string testSecondString = "tagor";

            // Act
            bool result = Strings.IsPermutation(testFirstString, testSecondString);

            // Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void IsPermutation_FalsebyLength_Test()
        {
            // Arrange
            string testFirstString = "gator";
            string testSecondString = "tag";

            // Act
            bool result = Strings.IsPermutation(testFirstString, testSecondString);

            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void IsPermutation_False_Test()
        {
            // Arrange
            string testFirstString = "gator";
            string testSecondString = "tager";

            // Act
            bool result = Strings.IsPermutation(testFirstString, testSecondString);

            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void IsPermutation_TrueWithSpace_Test()
        {
            // Arrange
            string testFirstString = "gator in town";
            string testSecondString = "now tagor tin";

            // Act
            bool result = Strings.IsPermutation(testFirstString, testSecondString);

            // Assert
            Assert.IsTrue(result);
        }
    }
}
