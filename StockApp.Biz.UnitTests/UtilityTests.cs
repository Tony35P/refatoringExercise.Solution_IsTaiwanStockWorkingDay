using NUnit.Framework;
using System;

namespace StockApp.Biz.UnitTests
{
    public class UtilityTests
    {
        
        [TestCase("2022/1/1")]
        [TestCase("2022/1/2")]
        public void IsTaiwanStockWorkingDay_星期六日傳回false(string dt)
        {
            DateTime today = Convert.ToDateTime(dt);

            bool actual = new TestableUtility().TestIsTaiwanStockWorkingDay(today);

            Assert.IsFalse(actual);
        }

        [TestCase("2022/1/3 8:59:59")]
        [TestCase("2022/1/3 13:30:01")]
        public void IsTaiwanStockWorkingDay_平日非營業時間傳回false(string dt)
        {
            DateTime today = Convert.ToDateTime(dt);

            bool actual = new TestableUtility().TestIsTaiwanStockWorkingDay(today);

            Assert.IsFalse(actual);
        }

        [TestCase("2022/1/3 9:00:01")]
        [TestCase("2022/1/3 13:29:59")]
        [TestCase("2022/1/4 9:00:01")]
        [TestCase("2022/1/5 9:00:01")]
        [TestCase("2022/1/6 9:00:01")]
        [TestCase("2022/1/7 9:00:01")]
        public void IsTaiwanStockWorkingDay_星期一至五營業時間傳回true(string dt)
        {
            DateTime today = Convert.ToDateTime(dt);

            bool actual = new TestableUtility().TestIsTaiwanStockWorkingDay(today);

            Assert.IsTrue(actual);
        }
        public class TestableUtility : Utility 
        {
            public bool TestIsTaiwanStockWorkingDay(DateTime today) => base.IsTaiwanStockWorkingDay(today);
        }
        
    }
}