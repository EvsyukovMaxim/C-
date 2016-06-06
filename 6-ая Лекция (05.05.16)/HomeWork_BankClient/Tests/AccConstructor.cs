using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomeWork_BankClient;

namespace Tests
{
    [TestClass]
    public class AccConstructor
    {
        [TestMethod]
        public void AccountConstructor1()
        {
            //Arange
            MetallAccount example = new MetallAccount("123456789");

            //Act
            

            //Assert
            Assert.AreEqual("123456789", example.AccountNumber);
        }

        public void AccountConstructor2()
        {
            //Arange
            MetallAccount example = new MetallAccount("123456789");

            //Act


            //Assert
            Assert.AreEqual("Евсюков М.В.", example.ReturnFIO);
        }

        public void AccountConstructor3()
        {
            //Arange
            MetallAccount example = new MetallAccount("123456789");

            //Act


            //Assert
            Assert.AreEqual(100000, example.ReturnCurrentSum);
        }

        public void AccountConstructor4()
        {
            //Arange
            MetallAccount example = new MetallAccount("123456789");

            //Act


            //Assert
            Assert.AreEqual(true, example.PrintIsActive);
        }
    }
}
