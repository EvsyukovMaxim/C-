using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lesson7_HomeWork_Structure;

namespace Tests_Fraction
{
    [TestClass]
    public class CompFrac
    {
        [TestMethod]
        public void CompareFraction()
        {
            //Arrange
            Fraction f1 = new Fraction(2, 1);
            Fraction f2 = new Fraction(2, 1);
            Fraction f3 = new Fraction(3, 1);

            //Act
            ((Fraction)f1).CompareTo((Fraction)f2);

            //Assert
            Assert.AreEqual(0, ((Fraction)f1).CompareTo((Fraction)f2));
            Assert.AreEqual(1, ((Fraction)f3).CompareTo((Fraction)f2));
            Assert.AreEqual(-1, ((Fraction)f2).CompareTo((Fraction)f3));
        }
    }
}
