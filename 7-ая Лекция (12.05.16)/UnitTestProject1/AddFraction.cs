using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lesson7_HomeWork_Structure;

namespace UnitTestProject1
{
    [TestClass]
    public class AddFraction
    {
        [TestMethod]
        public void AdditionFraction()
        {
            Fraction f1 = new Fraction(2,3);
            Fraction f2 = new Fraction(3,2);
            f1.Addition(f2);
        }
    }
}
