using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeeSharp_WorkSpace.HackerRank_Staircase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeSharp_WorkSpaceTests.HackerRank_Staircase_Test
{
    [TestClass]
    public class StaircaseTest
    {
        Staircase staircase = new Staircase();
        [TestMethod]
        public void test_printStaircase_one()
        {
            string expectedCase = "#\n";
            string resultCase = staircase.getStaircase(1);
            Assert.AreEqual(expectedCase, resultCase);
        }
        [TestMethod]
        public void test_printStaircase_two()
        {
            string expectedCase = " #\n##\n";
            string resultCase = staircase.getStaircase(2);
            Assert.AreEqual(expectedCase, resultCase);
        }
        [TestMethod]
        public void test_printStaircase_four()
        {
            string expectedCase = "#\n";
            string resultCase = staircase.getStaircase(1);
            Assert.AreEqual(expectedCase, resultCase);
        }
        [TestMethod]
        public void test_printStaircase_six()
        {
            string expectedCase = "#\n";
            string resultCase = staircase.getStaircase(1);
            Assert.AreEqual(expectedCase, resultCase);
        }
    }
}
