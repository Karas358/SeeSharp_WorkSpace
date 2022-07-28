using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeSharp_WorkSpace.HackerRank_Staircase
{
    public class Staircase
    {
        public string getStaircase(int n)
        {
            return n > 0 ? (n < 100 ? printStaircase(n) : string.Empty) : string.Empty;
        }

        public string printStaircase(int n)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int countRow = 0; countRow < n; countRow++)
            {
                stringBuilder.Append(getRow(countRow, n));
            }
            return stringBuilder.ToString();
        }

        public string getRow(int countRow, int size) 
        {
            string hashChar = "#";
            string emptySpace = " ";
            int spaceCount = size - (countRow + 1);
            int hashCount = size - spaceCount;
            string stringBuilder = null;
            for(int z = 0; z < spaceCount; z++)
            {
                stringBuilder += emptySpace;
            }
            for (int i = 0; i < hashCount; i++)
            {
                stringBuilder += hashChar;
            }
            return string.Format("{0}\n",stringBuilder);
        }
    }

}
