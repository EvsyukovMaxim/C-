using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int [n];
            int a;
            for (int i = 0; i < n; i++)
            {
                a = Convert.ToInt32(Console.ReadLine());
                numbers[i] = a;
            }

            Array.Sort(numbers);

            for (int i = 0; i < n; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}