using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomeWork_BankClient;

namespace Tests
{
    [TestClass]
    public class WithdrawMoneyFromAcc
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

        [TestMethod]
        public void WithdrawMoneyFromAccount2()
        {
            //Arange
            MetallAccount example = new MetallAccount("");

            //Act
            example.WithdrawMoneyFromAccount(1000);

            //Assert
            Assert.AreNotEqual(101000, example.ReturnCurrentSum);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void WithdrawMoneyFromAccount3()
        {
            //Arange
            MetallAccount example = new MetallAccount("");

            //Act
            example.WithdrawMoneyFromAccount(-1000);
        }
    }
}
