using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeeSharp_WorkSpace.BirthdayCandle;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SeeSharp_WorkSpaceTests.BirthdayCakeTest
{
    [TestClass]
    public class TestBirthdayCake
    {
        BirthdayCakeCandle birthdayCakeCandle = new BirthdayCakeCandle();
        List<int> listCandles = null;

        [TestMethod]
        public void getCandles_FiveCandles_TwoFour()
        {
            listCandles = new List<int>() {4,4,1,3 };
            var res = birthdayCakeCandle.getCandles(listCandles);
            Assert.AreEqual(2, res);
        }



        [TestMethod]
        public void isInvalidValid_FiveCandles() {
            listCandles = new List<int>(){1, 1, 2, 4, 4 };
            var res = birthdayCakeCandle.isInValid(listCandles.Count);
            Assert.AreEqual(false, res);
        }

        [TestMethod]
        public void isInvalidValid_OutOfBoundNumbers_105000()
        {
            var res = birthdayCakeCandle.isInValid(105000);
            Assert.AreEqual(true, res);
        }
    }
}
