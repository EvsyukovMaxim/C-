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
            _denominator = denominator;
            if (denominator != 0)
            {
                _denominator = denominator;
            }
        }
        public static object ReturnFraction(int numerator, int denominator)
        {
            Fraction example = new Fraction(numerator,denominator);
            if (denominator > 0)
            {
                return example;
            }
            else if (denominator == 0)
            {
                Console.WriteLine("Нельзя делить на ноль");
                return 0;
            }
            else
            {
                Console.WriteLine("Знаменатель должен быть положительным");
                return 0;
            }
        }

        public override string ToString()
        {
            return $"{_numerator}/{_denominator}";
        }
        public static void PrintFraction (object example)
        {
            Console.WriteLine(example.ToString());
        }

        public object Addition (Fraction f2)
        {
            Fraction newFraction = new Fraction(_numerator + f2._numerator,_denominator + f2._denominator);
            return newFraction;
        }
    }
}
