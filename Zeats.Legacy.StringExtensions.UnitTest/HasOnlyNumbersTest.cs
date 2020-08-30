using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Zeats.Legacy.StringExtensions.UnitTest
{
    [TestClass]
    public class HasOnlyNumbersTest
    {
        [TestMethod]
        public void HasOnlyNumbersExtension()
        {
            Assert.IsFalse(((string) null).HasOnlyNumbers());
            Assert.IsFalse(string.Empty.HasOnlyNumbers());
            Assert.IsFalse("123a".HasOnlyNumbers());
            Assert.IsFalse("abc".HasOnlyNumbers());
            Assert.IsTrue("192".HasOnlyNumbers());
            Assert.IsTrue("0123456789".HasOnlyNumbers());
        }
    }
}