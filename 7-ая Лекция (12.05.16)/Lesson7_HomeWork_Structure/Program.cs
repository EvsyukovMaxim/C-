using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_HomeWork_Structure
{
    class Program
    {
        static void Main(string[] args)
        {
            object f1 = Fraction.ReturnFraction(2, 4);
            object f2 = Fraction.ReturnFraction(0, 5);

            Fraction.PrintFraction(f1);
            Fraction.PrintFraction(f2);

            Console.WriteLine(((Fraction)f1).Addition((Fraction)f2));
            Console.WriteLine(((Fraction)f1).Subtraction((Fraction)f2));
            Console.WriteLine(((Fraction)f1).Multiplication((Fraction)f2));
            Console.WriteLine(((Fraction)f1).Division((Fraction)f2));
        }
    }
}
