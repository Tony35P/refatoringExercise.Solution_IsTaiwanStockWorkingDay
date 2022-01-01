using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.Biz
{
    public class Utility
    {
        public bool IsTaiwanStockWorkingDay(DateTime today)
        {
            const int beginWorkingDay = 1, endWorkingDay = 5;
            TimeSpan beginWorkingHour = TimeSpan.FromHours(9);
            TimeSpan endWorkingHour = TimeSpan.FromHours(13.5);

            //DateTime start = new DateTime(today.Year, today.Month, today.Day, 9, 0, 0, 0);
            //DateTime end = new DateTime(today.Year, today.Month, today.Day, 13, 30, 0, 0);
            DateTime beginTime = today.Date.Add(beginWorkingHour);
            DateTime endTime = today.Date.Add(endWorkingHour);


            int weekday = int.Parse(today.DayOfWeek.ToString("d"));
            if ((weekday >= beginWorkingDay && weekday <= endWorkingDay) && (today.CompareTo(beginTime) >= 0 && today.CompareTo(endTime) <= 0))
                return true;
            return false;

        }
    }
}
