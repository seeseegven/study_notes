using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qtxTutorialC_Part08
{
    internal class CaiPiao
    {
        internal static int[] Buy()
        {
            int[] bought = new int[7];
            for (int i = 0; i < 6; )
            {
                Console.WriteLine($"Enter {i+1} red you wanna buy,1~33:");
                int num = int.Parse(Console.ReadLine());
                if (num > 0&&num <= 33 && Array.IndexOf(bought, num) == -1)
                {
                    bought[i++] = num;
                }
            }
            while (true)
            {
                Console.WriteLine("Enter blue you wanna buy,1~17:");
                bought[6] = int.Parse(Console.ReadLine());
                if (bought[6] > 0 && bought[6] <= 16)
                {
                    break;
                }
            }
            return bought;
        }
        static Random random = new Random();
        internal static int[] Result()
        {
            int[] result = new int[7];
            for (int i = 0;i < 6; )
            {
                int num = random.Next(1, 34);
                if (Array.IndexOf(result, num)==-1)
                {
                    result[i++] = num;
                }
            }
            result[6] = random.Next(1, 17);
            Array.Sort(result, 0, 6);
            return result;
        }

        internal static int judge(int[] bought, int[] result)
        {
            int redCount = 0;
            for (int i = 0; i < 6; i++)
            {
                if (Array.IndexOf(result, bought[i],0,6) != -1)
                {
                    redCount++;
                }
            }
            bool blueMatch = bought[6] == result[6];
            if (redCount == 6 && blueMatch) return 1;
            else if (redCount == 6) return 2;
            else if (redCount == 5 && blueMatch) return 3;
            else if (redCount == 5 || (redCount == 4 && blueMatch)) return 4;
            else if (redCount == 4 || (redCount == 3 && blueMatch)) return 5;
            else if (blueMatch) return 6;
            return 0;
        }

        internal static void Simulation()
        {
            int[] ints = Buy();
            int money = 2;
            int[] result = Result();
            int prizeLevel = judge(ints, result);
            while (prizeLevel != 1)
            {
                result = Result();
                money += 2;
                prizeLevel = judge(ints, result);
                //if (prizeLevel > 1)
                Console.WriteLine($"{prizeLevel}等奖,共花费{money}元.");
            }
        }
    }
}
