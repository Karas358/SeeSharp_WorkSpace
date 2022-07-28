using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeSharp_WorkSpace.HackerRank_TimeConversion
{
    public class TimeConversion
    {
        public static string timeConverter(string time) {
            if (!isEmpty(time))
            {
                if (isValidLength(time))
                {
                    return getMeridiem(time);
                }
            }
            return string.Empty;
        }
        public static bool isValidLength(string time)
        {
            return time.Length == 10;
        }

        public static bool isEmpty(string time)
        {
            return time.Length <= 0; 
        }
        public static int hourConverter(string hour)
        {
            return Int32.Parse(hour);
        }
        public static string getHour(string meridiem, string hour)
        {
            switch (meridiem)
            {
                case "AM":
                    return hourConverter(hour) > 11 ? "00" : (hourConverter(hour) > 9 ? hourConverter(hour).ToString() : string.Format("0{0}", hourConverter(hour)));
                case "PM":
                    return hourConverter(hour) > 11 ? "12" : (hourConverter(hour) + 12).ToString();
            }
            return string.Empty;
        }
        public static string getMeridiem(string time)
        {
            string hour = time.Substring(0, 2);
            string meridiem = time.Substring(8);
            //hour = getHour(meridiem, hour).ToString();
            return string.Format("{0}{1}", getHour(meridiem, hour), time.Substring(2, 6));
        }
    }
}
