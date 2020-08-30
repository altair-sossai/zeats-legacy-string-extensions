using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Zeats.Legacy.StringExtensions.UnitTest
{
    [TestClass]
    public class SafeSubstringExtensionTest
    {
        [TestMethod]
        public void SafeSubstring()
        {
            Assert.IsNull(((string) null).SafeSubstring(0, 10));
            Assert.AreEqual(string.Empty, string.Empty.SafeSubstring(0, 10));

            Assert.AreEqual("12345 7890", "12345 7890".SafeSubstring(0, 9999));
            Assert.AreEqual("1", "12345 7890".SafeSubstring(0, 1));
            Assert.AreEqual("12345", "12345 7890".SafeSubstring(0, 5));
            Assert.AreEqual("12345 ", "12345 7890".SafeSubstring(0, 6));
            Assert.AreEqual("12345 7890", "12345 7890".SafeSubstring(0, 10));
        }
    }
}