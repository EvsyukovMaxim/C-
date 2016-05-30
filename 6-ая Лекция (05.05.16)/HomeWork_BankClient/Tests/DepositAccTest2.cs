using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomeWork_BankClient;

namespace Tests
{
    [TestClass]
    public class DepositAccTest2
    {
        [TestMethod]
        public void DepositAccountTest2()
        {
            //Arange
            BaseAccount example = new BaseAccount("");

            //Act
            example.DepositAccount(100);

            //Assert
            Assert.AreNotEqual(100000, example.ReturnCurrentSum);
        }
    }
}
