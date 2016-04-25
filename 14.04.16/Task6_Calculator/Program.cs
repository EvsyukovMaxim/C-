using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            string x = Console.ReadLine();
            //int[] Calculator = new int[a];

            switch (x == "+")
            {
                case 0:
                    int plus = a + b;
                    Console.WriteLine(plus);
                    break;  
                case 1:
                    int multiplication = a * b;
                    Console.WriteLine(multiplication);
                    break;
            }
   
        }
            
    }
}
