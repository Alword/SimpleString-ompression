using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleStringCompression.BusinessLogic;

namespace SimpleStringСompression.BusinessLogicTests
{
    [TestClass]
    public class StringValidatorTest
    {
        [TestMethod]
        public void CheckLowerBound()
        {
            Assert.AreEqual(StringValidator.IsTooShort(""), true);
            Assert.AreEqual(StringValidator.IsTooShort(null), true);
            Assert.AreEqual(StringValidator.IsTooShort("1"), true);
            Assert.AreEqual(StringValidator.IsTooShort("11"), false);
        }

        [TestMethod]
        public void CheckUpperBound()
        {

            Assert.AreEqual(StringValidator.IsTooLong("1111111111222222222233333333334"), true);
            Assert.AreEqual(StringValidator.IsTooLong("11111111112222222222333333333344"), true);
            Assert.AreEqual(StringValidator.IsTooLong("111111111122222222223333333333"), false);
            Assert.AreEqual(StringValidator.IsTooLong(null), false);
        }
    }
}
