using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomeWork_BankClient;

namespace Tests
{
    [TestClass]
    public class WithdrawMoneyFromAcc2
    {
        [TestMethod]
        public void WithdrawMoneyFromAccount2()
        {
            //Arange
            BaseAccount example = new BaseAccount("");

            //Act
            example.WithdrawMoneyFromAccount(1000);

            //Assert
            Assert.AreNotEqual(101000, example.ReturnCurrentSum);
        }
    }
}
