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
            Assert.IsTrue(StringValidator.IsTooShort(""));
            Assert.IsTrue(StringValidator.IsTooShort(null));
            Assert.IsTrue(StringValidator.IsTooShort("1"));
            Assert.IsFalse(StringValidator.IsTooShort("11"));
        }

        [TestMethod]
        public void CheckUpperBound()
        {

            Assert.IsTrue(StringValidator.IsTooLong("1111111111222222222233333333334"));
            Assert.IsTrue(StringValidator.IsTooLong("11111111112222222222333333333344"));
            Assert.IsFalse(StringValidator.IsTooLong("111111111122222222223333333333"));
            Assert.IsFalse(StringValidator.IsTooLong(null));
        }
    }
}
