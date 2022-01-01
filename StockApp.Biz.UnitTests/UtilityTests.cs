using NUnit.Framework;
using System;

namespace StockApp.Biz.UnitTests
{
    public class UtilityTests
    {
        public class TestableUtility : Utility 
        {
            public bool IsTaiwanStockWorkingDay(DateTime today) => base.IsTaiwanStockWorkingDay(today);
        }
        
    }
}