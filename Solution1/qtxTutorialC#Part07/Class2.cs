using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace qtxTutorialC_Part07
{
    internal class Class2
    {
        public static float GetMax(float[] a)
        {
            float max = a[0];
            for (int i = 1;i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            return max;
        }

        public static void ForEach(int[] array)
        {
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            int[] b = new int[10];
            Array.Copy(a, b, 3);
            int[] c = (int[])a.Clone();

        }
    }
}
