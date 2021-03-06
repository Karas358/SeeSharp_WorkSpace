using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeeSharp_WorkSpace.HackerRank_TimeConversion;

namespace SeeSharp_WorkSpaceTests.HackerRank_TimeConversion_Test
{
    [TestClass]
    public class TestTimeConversion
    {
        [TestMethod]
        public void TestEmpty_EmptyValue()
        {
            string time = "";
            TimeConversion timeConverion = new TimeConversion();
            Assert.AreEqual(true, timeConverion.isEmpty(time));
        }
        [TestMethod]
        public void TestValidLenth_ValidTime()
        {
            string time = "00:00:00PM";
            TimeConversion timeConverion = new TimeConversion();
            Assert.AreEqual(true, timeConverion.isValidLength(time));
        }
        [TestMethod]
        public void TestValidLenth_InValidTime()
        {
            string time = "0:00:00PM";
            TimeConversion timeConverion = new TimeConversion();
            Assert.AreEqual(false, timeConverion.isValidLength(time));
        }
        [TestMethod]
        public void TestValidTime_SevenAM()
        {

        }
        [TestMethod]
        public void TestValidTime_SevenPM()
        {

        }
    }
}
