using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeSharp_WorkSpace.HackerRank_MiniMaxSum
{
    public class MiniMaxSum
    {
        

        List<int> numbersTotal = new List<int>();

        int lowestMin = 1, highestMax = 1000000000;
        public string getMiniMaxSum(int[] numbers)
        {
            if (isValid(numbers))
            {
                Array.Sort(numbers);
                return getMiniSum(numbers) + " " + getMaxSum(numbers);
            }
            return "0";
        }
        public long getMiniSum(int[] numbers)
        {
            return getSum(numbers, 0 , numbers.Length - 1);
        }
        public long getMaxSum(int[] numbers)
        {
            return getSum(numbers, 1, numbers.Length);
        }
        public long getSum(int[] numbers, int start, int end)
        {
            long sumVaue = 0;
            //int sum = 0;
            while(start < end)
            {
                sumVaue += numbers[start];
                start++;
            }
            return sumVaue;
        }
        public Boolean isValid(int[] numbers)
        {
            return checkLength(numbers) && allNumbersValid(numbers);
        }

        public Boolean checkLength(int[] numbers)
        {
            if (lowestMin < numbers.Length && numbers.Length < highestMax) return true;
            return false;
        }
        public Boolean allNumbersValid(int[] numbers)
        {
            foreach(int z in numbers){
                if (lowestMin > z || z > highestMax) return false;
            }
            return true;
        }
    }
}
