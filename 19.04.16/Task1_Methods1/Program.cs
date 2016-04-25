using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods1_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            decimal[] numbers = new decimal[n];
            decimal a;
            for (int i = 0; i < n; i++)
            {
                a = ReadDec();
                numbers[i] = a;
            }

            for (int i = 0; i < n; i++)
            {
                PrintDec(numbers[i]);
            }
        }

        //static int ReadInt()
        //{
        //    return Convert.ToInt32(Console.ReadLine());
        //}

        static decimal ReadDec()
        {
            return Convert.ToDecimal(Console.ReadLine());
        }

        static void PrintDec(decimal number)
        {
            Console.Write(number + " ");
        }
    }
}
