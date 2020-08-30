using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Zeats.Legacy.StringExtensions.UnitTest
{
    [TestClass]
    public class AlignRightExtensionTest
    {
        [TestMethod]
        public void AlignRight()
        {
            Assert.IsNull(((string) null).AlignRight());
            Assert.IsNull(((string) null).AlignRight('?'));

            Assert.AreEqual(string.Empty, string.Empty.AlignRight());
            Assert.AreEqual(string.Empty, string.Empty.AlignRight('?'));

            Assert.AreEqual("Lorem Ipsum", "Lorem Ipsum".AlignRight());
            Assert.AreEqual("Lorem Ipsum", "Lorem Ipsum".AlignRight('X'));

            Assert.AreEqual("    Lorem Ipsum", "  Lorem Ipsum  ".AlignRight());
            Assert.AreEqual("XXXXLorem Ipsum", "  Lorem Ipsum  ".AlignRight('X'));
        }
    }
}