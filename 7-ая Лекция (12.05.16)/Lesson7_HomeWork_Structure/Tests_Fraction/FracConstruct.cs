using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lesson7_HomeWork_Structure;

namespace Tests_Fraction
{
    [TestClass]
    public class FracConstruct
    {
        [TestMethod]
        public void FractionConstructor1()
        {
            //Arrange
            Fraction f1 = new Fraction(1, 2);

            //Act

            //Assert
            Assert.AreEqual("1/2", f1.ToString());
        }

        [TestMethod]
        public void FractionConstructor2()
        {
            //Arrange
            Fraction f2 = new Fraction(3, 5);

            //Act

            //Assert
            Assert.AreEqual("3/5", f2.ToString());
        }

        [TestMethod]
        public void FractionConstructor3()
        {
            //Arrange
            Fraction f1 = new Fraction(1, 2);

            //Act

            //Assert
            Assert.AreEqual(f1, Fraction.ReturnFraction(1, 2));
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void FractionConstructor4()
        {
            //Arrange
            Fraction f1 = new Fraction(1, 0);

            //Act

            //Assert

            // Ждем эксепшн
        }
    }
}
