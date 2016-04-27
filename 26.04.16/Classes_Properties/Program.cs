using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Telephone myTelephone = new Telephone("999", "9999999");

            Console.WriteLine($"{ myTelephone.FullNumber(Console.ReadLine(), Console.ReadLine())}");
        }
    }
}
