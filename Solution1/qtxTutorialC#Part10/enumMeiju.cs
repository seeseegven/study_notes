using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qtxTutorialC_Part10
{
    [Flags]
    internal enum enumMeiju
    {
        tall = 1,
        rich = 2,
        handsome = 4,
        white = 8
    }


    internal class meiju
    {
        internal static void PrintMeiju(enumMeiju meiju)
        {
            if (meiju.HasFlag(enumMeiju.tall))
            {
                Console.WriteLine("Tall");
            }
            if ((meiju & enumMeiju.rich)!=0)
            {
                Console.WriteLine("Rich");
            }
            if ((meiju & enumMeiju.handsome) == enumMeiju.handsome)
            {
                Console.WriteLine("Handsome");
            }//上述三种都可以判断meiju是否含有某个枚举值
            if (meiju.HasFlag(enumMeiju.white))
            {
                Console.WriteLine("White");
            }
            string s = "richo";
            Enum.Parse(typeof(enumMeiju), s);

            enumMeiju meiju2 = (enumMeiju)4;
            //可以直接将整数强制转换为枚举类型
            int enumNumber = (int)enumMeiju.handsome;
            //也可以将枚举类型强制转换为整数类型
            enumMeiju meiju3 = (enumMeiju)(Enum.Parse(typeof(enumMeiju), "tall"));
            //Enum.Parse返回object类型，需要强制转换为enumMeiju类型再赋值。但其他类型可以直接赋给object。
            string s1 = meiju3.ToString();
            //枚举类型可以直接调用ToString()方法转换为字符串。
        }
    }
}
