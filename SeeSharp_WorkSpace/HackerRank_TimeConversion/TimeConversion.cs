using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeSharp_WorkSpace.HackerRank_TimeConversion
{
    public class TimeConversion
    {
        public void timeConverter(string time) {
            if (!isEmpty(time))
            {
                if (isValidLength(time))
                {
                    Console.WriteLine(getMeridiem(time));
                    Console.ReadLine();
                }
            }
        }
        public bool isValidLength(string time)
        {
            return time.Length == 10;
        }

        public bool isEmpty(string time)
        {
            return time.Length <= 0; 
        }
        public int hourConverter(string hour)
        {
            return Int32.Parse(hour);
        }
        public int getHour(string meridiem, string hour)
        {
            switch (meridiem)
            {
                case "AM":
                    if (hourConverter(hour) > 11)
                    {
                        return 0;
                    }
                    else
                    {
                        return hourConverter(hour);
                    }
                case "PM":
                    if (hourConverter(hour) > 11)
                    {
                        return 12;
                    }
                    else
                    {
                        return hourConverter(hour) + 12;
                    }
            }
            return 0;
        }
        public string getMeridiem(string time)
        {
            string hour = time.Substring(0, 2);
            string meridiem = time.Substring(8);
            return getHour(meridiem, hour) + time.Substring(2, 6);
        }
    }
}
