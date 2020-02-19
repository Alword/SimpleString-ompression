using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleStringCompression.BusinessLogic;

namespace SimpleStringСompression.BusinessLogicTests
{
    [TestClass]
    public class SimpleTextCompressorTest
    {
        [DataTestMethod]
        [DataRow("aaab","(3)ab")]
        [DataRow("baab","b(2)ab")]
        [DataRow("","")]
        [DataRow(null, "")]
        public void CompressSimpleString(string testString, string expected)
        {
            // arrange
            SimpleTextCompressor simpleTextCompressor = new SimpleTextCompressor();

            // act 
            string actual = simpleTextCompressor.Compress(testString);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
