using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DemoExtentionLib.ExtensionMehtods;

namespace DemoExtentionLibTest.ExtensionMehtodTest
{
    [TestClass]
    public class SampleExtensionTest
    {
        [TestMethod]
        public void SampleExtensionTestMehtod()
        {
            string input1 = "1000";
            string input2 = "12.09";
            string input3 = "04/25/2018";
            Assert.AreEqual(true, input1.IsValidInteger());
            Assert.AreEqual(true, input2.IsValidDouble());
            Assert.AreEqual(true, input3.IsValidDate());
            Assert.AreEqual(false, input3.IsValidInteger());
        }
    }
}
