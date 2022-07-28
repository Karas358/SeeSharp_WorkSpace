using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeSharp_WorkSpace.HackerRank_StudentGrades
{
    public class Grade
    {
        public List<int> gradeList(List<int> toBeGraded)
        {
            return toBeGraded.Count() > 0 ? (toBeGraded.Count() < 60 ? getGradedList(toBeGraded) : toBeGraded) : new List<int>();
        }

        public List<int> getGradedList(List<int> toBeGraded)
        {
            List<int> gradedList = new List<int>();
            int currentItem = 0;
            foreach (var item in toBeGraded)
            {
                if(0 < item || item < 100)
                {
                    currentItem = item >= 38 ? gradeValue(ref gradedList, item) : item;
                }
                populateGradedList(ref gradedList, currentItem);
            }
            return gradedList;
        }

        public int gradeValue(ref List<int> gradedList, int item)
        {
            return item % 5 == 0 ? item : promoteGrade( item);
        }
        public List<int> populateGradedList(ref List<int> gradedList, int item)
        {
            gradedList.Add(item);
            return gradedList;
        }
        public int promoteGrade(int item)
        {
            return (item + 1) % 5 == 0 ? (item + 1) : (item + 2) % 5 == 0 ? (item + 2) : item;
        }
    }
}
