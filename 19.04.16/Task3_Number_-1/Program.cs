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
            List<int> Integers = new List<int>();
            int n = Convert.ToInt32(Console.ReadLine());
            while (n != -1)
            {
                n = Convert.ToInt32(Console.ReadLine());
                Integers.Add(n);
            }

            for (int i = 0; i < Integers.Count; i++)
            {
                Console.Write(Integers[i] + " ");
            }
        }
    }
}
