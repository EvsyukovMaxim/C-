using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomeWork_BankClient;

namespace Tests
{
    [TestClass]
    public class CloseAcc2
    {
        [TestMethod]
        public void CloseAccount2()
        {
            //Arange
            BaseAccount example = new BaseAccount("1111 2222 3333 4444");
            StandardClient standartExample = new StandardClient();

            //Act
            standartExample.AddAccount(example);
            standartExample.CloseClientAccount("1111 2222 3333 5555");

            //Assert
            Assert.AreNotEqual(false, example.PrintIsActive);
        }
    }
}
