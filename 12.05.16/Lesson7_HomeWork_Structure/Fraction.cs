using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_HomeWork_Structure
{
    public struct Fraction
    {
        public int X { get; set; }
        public uint Y { get; set; }
        public Fraction(int x, uint y)
        {
            X = x;
            Y = 1;
            if (y != 0)
            {
                Y = y;
            }
            else
            {
                Console.WriteLine("Нельзя делить на ноль");
            }
        }
        public void PrintSum ()
        {
            if (Y > 0)
            {
                Console.WriteLine(X / Y);
            }
            else
            {
                Console.WriteLine("Введены некорректные данные");
            }
        }

        //public List<Fraction> fractionsList;

        //fractionsList.Add(fraction1);
        //fractionsList.Add(fraction2);
        //    for (int i = 0; i<fractionsList.Count;)
        //    {

        //    }
    }
}
