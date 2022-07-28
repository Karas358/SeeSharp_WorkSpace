using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeeSharp_WorkSpace.HackerRank_StudentGrades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeSharp_WorkSpaceTests.HackerRank_StudentGrades_Test
{
    [TestClass]
    public class GradeTest
    {
        Grade grade = new Grade();
        /// <summary>
        ///    Below is promoteGrade test using various numbers
        /// </summary>
        [TestMethod]
        public void test_promoteGrade_87()
        {
            int result = grade.promoteGrade(87);
            Assert.AreEqual(87, result);
        }
        [TestMethod]
        public void test_promoteGrade_88()
        {
            int result = grade.promoteGrade(88);
            Assert.AreEqual(90, result);
        }
        [TestMethod]
        public void test_promoteGrade_83()
        {
            int result = grade.promoteGrade(83);
            Assert.AreEqual(85, result);
        }
        [TestMethod]
        public void test_promoteGrade_82()
        {
            int result = grade.promoteGrade(82);
            Assert.AreEqual(82, result);
        }
        [TestMethod]
        public void test_promoteGrade_77()
        {
            int result = grade.promoteGrade(77);
            Assert.AreEqual(80, result);
        }
        /// <summary>
        ///     Below is grade process tests
        /// </summary>
        [TestMethod]
        public void test_gradeList()
        {
            List<int> gradeList = new List<int>()
            {
                73,67,38,33
            };
            List<int> expectedGradeList = new List<int>()
            {
                75,67,40,33
            };
            var result = grade.gradeList(gradeList);
            CollectionAssert.AreEqual(expectedGradeList, result);
        }
        [TestMethod]
        public void test_gradeList_zeroToFive()
        {
            List<int> gradeList = new List<int>()
            {
                0,0,0,0
            };
            List<int> expectedGradeList = new List<int>()
            {
                5,5,5,5
            };
            var result = grade.gradeList(gradeList);
            CollectionAssert.AreEqual(expectedGradeList, result);
        }

        [TestMethod]
        public void test_gradeList_zeroToZero()
        {
            List<int> gradeList = new List<int>()
            {
                0,0,0,0
            };
            List<int> expectedGradeList = new List<int>()
            {
                0,0,0,0
            };
            var result = grade.gradeList(gradeList);
            CollectionAssert.AreEqual(expectedGradeList, result);
        }
        [TestMethod]
        public void test_gradeList_zeroToNegatives()
        {
            List<int> gradeList = new List<int>()
            {
                -1,0,0,0
            };
            List<int> expectedGradeList = new List<int>()
            {
                -1,0,0,0
            };
            var result = grade.gradeList(gradeList);
            CollectionAssert.AreEqual(expectedGradeList, result);
        }
        [TestMethod]
        public void test_gradeList_null_TO_null_List()
        {
            List<int> gradeList = new List<int>();
            List<int> expectedGradeList = new List<int>();
            var result = grade.gradeList(gradeList);
            CollectionAssert.AreEqual(expectedGradeList, result);
        }
        [TestMethod]
        public void test_gradeList_nullList()
        {
            List<int> gradeList = new List<int>();
            
            List<int> expectedGradeList = new List<int>()
            {
                5,5,5,5
            };
            var result = grade.gradeList(gradeList);
            CollectionAssert.AreEqual(expectedGradeList, result);
        }

        [TestMethod]
        public void test_gradeList_MoreThanSixty()
        {
            List<int> gradeList = new List<int>()
            {
                73,67,38,33,73,67,38,33,73,67,
                73,67,38,33,73,67,38,33,73,67,
                73,67,38,33,73,67,38,33,73,67,
                73,67,38,33,73,67,38,33,73,67,
                73,67,38,33,73,67,38,33,73,67,
                73,67,38,33,73,67,38,33,73,67,
                38,33
            };
            List<int> expectedGradeList = new List<int>()
            {
                75,67,40,33,75,67,40,33,75,67,
                75,67,40,33,75,67,40,33,75,67,
                75,67,40,33,75,67,40,33,75,67,
                75,67,40,33,75,67,40,33,75,67,
                75,67,40,33,75,67,40,33,75,67,
                75,67,40,33,75,67,40,33,75,67,
                40,33
            };
            var result = grade.gradeList(gradeList);
            CollectionAssert.AreEqual(expectedGradeList, result);
        }
        [TestMethod]
        public void test_gradeList_MoreThanSixty_TO_ACTUAL()
        {
            List<int> gradeList = new List<int>()
            {
                73,67,38,33,73,67,38,33,73,67,
                73,67,38,33,73,67,38,33,73,67,
                73,67,38,33,73,67,38,33,73,67,
                73,67,38,33,73,67,38,33,73,67,
                73,67,38,33,73,67,38,33,73,67,
                73,67,38,33,73,67,38,33,73,67,
                38,33
            };
            List<int> expectedGradeList = new List<int>()
            {
                73,67,38,33,73,67,38,33,73,67,
                73,67,38,33,73,67,38,33,73,67,
                73,67,38,33,73,67,38,33,73,67,
                73,67,38,33,73,67,38,33,73,67,
                73,67,38,33,73,67,38,33,73,67,
                73,67,38,33,73,67,38,33,73,67,
                38,33
            };
            var result = grade.gradeList(gradeList);
            CollectionAssert.AreEqual(expectedGradeList, result);
        }
        [TestMethod]
        public void test_gradeList_MoreThanSixty_toNew()
        {
            List<int> gradeList = new List<int>()
            {
                73,67,38,33,73,67,38,33,73,67,
                73,67,38,33,73,67,38,33,73,67,
                73,67,38,33,73,67,38,33,73,67,
                73,67,38,33,73,67,38,33,73,67,
                73,67,38,33,73,67,38,33,73,67,
                73,67,38,33,73,67,38,33,73,67,
                38,33
            };
            List<int> expectedGradeList = new List<int>();
            var result = grade.gradeList(gradeList);
            CollectionAssert.AreEqual(expectedGradeList, result);
        }

        [TestMethod]
        public void test_gradeList_moREtHAN100()
        {
            List<int> gradeList = new List<int>()
            {
                100,101,99,0
            };
            List<int> expectedGradeList = new List<int>()
            {
                100,101,100,0
            };
            var result = grade.gradeList(gradeList);
            CollectionAssert.AreEqual(expectedGradeList, result);
        }
        [TestMethod]
        public void test_gradeList_moREtHAN_100()
        {
            List<int> gradeList = new List<int>()
            {
                60,64,24,68,14, 53,49,45,99,55,
                24,59,67,8,76, 37,24,24,73,81,
                37,47,63,99,63, 40,54,82,9,80,
                84,15,32,51,18, 70,4,86,59,32,
                68,22,1,71,51, 81,22,35,65,9,
                17,94,69,40,39, 52,94,84,13,68,
                95
            };
            List<int> expectedGradeList = new List<int>()
            {
                100,101,100,0
            };
            var result = grade.gradeList(gradeList);
            CollectionAssert.AreEqual(expectedGradeList, result);
        }
    }
}
