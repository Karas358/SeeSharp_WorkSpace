using System;
using SeeSharp_WorkSpace.HackerRank_MiniMaxSum;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SeeSharp_WorkSpaceTests.MiniMaxSumTests
{
    [TestClass]
    public class TestMiniMaxSum
    {
        MiniMaxSum miniMaxSum = new MiniMaxSum();
        [TestMethod]
        public void MiniMaxSum_isValid_FivePositive()
        {
            int[] numbers = new int[] {1, 2, 3 ,4 , 5};
            var res = miniMaxSum.isValid(numbers);
            Assert.AreEqual(true, res);
        }
        [TestMethod]
        public void MiniMaxSum_isValid_FourPositiveOneNegative()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, -5 };
            var res = miniMaxSum.isValid(numbers);
            Assert.AreEqual(false, res);
        }

        [TestMethod]
        public void MiniMaxSum_getMiniSum_FivePositive()
        {
            
            //int[] numbers = new int[] { 1, 2, 3, 4, 5 };
            int[] numbers = new int[] { 7, 69, 2, 221, 8974 };
            var res = miniMaxSum.getMiniSum(numbers);
            Assert.AreEqual(299, res);
        }
        [TestMethod]
        public void MiniMaxSum_getMaxSum_FivePositive()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = miniMaxSum.getMaxSum(numbers);
            Assert.AreEqual(14, res);
        }
        [TestMethod]
        public void MiniMaxSum_getMiniMaxSum()
        {
/*            int[] numbers = new int[] { 1, 2, 3, 4, 5 };
*/            int[] numbers = new int[] { 256741038, 623958417, 467905213, 714532089, 938071625 };
            var res = miniMaxSum.getMiniMaxSum(numbers);
            Assert.AreEqual("2063136757 2744467344", res);
        }
    }
}
