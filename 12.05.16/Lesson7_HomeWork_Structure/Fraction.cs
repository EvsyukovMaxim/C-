using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_HomeWork_Structure
{
    public struct Fraction
    {
        public double X { get; set; }
        public double Y { get; set; }
        //public double Z { get; set; }
        public Fraction(double x, double y)
        {
            X = x;
            Y = y;
        }
        public double PrintSum ()
        {
            return (X / Y);
        }
    }
}
