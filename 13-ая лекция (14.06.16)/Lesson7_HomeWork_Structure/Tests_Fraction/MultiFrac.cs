﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lesson7_HomeWork_Structure;

namespace Tests_Fraction
{
    [TestClass]
    public class MultiFrac
    {
        [TestMethod]
        public void MultiplicationFraction1()
        {
            //Arrange
            Fraction f1 = new Fraction(1, 2);
            Fraction f2 = new Fraction(1, 2);

            //Act
            Fraction fn1 = f1.Multiplication(f2);

            //Assert
            Assert.AreEqual("1/4", fn1.ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void MultiplicationFraction2()
        {
            //Arrange
            Fraction f1 = new Fraction(1, 2);
            Fraction f3 = new Fraction(1, 0);

            //Act
            Fraction fn2 = f1.Multiplication(f3);

            //Assert
            //Ждем эксепшн
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void MultiplicationFraction3()
        {
            //Arrange
            Fraction f3 = new Fraction(1, 0);
            Fraction f4 = new Fraction(0, -1);

            //Act
            Fraction fn3 = f3.Multiplication(f4);

            //Assert
            //Ждем эксепшн
        }
    }
}
