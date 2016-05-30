using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomeWork_BankClient;

namespace Tests
{
    [TestClass]
    public class DepositAccTest1
    {
        [TestMethod]
        public void DepositAccountTest1()
        {
            //Arange
            BaseAccount example = new BaseAccount("");

            //Act
            example.DepositAccount(100);

            //Assert
            Assert.AreEqual(100100, example.ReturnCurrentSum);
        }
    }
}
