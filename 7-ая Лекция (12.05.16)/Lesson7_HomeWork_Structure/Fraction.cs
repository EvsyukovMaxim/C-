using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_HomeWork_Structure
{
    public struct Fraction : IComparable
    {
        private int _numerator;
        private int _denominator;
        public Fraction(int numerator, int denominator)
        {
            _numerator = numerator;
            _denominator = denominator;
            if (denominator > 0)
            {
                _denominator = denominator;
            }
            else
            {
                Console.WriteLine("Нельзя делить на ноль");
            }
        }
        public static Fraction ReturnFraction(int numerator, int denominator)
        {
            Fraction example = new Fraction(numerator, denominator);
            if (denominator > 0)
            {
                return example;
            }
            else if (denominator == 0)
            {
                Console.WriteLine("Нельзя делить на ноль");
                return new Fraction(0,0);
            }
            else
            {
                Console.WriteLine("Знаменатель должен быть положительным ");
                return new Fraction(0, 0);
            }
        }

        public override string ToString()
        {
            return $"{_numerator}/{_denominator}";
        }
        public static void PrintFraction(object example)
        {
            Console.WriteLine(example.ToString());
        }

        public Fraction Addition(Fraction f2)
        {
            Fraction f1 = new Fraction(_numerator, _denominator);
            if (f1._denominator != f2._denominator)
            {
                f1._numerator = f1._numerator * f2._denominator + f2._numerator * f2._denominator;
                f1._denominator = f1._denominator * f2._denominator;
                return f1;
            }
            else
            {
                f1._numerator = f1._numerator + f2._numerator;
                f1._denominator = f2._denominator;
                return f1;
            }
        }

        public Fraction Subtraction(Fraction f2)
        {
            Fraction f1 = new Fraction(_numerator, _denominator);
            if (f1._denominator != f2._denominator)
            {
                f1._numerator = f1._numerator * f2._denominator - f2._numerator * f2._denominator;
                f1._denominator = f1._denominator * f2._denominator;
                return f1;
            }
            else
            {
                f1._numerator = f1._numerator - f2._numerator;
                f1._denominator = f2._denominator;
                return f1;
            }
        }

        public Fraction Multiplication(Fraction f2)
        {
            Fraction f1 = new Fraction(_numerator, _denominator);
            f1._numerator = f1._numerator * f2._numerator;
            f1._denominator = f1._denominator * f2._denominator;
            return f1;
        }

        public Fraction Division(Fraction f2)
        {
            Fraction f1 = new Fraction(_numerator, _denominator);
            if (f2._numerator != 0)
            {
                f1._numerator = f1._numerator * f2._denominator;
                f1._denominator = f1._denominator * f2._numerator;
                return f1;
            }
            else
            {
                Console.WriteLine("Знаменатель не может быть равен нулю после деления");
                return f1;
            }
        }

        public int CompareTo(object f2)
        {
            Fraction f1 = (Fraction)f2;
            if (_numerator * f1._denominator > _denominator * f1._numerator)
            {
                return 1;
            }
            if (_numerator * f1._denominator < _denominator * f1._numerator)
            {
                return -1;
            }
            return 0;
        }
    }
}