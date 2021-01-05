using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeSharp_WorkSpace.BirthdayCandle
{
    public class BirthdayCakeCandle
    {
        //Sort Candles 
        //Get Last Candle
        //0(N) Solution 



        public int getCandles(List<int> candles)
        {
            int len = candles.Count;
            if (isInValid(len)) return 0;

            var res = candles.Max<int>();
            var count = candles.Where(x => x == res).Count();
            return count;
        }

        public bool isInValid(int candles)
        {
            return 0 > candles || candles > 100000;
        }
    }
}
