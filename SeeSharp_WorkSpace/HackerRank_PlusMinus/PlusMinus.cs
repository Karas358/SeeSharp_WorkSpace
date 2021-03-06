using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeSharp_WorkSpace.HackerRank_PlusMinus
{
    public class PlusMinus
    {
        public void plusMinus(int[] arr)
        {
            if(!isOutOfBounds(arr.Length))
            {
                countNumbers(arr);
            }
        }
        public void countNumbers(int[] arr)
        {
            double positive = 0;
            double negative = 0;
            double zero = 0;
            foreach(int x in arr){
                if(x > 0)
                {
                    positive++;
                }
                else if(x < 0)
                {
                    negative++;
                }
                else if (x == 0)
                {
                    zero++;
                }
            }
            printNumbers(positive, negative, zero, arr.Length);
        }

        public void printNumbers(double pos, double neg, double z, double arrLen)
        {
            decimal poss = (decimal)(pos/arrLen);
            string zs = string.Format("{0:N6}",poss) + "\n" +
                        string.Format("{0:N6}", neg / arrLen) + "\n" +
                        string.Format("{0:N6}", z / arrLen);
            Console.WriteLine(zs);
            Console.ReadLine();
        }
        public bool isOutOfBounds(int count)
        {
            return 0 > count || count > 100;
        }
    }
}
