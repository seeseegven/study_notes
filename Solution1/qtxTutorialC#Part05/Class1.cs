using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qtxTutorialC_Part05
{
    class Class1
    {
        internal static void Main1()
        {
            Console.WriteLine("请输入月份：");
            int month = int.Parse(Console.ReadLine());
            int day;
            if (month >= 1 && month <= 12)
            {
                switch (month)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 8:
                    case 7:
                    case 12:
                    case 10:
                        day = 31; break;
                    case 2:
                        day = 28; break;
                    default:
                        day = 30; break;
                }
                Console.WriteLine($"{month}月有{day}天。");
            }
            else
            {
                Console.WriteLine("输入月份不正确");
            }
        }
    }
}
