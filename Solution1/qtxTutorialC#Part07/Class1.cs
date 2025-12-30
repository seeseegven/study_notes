using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qtxTutorialC_Part07
{
    internal class Class1
    {
        internal void ShowArray()
        {
            int[] a;
            //声明
            a = new int[5];
            //初始化，感觉比c++麻烦
            a[0] = 10;
            //这倒是和C++一样

            int[] b = new int[3] { 1, 2, 3 };
            //也可以这样赋值

            bool[] c = { true, false, false, true };
            //也可以声明+初始化+赋值
        }

        internal static float[] GetStudentScore()
        {
            Console.WriteLine($"请输入学生总数：");
            int studentCount = int.Parse(Console.ReadLine());
            float[] Score = new float[studentCount];
            for (int i = 0; i < studentCount;)
            {
                Console.WriteLine($"请输入第{i + 1}个学生的成绩：");
                float score = float.Parse(Console.ReadLine());
                if (score >= 0 && score <=100)
                Score[i++] = score;
                else
                    Console.WriteLine("输入成绩无效，请重新输入");
            }
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"第{i + 1}个学生的成绩是：{Score[i]}");
            }
            return Score;
        }

        internal static int GetDayByYear_Month_Day(int year, int month, int day)
        {
            int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (year % 4 ==0 && year %100 != 0 || year % 400 == 0)
            {
                days[1]++;
                
            }
            int sum = 0;
            for (int i = 0; i < month - 1; i++)
            {
                sum += days[i];
            }
            sum += day;
            return sum;
        }
    }
}
