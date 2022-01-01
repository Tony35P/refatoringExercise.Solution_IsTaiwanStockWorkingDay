using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.Biz
{
    public class Utility
    {
        protected bool IsTaiwanStockWorkingDay(DateTime today)
        {
            DateTime start = new DateTime(today.Year, today.Month, today.Day, 9, 0, 0, 0);
            DateTime end = new DateTime(today.Year, today.Month, today.Day, 13, 30, 0, 0);
            int weekday = int.Parse(DateTime.Now.DayOfWeek.ToString("d"));
            if ((weekday > 1 && weekday < 5) && (today.CompareTo(start) >= 0 && today.CompareTo(end) <= 0))
                return true;
            return false;

        }
    }
}
