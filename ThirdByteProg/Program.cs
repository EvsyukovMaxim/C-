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
            int a, b;
            a = Convert.ToByte(Console.ReadLine());
            b=a&(a-1);
            Console.WriteLine(b);
            //Don't know, how to do else
        }
    }
}