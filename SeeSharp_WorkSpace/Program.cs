using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeeSharp_WorkSpace.HackerRank_MiniMaxSum;

namespace SeeSharp_WorkSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            /*CountSay countSay = new CountSay();
            string json = countSay.countAndSay(3);*/
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };
            MiniMaxSum miniMaxSum = new MiniMaxSum();
            Console.WriteLine(miniMaxSum.getMiniMaxSum(numbers));
            Console.ReadLine();
        }
    }
}
