using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                int x = Convert.ToInt32(Console.ReadLine());
                numbers[i] = x;
            }

            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if (a == numbers[i])
                {
                    Console.WriteLine("Yes");
                    break;
                }
                else
                {
                    Console.WriteLine("No");
                    break;
                }
            }
        }
    }
}
