using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Zeats.Legacy.StringExtensions.UnitTest
{
    [TestClass]
    public class OnlyNumbersTest
    {
        [TestMethod]
        public void OnlyNumbers()
        {
            Assert.IsNull(((string) null).OnlyNumbers());
            Assert.AreEqual(string.Empty, string.Empty.OnlyNumbers());
            Assert.AreEqual("123", "123a".OnlyNumbers());
            Assert.AreEqual(string.Empty, "abc".OnlyNumbers());
            Assert.AreEqual("192", "192".OnlyNumbers());
            Assert.AreEqual("0123456789", "0123456789".OnlyNumbers());
        }
    }
}