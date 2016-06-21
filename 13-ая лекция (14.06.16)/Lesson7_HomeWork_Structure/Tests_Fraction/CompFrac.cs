using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lesson7_HomeWork_Structure;

namespace Tests_Fraction
{
    [TestClass]
    public class CompFrac
    {
        [TestMethod]
        public void CompareFraction1()
        {
            //Arrange
            Fraction f1 = new Fraction(2, 1);
            Fraction f2 = new Fraction(2, 1);

            //Act
            ((Fraction)f1).CompareTo((Fraction)f2);

            //Assert
            Assert.AreEqual(0, ((Fraction)f1).CompareTo((Fraction)f2));

        }

        [TestMethod]
        public void CompareFraction2()
        {
            //Arrange
            Fraction f2 = new Fraction(2, 1);
            Fraction f3 = new Fraction(3, 1);

            //Act

            //Assert
            Assert.AreEqual(1, ((Fraction)f3).CompareTo((Fraction)f2));
        }

        [TestMethod]
        public void CompareFraction3()
        {
            //Arrange
            Fraction f2 = new Fraction(2, 1);
            Fraction f3 = new Fraction(3, 1);

            //Assert
            Assert.AreEqual(-1, ((Fraction)f2).CompareTo((Fraction)f3));
        }
    }
}
