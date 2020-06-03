using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrySpellNF;

namespace UnitTestProjectTrySpell
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Failed", "Failed");
        }

       
        [TestMethod]
        public void CheckSpellInvalid()
        {
            string myword = LogictoSpell.ConvertToWords("54234.871");
            string myActual = "Fifty Four Thousand Two Hundred Thirty Four Rupees and Eighty Seven Paisa Only";
            Assert.AreNotEqual(myword, myActual);

        }

        /// <summary>
        /// Test to check correct spell
        /// </summary>
        [TestMethod]
        public void CheckSpellValid()
        {
            string myword = LogictoSpell.ConvertToWords("54234.87");
            string myActual = "Fifty Four Thousand Two Hundred Thirty Four Rupees and Eighty Seven Paisa Only";
            Assert.AreEqual(myword, myActual);

        }

        [TestMethod]
        public void CheckSpellNegative()
        {
            string myword = LogictoSpell.ConvertToWords("-54234.87");
            string myActual = "Value is negative";
            Assert.AreEqual(myword, myActual);

        }
    }
}
