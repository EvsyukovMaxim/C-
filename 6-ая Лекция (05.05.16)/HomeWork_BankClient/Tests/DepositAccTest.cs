using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomeWork_BankClient;

namespace Tests
{
    [TestClass]
    public class DepositAccTest
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void DepositAccountTest()
        {
            //Arange
            MetallAccount exampleMet = new MetallAccount("");
            SavingAccount exampleSav = new SavingAccount("");

            //Act
            exampleMet.DepositAccount(100);
            exampleSav.DepositAccount(-1000);

            //Assert
            Assert.AreEqual(100100, exampleMet.ReturnCurrentSum);
            Assert.AreNotEqual(100000, exampleMet.ReturnCurrentSum);
            Assert.AreNotEqual(99000, exampleSav.ReturnCurrentSum);
        }
    }
}
