using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Massive_Task2
{
    public static class ArrayExtension
    {
        public static void PrintArray(this int[] array)
        {
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
        }

        public static string ReturnArray(this int[] array, string separator)
        {
            string a = "";
            for (int i = 0; i < array.Count(); i++)
            {
                a = a + (" " + separator + array[i] + separator);
            }
            return a;
        }
    }
}