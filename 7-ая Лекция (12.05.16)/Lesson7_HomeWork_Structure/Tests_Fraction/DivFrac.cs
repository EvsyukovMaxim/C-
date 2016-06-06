using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lesson7_HomeWork_Structure;

namespace Tests_Fraction
{
    [TestClass]
    public class DivFrac
    {
        [TestMethod]
        public void DivisionFraction1()
        {
            //Arrange
            Fraction f1 = new Fraction(1, 2);
            Fraction f2 = new Fraction(1, 2);

            //Act
            Fraction fn1 = f1.Division(f2);

            //Assert
            Assert.AreEqual("2/2", fn1.ToString());
        }

        [ExpectedException(typeof(DivideByZeroException))]
        public void DivisionFraction2()
        {
            //Arrange
            Fraction f1 = new Fraction(1, 2);
            Fraction f3 = new Fraction(1, 0);

            //Act
            Fraction fn2 = f1.Division(f3);

            //Assert
            Assert.AreEqual("0/2", fn2.ToString());
        }

        public void DivisionFraction3()
        {
            //Arrange
            Fraction f3 = new Fraction(1, 0);
            Fraction f4 = new Fraction(0, -1);

            //Act
            Fraction fn3 = f3.Division(f4);

            // Не работает эксепшн на инициализацию дробей с нулевым знаменателем ((( не понимаю почему, хотя в Program.cs срабатывает
        }
    }
}
