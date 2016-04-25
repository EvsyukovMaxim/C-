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
            int n = Convert.ToInt32(Console.ReadLine());
            List<int> Integers = new List<int>();

            while (n != -1)
            {
                Integers.Add(n);
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(Integers[i] + " ");
            }
        }
    }
}
