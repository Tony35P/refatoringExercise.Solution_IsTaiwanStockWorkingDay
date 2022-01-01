using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.Biz
{
    public class Utility
    {
        public bool IsTaiwanStockWorkingDay(DateTime now)
        {
            if(!now.IsWorkingday()) return false;

            return now.Between(now.Date.Add(9.Hours()), now.Date.Add(13.Hours() + 30.Minutse()));                            
        }
    }

    public static class DateTimeExts
    {
        public static bool IsWorkingday(this DateTime source)
            => ((int)source.DayOfWeek).Between(1, 5);
        public static bool Between(this DateTime source, DateTime minValue, DateTime maxValue)
            => source>=minValue && source<=maxValue;
    }
    
    public static class IntExts
    {
        public static TimeSpan Hours(this int source)=> TimeSpan.FromHours(source);

        public static TimeSpan Minutse(this int source) => TimeSpan.FromMinutes(source);

        public static bool Between(this int source, int minValue, int maxValue)
            => source >= minValue && source <= maxValue;
    }
}
