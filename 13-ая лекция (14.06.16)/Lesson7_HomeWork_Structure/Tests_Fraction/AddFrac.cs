﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lesson7_HomeWork_Structure;

namespace Tests_Fraction
{
    [TestClass]
    public class AddFrac
    {
        [TestMethod]
        public void AdditionFraction1()
        {
            //Arrange
            Fraction f1 = new Fraction(1, 2);
            Fraction f2 = new Fraction(1, 2);
            
            //Act
            Fraction fn1 = f1.Addition(f2);

            //Assert
            Assert.AreEqual("2/2", fn1.ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void AdditionFraction2()
        {
            //Arrange
            Fraction f1 = new Fraction(1, 2);
            Fraction f3 = new Fraction(1, 0);

            //Act
            Fraction fn2 = f1.Addition(f3);

            //Assert
            Assert.AreEqual("0/0", fn2.ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void AdditionFraction3()
        {
            //Arrange
            Fraction f3 = new Fraction(1, 2);
            Fraction f4 = new Fraction(0, -1);
            //Act
            Fraction fn3 = f3.Addition(f4);

            //Assert
            //Ждем эксепшн на отрицательный знаменатель
        }
    }
}
