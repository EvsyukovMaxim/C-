using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a_b
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            int c = Convert.ToInt32(a);
            int d = Convert.ToInt32(b);
            int x = c + d;
            Console.WriteLine(x);
            Console.ReadKey();

        }
    }
}