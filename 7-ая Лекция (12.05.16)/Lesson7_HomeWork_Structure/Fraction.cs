using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_HomeWork_Structure
{
    public struct Fraction
    {
        private int _numerator;
        private int _denominator;
        public Fraction(int numerator, int denominator)
        {
            _numerator = numerator;
            _denominator = 1;
            if (denominator != 0)
            {
                _denominator = denominator;
            }
            else
            {
                Console.WriteLine("Нельзя делить на ноль");
            }
        }
        public static object ReturnFraction(int numerator, int denominator)
        {
            Fraction example = new Fraction(numerator,denominator);
            Console.WriteLine($"{example._numerator}/{example._denominator}");
            return example;
        }

        //public List<Fraction> fractionsList;

        //fractionsList.Add(fraction1);
        //fractionsList.Add(fraction2);
        //    for (int i = 0; i<fractionsList.Count;)
        //    {

        //    }
    }
}
