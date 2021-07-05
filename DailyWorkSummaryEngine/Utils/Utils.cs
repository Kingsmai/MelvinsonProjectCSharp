using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyWorkSummaryEngine.Utils
{
    public static class Utils
    {
        /// <summary>
        /// 返回当前日期字符串
        /// </summary>
        /// <returns>纯数字日期字符串</returns>
        public static string GetTodayDate()
        {
            DateTime now = DateTime.Now;
            string todayDateString = now.ToString("yyyyMMdd", DateTimeFormatInfo.InvariantInfo);

            return todayDateString;
        }

        /// <summary>
        /// 将小于10的数补上0
        /// </summary>
        /// <param name="number">需要判断的数值</param>
        /// <returns>调整之后的数值（已被转转为字符串）</returns>
        private static string zeroFixed(int number)
        {
            return number < 10 ? "0" + number : number.ToString();
        }
    }
}
