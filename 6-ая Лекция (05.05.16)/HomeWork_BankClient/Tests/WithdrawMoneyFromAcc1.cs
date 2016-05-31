using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomeWork_BankClient;

namespace Tests
{
    [TestClass]
    public class WithdrawMoneyFromAcc1
    {
        [TestMethod]
        public void WithdrawMoneyFromAccount1()
        {
            //Arange
            MetallAccount example = new MetallAccount("");

            //Act
            example.WithdrawMoneyFromAccount(1000);

            //Assert
            Assert.AreEqual(99000, example.ReturnCurrentSum);
        }
    }
}
