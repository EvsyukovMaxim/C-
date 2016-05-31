using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomeWork_BankClient;

namespace Tests
{
    [TestClass]
    public class DepositAccTest3
    {
        [TestMethod]
        public void DepositAccountTest3()
        {
            //Arange
            AccumulativeAccount example = new AccumulativeAccount("");

            //Act
            example.DepositAccount(-1000);

            //Assert
            Assert.AreEqual(99000, example.ReturnCurrentSum);
        }
    }
}