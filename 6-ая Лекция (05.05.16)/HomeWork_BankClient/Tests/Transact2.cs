using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomeWork_BankClient;MetallAccount

namespace Tests
{
    [TestClass]
    public class Transact2
    {
        [TestMethod]
        public void Transaction2()
        {
            //Arange
            MetallAccount example1 = new MetallAccount("1111 2222 3333 4444");
            SavingAccount example2 = new SavingAccount("2222 2222 3333 4444");
            Bank myBank = new Bank();

            //Act
            myBank.Transaction(example2,example1,100000);


            //Assert
            Assert.AreNotEqual(0, example1.ReturnCurrentSum);
            Assert.AreNotEqual(200000, example2.ReturnCurrentSum);

        }
    }
}
