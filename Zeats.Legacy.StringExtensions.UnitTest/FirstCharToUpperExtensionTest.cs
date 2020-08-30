using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Zeats.Legacy.StringExtensions.UnitTest
{
    [TestClass]
    public class FirstCharToUpperExtensionTest
    {
        [TestMethod]
        public void FirstCharToUpper()
        {
            Assert.IsNull(((string) null).FirstCharToUpper());
            Assert.AreEqual(string.Empty, string.Empty.FirstCharToUpper());
            Assert.AreEqual("  ", "  ".FirstCharToUpper());

            Assert.AreEqual("123", "123".FirstCharToUpper());
            Assert.AreEqual("1a23", "1a23".FirstCharToUpper());
            Assert.AreEqual("1A23", "1A23".FirstCharToUpper());
            Assert.AreEqual("A1a23", "a1a23".FirstCharToUpper());
            Assert.AreEqual("A1a23", "A1a23".FirstCharToUpper());

            Assert.AreEqual("A", "a".FirstCharToUpper());
            Assert.AreEqual("A", "A".FirstCharToUpper());

            Assert.AreEqual("Lorem ipsum dolor", "lorem ipsum dolor".FirstCharToUpper());
            Assert.AreEqual("LOREM IPSUM DOLOR", "lOREM IPSUM DOLOR".FirstCharToUpper());
            Assert.AreEqual("LOREM IPSUM DOLOR", "LOREM IPSUM DOLOR".FirstCharToUpper());
        }
    }
}