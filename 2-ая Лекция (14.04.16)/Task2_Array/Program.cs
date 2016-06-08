using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Massive_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int [n];
            for (int i = 0; i < n; i++)
            {
                int a = Convert.ToInt32(Console.ReadLine());
                numbers[i] = a;
            }

            Array.Sort(numbers);

            //numbers.PrintArray();
            numbers.ReturnArray("\'");
        }
    }
}