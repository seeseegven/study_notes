using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//年历练习。
namespace qtxTutorialC_Part06
{
    internal class Class2
    {
        /// <summary>
        /// 根据年月日获取星期数。
        /// </summary>
        /// <param name="year">年</param>
        /// <param name="month">月</param>
        /// <param name="day">日</param>
        /// <returns>返回星期数</returns>
        internal static int GetWeekByDay(int year, int month, int day)
        {
            DateTime dt = new DateTime(year, month, day);
            return (int)dt.DayOfWeek;
        }
        /// <summary>
        /// 判断闰年平年
        /// </summary>
        /// <param name="year">年份</param>
        /// <returns>返回true或false</returns>
        internal static bool JudgeLeapYear(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 根据月份获取天数
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns>返回天数</returns>
        internal static int DaysByMonth(int year, int month)
        {
            int[] daysInMonths = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (month == 2 && JudgeLeapYear(year))
            {
                return 29;
            }
            return daysInMonths[month - 1];
        }
        /// <summary>
        /// 显示某年某月的日历
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        internal static void ShowMonthCalendar(int year, int month)
        {
            Console.WriteLine("日\t一\t二\t三\t四\t五\t六");
            int spareDay = GetWeekByDay(year, month, 1);
            for (int i=0;i< spareDay; i++)
            {
                Console.Write("\t");
            }
            int days = DaysByMonth(year, month);
            for (int day = 1; day <= days; day++)
            {
                Console.Write(day + "\t");
                if ((day+spareDay) % 7 == 0)
                {
                    Console.WriteLine("\n");
                }
            }
            Console.WriteLine("\n\n");
        }
        
        internal static void ShowCalendar(int year)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i}月\n");
                ShowMonthCalendar(year, i);
            }
        }
        internal static void Main2()
        {
            Console.WriteLine("请输入年份：");
            int year = int.Parse(Console.ReadLine());
            ShowCalendar(year);
                
        }
    }

   
}
