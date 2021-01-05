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
        public void isArrayInValid_FiveIntegers()
        {
            int[] arr = { 1, 1 , 1 };
            bool res = plusMinus.isArrayInValid(arr.Count());
            Assert.AreEqual(false, res);
        }

        [TestMethod]
        public void isArrayInValid_OutOfBoundValue()
        {
            bool res = plusMinus.isArrayInValid(150);
            Assert.AreEqual(true, res);
        }
    }
}
