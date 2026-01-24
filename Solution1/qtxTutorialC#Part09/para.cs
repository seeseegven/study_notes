using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qtxTutorialC_Part09
{
    internal class para
    {
        internal static void Add(params int[] nums)
        {
            //加了params则可以直接传入不定数量的值甚至不传；反之需要传入数组。
            int res = 0;
            foreach (var item in nums)
            {
                res += item;
            }
            Console.WriteLine("和为：" + res);
        }

        internal static void ExchageAandB(ref int a, ref int b)
        {
            //ref传引用，可以直接修改实参的值
            int temp = a;
            a = b;
            b = temp;
        }

        internal static void CalSandC(int a, int b, out int s, out int c)
        {
            s = a * b;
            c = (a + b) * 2;
        }

        internal static void Tryparse()
        {
            int res;
            bool re = int.TryParse("123abc", out res);
        }
    }
}
