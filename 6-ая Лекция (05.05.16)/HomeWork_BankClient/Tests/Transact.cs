using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomeWork_BankClient;

namespace Tests
{
    [TestClass]
    public class Transact
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Transaction()
        {
            //Arange
            AccumulativeAccount exampleAcum = new AccumulativeAccount("1111 2222 3333 4444");
            MetallAccount exampleMet = new MetallAccount("2222 2222 3333 4444");
            Bank myBank = new Bank();

            //Act
            myBank.Transaction(exampleAcum, exampleMet, 100000);
            //Assert
            Assert.AreEqual(0, exampleAcum.ReturnCurrentSum);
            Assert.AreEqual(200000, exampleMet.ReturnCurrentSum);

            //Act
            myBank.Transaction(exampleMet, exampleAcum, 100000);
            Assert.AreNotEqual(0, exampleAcum.ReturnCurrentSum);
            Assert.AreNotEqual(200000, exampleMet.ReturnCurrentSum);

            //Act
            myBank.Transaction(exampleAcum, exampleMet, -100000);
        }
    }
}
