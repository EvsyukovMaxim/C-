using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lesson7_HomeWork_Structure;

namespace Tests_Fraction
{
    [TestClass]
    public class FracConstruct
    {
        [TestMethod]
        public void FractionConstructor()
        {
            //Arrange
            Fraction f1 = new Fraction(1, 2);
            Fraction f2 = new Fraction(3, 5);

            //Act

            //Assert
            Assert.AreEqual("1/2", f1.ToString());
            Assert.AreEqual("3/5", f2.ToString());
        }
    }
}
