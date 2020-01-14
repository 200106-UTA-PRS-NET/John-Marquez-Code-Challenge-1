using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library;
namespace UnitTest
{
    [TestClass]
    public class PalindroneTest
    {
        LibraryPal lib1 = new LibraryPal();
        [TestMethod]
        public void TestToLower()
        {
            string expected = "hey";
            string actual = lib1.Lower("HEY");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCharacterRemoval()
        {
            string expected = "hey";
            string actual = lib1.charRemoval(". ,hey");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestPalindrone()
        {
            bool expected = true;
            bool actual = lib1.Palindrone("1221");
            Assert.AreEqual(expected, actual);
        }


    }
}
