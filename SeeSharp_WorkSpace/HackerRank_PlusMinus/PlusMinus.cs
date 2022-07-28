using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeSharp_WorkSpace.HackerRank_PlusMinus
{
    public class PlusMinus
    {
        public PlusMinus()
        {
            
        }
        public string getRatioToPrint(List<int> arr)
        {
            if (!isOutOfBounds(arr.Count))
            {
              return countNumbers(arr);
            }
            return string.Empty;
        }
        public string countNumbers(List<int> arr)
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
            return printNumbers(positive, negative, zero, arr.Count);
        }

        public string printNumbers(double pos, double neg, double z, double arrLen)
        {
            return  string.Format("{0:N6}", pos / arrLen) + "\n" +
                        string.Format("{0:N6}", neg / arrLen) + "\n" +
                        string.Format("{0:N6}", z / arrLen);
        }
        public bool isOutOfBounds(int count)
        {
            return 0 >= count || count > 100;
        }
    }
}
