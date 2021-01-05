using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeeSharp_WorkSpace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SeeSharp_WorkSpaceTests
{
    [TestClass()]
    public class TestCountSay
    {
        CountSay countSay = new CountSay();
        [TestMethod()]
        public void countAndsay_One()
        {
            
            Assert.AreEqual("1", countSay.countAndSay(1));
        }
        [TestMethod()]
        public void countAndsay_AboveThirty()
        {
            
            Assert.AreEqual("0", countSay.countAndSay(31));
        }
        [TestMethod()]
        public void countAndsay_BelowOne()
        {
            Assert.AreEqual("0", countSay.countAndSay(0));
        }
        [TestMethod()]
        public void countAndsay_Two()
        {
            Assert.AreEqual("11", countSay.countAndSay(2));
        }
        [TestMethod()]
        public void countAndsay_Three()
        {
            Assert.AreEqual("21", countSay.countAndSay(2));
        }
    }
}
