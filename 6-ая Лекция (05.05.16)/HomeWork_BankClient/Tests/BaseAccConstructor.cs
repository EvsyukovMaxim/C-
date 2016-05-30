using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomeWork_BankClient;

namespace Tests
{
    [TestClass]
    public class BaseAccConstructor
    {
        [TestMethod]
        public void BaseAccountConstructor()
        {
            //Arange
            BaseAccount example = new BaseAccount("123456789");

            //Act
            

            //Assert
            Assert.AreEqual("123456789", example.AccountNumber);
            Assert.AreEqual("Евсюков М.В.", example.ReturnFIO);
            Assert.AreEqual(100000, example.ReturnCurrentSum);
            Assert.AreEqual(true, example.PrintIsActive);
        }
    }
}
