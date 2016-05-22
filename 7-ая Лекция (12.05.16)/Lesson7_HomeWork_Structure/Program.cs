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
            object f1 = Fraction.ReturnFraction(2, 3);
            object f2 = Fraction.ReturnFraction(1, 3);

            Fraction.PrintFraction(f1);
            Fraction.PrintFraction(f2);
        }
    }
}
