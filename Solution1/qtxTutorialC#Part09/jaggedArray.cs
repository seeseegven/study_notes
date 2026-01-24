using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qtxTutorialC_Part09
{
    internal class jaggedArray
    {
        //交错数组类似
        //{{1,2,3},
        //{4,5},
        //{6,7,8,9}
        internal static void CreateJaggedArrary()
        {
            int[][] array;//null
            array = new int[4][];//长度为4的交错数组，只能这么写，第二个[]不能写数字
            array[0] = new int[3] {1, 2, 3 };//第一行长度为3,元素为1，2，3
            array[1] = new int[4];
            array[1][2] = 5;
            array[2] = new int[2] { 6, 7 };
            array[3] = new int[6];
            for (int i=0; i< array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
