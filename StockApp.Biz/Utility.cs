using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.Biz
{
    public class Utility
    {
        private bool IsTaiwanStockWorkingDay(DateTime today)
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
重構練習 判斷是否為股票營業時間程式1. 為既有程式碼撰寫單元測試, 確保目前程式正確, 稍後