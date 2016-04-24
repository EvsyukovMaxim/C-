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

            for (int i = 0; i < n; i++)
            {
                int x = Convert.ToInt32(Console.ReadLine());
                numbers[i] = x;
            }

            int a = Convert.ToInt32(Console.ReadLine());
            Boolean HaveNumber = false;
            for (int i = 0; i < n; i++)
            {
                if (a == numbers[i])
                {
                    HaveNumber = true;
                    break;
                }
            }
            if (HaveNumber == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
                //break;
            }
        }
    }
}
