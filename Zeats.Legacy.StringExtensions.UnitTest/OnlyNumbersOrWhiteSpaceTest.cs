using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Zeats.Legacy.StringExtensions.UnitTest
{
    [TestClass]
    public class OnlyNumbersOrWhiteSpaceTest
    {
        [TestMethod]
        public void OnlyNumbersOrWhiteSpace()
        {
            Assert.IsNull(((string) null).OnlyNumbersOrWhiteSpace());
            Assert.AreEqual(string.Empty, string.Empty.OnlyNumbersOrWhiteSpace());

            Assert.AreEqual("123", "123a".OnlyNumbersOrWhiteSpace());
            Assert.AreEqual(string.Empty, "abc".OnlyNumbersOrWhiteSpace());
            Assert.AreEqual("192", "192".OnlyNumbersOrWhiteSpace());
            Assert.AreEqual("0123456789", "0123456789".OnlyNumbersOrWhiteSpace());

            Assert.AreEqual("1 2 3", "1 2 3a".OnlyNumbersOrWhiteSpace());
            Assert.AreEqual("  ", "a  bc".OnlyNumbersOrWhiteSpace());
            Assert.AreEqual("  192", "  192".OnlyNumbersOrWhiteSpace());
            Assert.AreEqual("0 123456789 ", "0 123456789 ".OnlyNumbersOrWhiteSpace());
        }
    }
}