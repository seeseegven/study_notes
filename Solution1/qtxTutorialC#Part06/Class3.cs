using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qtxTutorialC_Part06
{
    internal class Class3
    {
        internal static int ReturnSbyMinutes(int minutes)
        {
            return minutes * 60;
        }

        internal static int ReturnSbyMinutesAndHours(int minutes, int hours)
        {
            return hours * 3600 + ReturnSbyMinutes(minutes);
        }

        internal static int ReturnSbyMinutesAndHoursAndDays(int minutes, int hours, int days)
        {
            return ReturnSbyMinutesAndHours(minutes, hours) + days * 3600 * 24;
        } 
        internal static int ReturnTotalSec(int minutes)
        {
            return minutes * 60;
        }

        internal static int ReturnTotalSec(int minutes, int hour)
        {
            return ReturnTotalSec(minutes + hour * 60);
        }

        internal static int ReturnTotalSec(int minutes, int hour, int day)
        {
            return ReturnTotalSec(minutes, hour + day * 24);
        }
    }
}
