using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomeWork_BankClient;

namespace Tests
{
    [TestClass]
    public class WithdrawMoneyFromAcc
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void WithdrawMoneyFromAccount()
        {
            //Arange
            MetallAccount example = new MetallAccount("");

            //Act
            example.WithdrawMoneyFromAccount(1000);

            //Assert
            Assert.AreEqual(99000, example.ReturnCurrentSum);


            //Act
            example.WithdrawMoneyFromAccount(1000);

            //Assert
            Assert.AreNotEqual(101000, example.ReturnCurrentSum);


            //Act
            example.WithdrawMoneyFromAccount(-1000);
        }
    }
}
