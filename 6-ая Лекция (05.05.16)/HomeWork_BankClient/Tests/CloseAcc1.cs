using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomeWork_BankClient;

namespace Tests
{
    [TestClass]
    public class CloseAcc1
    {
        [TestMethod]
        public void CloseAccount1()
        {
            //Arange
            AccumulativeAccount example = new AccumulativeAccount("1111 2222 3333 4444");
            StandardClient standartExample = new StandardClient();

            //Act
            standartExample.AddAccount(example);
            standartExample.CloseClientAccount("1111 2222 3333 4444");

            //Assert
            Assert.AreEqual(false, example.PrintIsActive);
        }
    }
}
