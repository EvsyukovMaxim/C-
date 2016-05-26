using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomeWork_BankClient;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DepositAccountTest()
        {
            //Arange
            BaseAccount example = new BaseAccount("");

            //Act
            example.DepositAccount(100);

            //Assert
            Assert.AreEqual(100180, example.ReturnCurrentSum);
        }
    }
}
