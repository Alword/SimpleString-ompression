using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleStringCompression.BusinessLogic;
using SimpleStringCompression.BusinessLogic.Abstractions;

namespace SimpleStringCompression.BusinessLogicIntegrationTests
{
    [TestClass]
    public class ValidStringCompressor
    {
        private const string tooLongException = "text is tooLong";
        private const string tooShortException = "text is tooShort";

        [DataTestMethod]
        [DataRow("abbc", "a(2)bc")]
        [DataRow("abbbc", "a(3)bc")]
        public void ValidCompression(string testString, string expected)
        {
            // arrange
            string actual = string.Empty;
            IStringCompressor stringCompressor = new ValidationCompressor(
                (text) => StringValidator.IsValid(text));

            // act 
            actual = stringCompressor.Compress(testString);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", tooLongException)]
        [DataRow("a", tooShortException)]
        public void OutOfRangeCompression(string testString, string expectedError)
        {
            // arrange
            string actual = string.Empty;
            IStringCompressor stringCompressor = new ValidationCompressor(
                (text) => StringValidator.IsValid(text));

            // act 
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => stringCompressor.Compress(testString), expectedError);
        }
    }
}
