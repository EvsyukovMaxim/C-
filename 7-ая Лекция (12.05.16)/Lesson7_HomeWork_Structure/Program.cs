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
            Fraction fraction1 = new Fraction(1,2);
            Fraction fraction2 = new Fraction(2,1);
            fraction1.PrintSum();
            fraction2.PrintSum();
        }
    }
}
