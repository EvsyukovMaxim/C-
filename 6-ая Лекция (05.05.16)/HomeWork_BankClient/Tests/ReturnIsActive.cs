using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomeWork_BankClient;

namespace Tests
{
    [TestClass]
    public class ReturnIsActive
    {
        [TestMethod]
        public void ReturnActive1()
        {
            //Arange
            SavingAccount example1 = new SavingAccount("");

            //Act
            example1.CloseAccount();

            //Assert
            Assert.AreEqual(false, example1.PrintIsActive);
        }

        public void ReturnActive2()
        {
            //Arange
            MetallAccount example2 = new MetallAccount("");

            //Act
            example2.CloseAccount();

            //Assert
            Assert.AreNotEqual(true, example2.PrintIsActive);
        }
    }
}
