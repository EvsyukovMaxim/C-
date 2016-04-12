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
            string a = Console.ReadLine();
            int x, z;
            x = Convert.ToByte(a);
            z = x & (x/2);
            Console.WriteLine(z);
            Console.ReadKey();

        }
    }
}