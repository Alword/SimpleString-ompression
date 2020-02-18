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
            SimpleTextCompressor simpleTextCompressor = new SimpleTextCompressor();

            Assert.AreEqual(simpleTextCompressor.Compress("aaab"), "(3)ab");
            Assert.AreEqual(simpleTextCompressor.Compress("baab"), "b(2)ab");
            Assert.AreEqual(simpleTextCompressor.Compress(""), "");
            Assert.AreEqual(simpleTextCompressor.Compress(null), "");
        }
    }
}
