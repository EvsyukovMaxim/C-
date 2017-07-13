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
            Console.WriteLine("Введите поочередно число, затем один из операторов: +  -  * или /  затем второе число:");
            int a = Convert.ToInt32(Console.ReadLine());
            string x = Console.ReadLine();
            int b = Convert.ToInt32(Console.ReadLine());
            //int[] Calculator = new int[a];

            switch (x)
            {
                case "+":
                    int plus = a + b;
                    Console.WriteLine(plus);
                    Console.ReadKey();
                    break;
                case "*":
                    int multiplication = a * b;
                    Console.WriteLine(multiplication);
                    Console.ReadKey();
                    break;
                case "-":
                    int minus = a - b;
                    Console.WriteLine(minus);
                    Console.ReadKey();
                    break;
                case "/":
                    if (b == 0)
                    {
                        Console.WriteLine("Are you crazy to divide to ZERO ?!");
                        Console.WriteLine("\n");
                        Console.ReadKey();
                        break;
                    }
                    int division = a / b;
                    Console.WriteLine(division);
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Неверный оператор!!");
                    Console.WriteLine("\n");
                    Console.ReadKey();
                    break;
            }
   
        }
            
    }
}