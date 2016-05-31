using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomeWork_BankClient;

namespace Tests
{
    [TestClass]
    public class ReturnIsActive1
    {
        [TestMethod]
        public void ReturnActive1()
        {
            //Arange
            SavingAccount example = new SavingAccount("");

            //Act
            example.CloseAccount();

            //Assert
            Assert.AreEqual(false, example.PrintIsActive);
        }
    }
}
