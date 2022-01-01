﻿using System;
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
            TimeSpan beginWorkingHour = TimeSpan.FromHours(9);
            TimeSpan endWorkingHour = TimeSpan.FromHours(13.5);

            DateTime beginTime = now.Date.Add(beginWorkingHour);
            DateTime endTime = now.Date.Add(endWorkingHour);

            return now.IsWorkingday() && now.Between(beginTime,endTime);                            
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
        public static bool Between(this int source, int minValue, int maxValue)
            => source >= minValue && source <= maxValue;
    }
}
