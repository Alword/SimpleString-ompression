using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleStringCompression.BusinessLogic;

namespace SimpleStringСompression.BusinessLogicTests
{
    [TestClass]
    public class SimpleTextCompressorTest
    {
        [TestMethod]
        public void CompressSimpleString()
        {
            // arrange
            string text = "aaab";
            string expected = "(3)ab";
            SimpleTextCompressor simpleTextCompressor = new SimpleTextCompressor();

            // act
            string actual = simpleTextCompressor.Compress(text);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
