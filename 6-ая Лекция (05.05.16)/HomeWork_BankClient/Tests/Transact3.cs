using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomeWork_BankClient;

namespace Tests
{
    [TestClass]
    public class Transact3
    {
        [TestMethod]
        public void Transaction3()
        {
            //Arange
            BaseAccount example1 = new BaseAccount("1111 2222 3333 4444");
            BaseAccount example2 = new BaseAccount("2222 2222 3333 4444");
            Bank myBank = new Bank();

            //Act
            myBank.Transaction(example2,example1,-100000);


            //Assert
            Assert.AreEqual(0, example1.ReturnCurrentSum);
            Assert.AreEqual(200000, example2.ReturnCurrentSum);

        }
    }
}
