using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomeWork_BankClient;

namespace Tests
{
    [TestClass]
    public class Transact3
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Transaction3()
        {
            //Arange
            SavingAccount example1 = new SavingAccount("1111 2222 3333 4444");
            MetallAccount example2 = new MetallAccount("2222 2222 3333 4444");
            Bank myBank = new Bank();

            //Act
            myBank.Transaction(example2,example1,-100000);


            //Assert
            Assert.AreEqual(0, example1.ReturnCurrentSum);
            Assert.AreEqual(200000, example2.ReturnCurrentSum);

        }
    }
}
