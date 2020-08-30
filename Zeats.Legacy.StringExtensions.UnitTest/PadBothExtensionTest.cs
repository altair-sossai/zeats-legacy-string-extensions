using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Zeats.Legacy.StringExtensions.UnitTest
{
    [TestClass]
    public class PadBothExtensionTest
    {
        [TestMethod]
        public void PadBoth()
        {
            Assert.IsNull(PadBothExtension.PadBoth(null));
            Assert.IsNull(PadBothExtension.PadBoth(null, 'X'));

            Assert.IsNull(PadBothExtension.PadBoth(null, 10));
            Assert.IsNull(PadBothExtension.PadBoth(null, 10, 'X'));

            Assert.AreEqual(string.Empty, string.Empty.PadBoth());
            Assert.AreEqual(string.Empty, string.Empty.PadBoth('X'));

            Assert.AreEqual(string.Empty, string.Empty.PadBoth(10));
            Assert.AreEqual(string.Empty, string.Empty.PadBoth(10, 'X'));

            Assert.AreEqual("Lorem Ipsum", "Lorem Ipsum".PadBoth());
            Assert.AreEqual("Lorem Ipsum", "Lorem Ipsum".PadBoth('X'));
            
            Assert.AreEqual("Lorem Ipsum", "Lorem Ipsum".PadBoth(4));
            Assert.AreEqual("Lorem Ipsum", "Lorem Ipsum".PadBoth(4, 'X'));

            Assert.AreEqual("    Lorem Ipsum     ", "Lorem Ipsum".PadBoth(20));
            Assert.AreEqual("XXXXLorem IpsumXXXXX", "Lorem Ipsum".PadBoth(20, 'X'));

            Assert.AreEqual("  Lorem Ipsum  ", "  Lorem Ipsum  ".PadBoth());
            Assert.AreEqual("XXLorem IpsumXX", "  Lorem Ipsum  ".PadBoth('X'));

            Assert.AreEqual("    Lorem Ipsum     ", "  Lorem Ipsum  ".PadBoth(20));
            Assert.AreEqual("XX  Lorem Ipsum  XXX", "  Lorem Ipsum  ".PadBoth(20, 'X'));

            Assert.AreEqual("  Lorem Ipsum  ", "  Lorem Ipsum  ".PadBoth(5));
            Assert.AreEqual("  Lorem Ipsum  ", "  Lorem Ipsum  ".PadBoth(5, 'X'));
        }
    }
}