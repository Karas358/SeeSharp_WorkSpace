using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeeSharp_WorkSpace.HackerRank_PlusMinus;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SeeSharp_WorkSpaceTests.HackerRank_PlusMinus_Test
{
    [TestClass]
    public class Test_PlusMinus
    {
        PlusMinus plusMinus = new PlusMinus();
        

        [TestMethod]
        public void isArrayInValid_LengthOutOfBondTooLong()
        {
            //120
            List<int> arr = new List<int>(){ 
                1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
                1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
                1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
                1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
                1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
                1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
                1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
                1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
                1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
                1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
                1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
                1, 1, 1, 1, 1, 1, 1, 1, 1, 1
            };
            bool res = plusMinus.isOutOfBounds(arr.Count);
            Assert.AreEqual(true, res);
        }

        [TestMethod]
        public void isArrayValid_ValidAmount()
        {
            List<int> arr = new List<int>(){
                2, 3
            };
            bool res = plusMinus.isOutOfBounds(arr.Count);
            Assert.AreEqual(false, res);
        }

        [TestMethod]
        public void test_PlusMinus_positive()
        {
            List<int> arr = new List<int>() { 1, 1, 0, -1, -1 };
            string expectedresult = string.Format("{0:N6}\n{1:N6}\n{2:N6}", 0.400000, 0.400000, 0.200000);
            string result = plusMinus.getRatioToPrint(arr);
            Assert.AreEqual(result, expectedresult);
        }
        [TestMethod]
        public void test_PlusMinus_positiveSecond()
        {
            List<int> arr = new List<int>() { -4, 3, -9, 0, 4, 1 };
            string expectedresult = string.Format("{0:N6}\n{1:N6}\n{2:N6}", 0.500000, 0.333333, 0.166667);
            string result = plusMinus.getRatioToPrint(arr);
            Assert.AreEqual(result, expectedresult);
        }

        [TestMethod]
        public void test_PlusMinus_negativeEmptyList()
        {
            List<int> arr = new List<int>(){ };
            bool outOfBoundsValue = plusMinus.isOutOfBounds(arr.Count);
            Assert.IsTrue(outOfBoundsValue);
        }
    }
}
