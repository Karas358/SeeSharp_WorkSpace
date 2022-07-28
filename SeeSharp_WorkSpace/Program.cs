using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeeSharp_WorkSpace.HackerRank_MiniMaxSum;
using SeeSharp_WorkSpace.HackerRank_PlusMinus;
using SeeSharp_WorkSpace.HackerRank_TimeConversion;
using SeeSharp_WorkSpace.DelegationAttempt;

namespace SeeSharp_WorkSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            /*CountSay countSay = new CountSay();
            string json = countSay.countAndSay(3);*/

            /*int[] numbers = new int[] { 1, 2, 3, 4, 5 };
            MiniMaxSum miniMaxSum = new MiniMaxSum();
            Console.WriteLine(miniMaxSum.getMiniMaxSum(numbers));
            Console.ReadLine();*/


            /*TestOnSiteHappyWithLocalResults
            int[] n = { -4 ,3, -9, 0, 4 , 1};
            PlusMinus plusMinus = new PlusMinus();
            plusMinus.plusMinus(n);*/

            //A test of time I guess 
            //TimeConversion timeConverion = new TimeConversion();
            //timeConverion.timeConverter("09:00:00AM");

            //An attempt at delegation
            DelegateExampleTest delegateExample = new DelegateExampleTest();
            delegateExample.myMethodAction(Callback);
            Console.ReadLine();

        }
        public static void Callback(int i)
        {
            Console.WriteLine(i);
        }


    }
}
