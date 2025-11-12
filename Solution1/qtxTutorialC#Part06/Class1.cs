using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qtxTutorialC_Part06
{
    internal class Class1
    {
        internal static void main1()
        {
            double thinkness = 0.01;
            for (int i=0;i<30;i++)
            {
                thinkness *= 2;
            }
            Console.WriteLine(thinkness);
        }

        internal static void main2()
        { 
            Random rand = new Random();
            
            rand.Next(1,101);
            string str = "abcde";
            char a = '我';
            bool res = str.Contains("b");
            str = str.Remove(3);
        }
    }
    internal class  class2
    {
        internal static void main2()
        {
            double s = 0,height = 100;
            int i = 0;
            while (height/2 >= 0.01)
            {
                s += height;
                height *= 0.5;
                i++;
                s += height;
            }
            s += height;
            Console.WriteLine($"弹了{i}次，共经过{s}米。");
        }
        
    }
}
