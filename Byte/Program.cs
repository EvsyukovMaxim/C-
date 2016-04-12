using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Byte
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            string i = Console.ReadLine();
            int a, b;
            int c, d;
            a = Convert.ToByte(n);
            b = Convert.ToByte(i);
            c = (a >> b);
            d = (c & 1);
            Convert.ToString(d);
            Console.WriteLine(d);
            Console.ReadKey();

        }
    }
}