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
            object f1 = Fraction.ReturnFraction(3, 1);
            object f2 = Fraction.ReturnFraction(1, 5);

            Fraction.PrintFraction(f1);
            Fraction.PrintFraction(f2);

            Console.WriteLine(((Fraction)f1).Addition((Fraction)f2));
            Console.WriteLine(((Fraction)f1).Subtraction((Fraction)f2));
            Console.WriteLine(((Fraction)f1).Multiplication((Fraction)f2));
            Console.WriteLine(((Fraction)f1).Division((Fraction)f2));

            Console.WriteLine(((Fraction)f1).CompareTo((Fraction)f2));


            //Console.WriteLine("Необходимо ввести количество дробей, которые попадут в массив: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Fraction sum = new Fraction(0, 1);
            //Random rnd = new Random();
            //Fraction[] randomFractions = new Fraction[n];

            //for (int i = 0; i < n; i++)
            //{
            //    randomFractions[i] = new Fraction(rnd.Next(0, 10), rnd.Next(1, 10));
            //}

            //Array.Sort(randomFractions);

            //for (int i = 0; i < randomFractions.Length; i++)
            //{
            //    Console.WriteLine("Отсортированный массив случайных дробей: " + randomFractions[i]);
            //}

            //for (int i = 0; i < randomFractions.Length; i++)
            //{
            //    sum = (Fraction)sum.Addition(randomFractions[i]);
            //}

            //Console.WriteLine("Сумма всех дробей равна: " + sum);
        }
    }
}