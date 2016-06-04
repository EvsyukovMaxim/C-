using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomeWork_BankClient;

namespace Tests
{
    [TestClass]
    public class CloseAcc
    {
        [TestMethod]
        public void CloseAccount()
        {
            //Arange
            AccumulativeAccount example1 = new AccumulativeAccount("1111 2222 3333 4444");
            SavingAccount example2 = new SavingAccount("1111 2222 3333 5555");
            StandardClient standartExample = new StandardClient();

            //Act
            standartExample.AddAccount(example1);
            standartExample.CloseClientAccount("1111 2222 3333 4444");
            standartExample.AddAccount(example2);
            standartExample.CloseClientAccount("1111 2222 3333 6666");

            //Assert
            Assert.AreEqual(false, example1.PrintIsActive);
            Assert.AreNotEqual(false, example2.PrintIsActive);
        }
    }
}
