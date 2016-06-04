using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomeWork_BankClient;

namespace Tests
{
    [TestClass]
    public class ReturnIsActive
    {
        [TestMethod]
        public void ReturnActive()
        {
            //Arange
            SavingAccount example1 = new SavingAccount("");
            MetallAccount example2 = new MetallAccount("");

            //Act
            example1.CloseAccount();
            example2.CloseAccount();

            //Assert
            Assert.AreEqual(false, example1.PrintIsActive);
            Assert.AreNotEqual(true, example2.PrintIsActive);
        }
    }
}
