using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_Number__1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = new List<int>();
            List<int> integersDouble = new List<int>();
            int n = 0;

            while (n != -1)
            {
                n = Convert.ToInt32(Console.ReadLine());
                if (integers.Contains(n))
                {
                    integersDouble.Add(n);
                }
                integers.Add(n);
            }

            Console.Write("Это дублирующиеся значения: ");
            for (int i = 0; i < integersDouble.Count; i++)
            {
                Console.Write(integersDouble[i] + " ");
            }
        }
    }
}
