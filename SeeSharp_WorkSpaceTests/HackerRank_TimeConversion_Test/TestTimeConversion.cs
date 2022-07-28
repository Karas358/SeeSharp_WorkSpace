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
            Assert.AreEqual(true, TimeConversion.isEmpty(time));
        }
        [TestMethod]
        public void TestValidLenth_ValidTime()
        {
            string time = "00:00:00PM";
            Assert.AreEqual(true, TimeConversion.isValidLength(time));
        }
        [TestMethod]
        public void TestValidLenth_InValidTime()
        {
            string time = "0:00:00PM";
            Assert.AreEqual(false, TimeConversion.isValidLength(time));
        }
        [TestMethod]
        public void TestValidTime_SevenAM()
        {
            string time = "07:00:00AM";
            string expectedTime = "07:00:00";
            string timeResult = TimeConversion.timeConverter(time);
            Assert.AreEqual(expectedTime, timeResult);
        }
        [TestMethod]
        public void TestValidTime_SevenPM()
        {
            string time = "07:00:00PM";
            string expectedTime = "19:00:00";
            string timeResult = TimeConversion.timeConverter(time);
            Assert.AreEqual(expectedTime, timeResult);
        }
        [TestMethod]
        public void TestValidTime_TewlvePM()
        {
            string time = "12:01:00PM";
            string expectedTime = "12:01:00";
            string timeResult = TimeConversion.timeConverter(time);
            Assert.AreEqual(expectedTime, timeResult);
        }
        [TestMethod]
        public void TestValidTime_TwelveAM()
        {
            string time = "12:01:00AM";
            string expectedTime = "00:01:00";
            string timeResult = TimeConversion.timeConverter(time);
            Assert.AreEqual(expectedTime, timeResult);
        }
    }
}
