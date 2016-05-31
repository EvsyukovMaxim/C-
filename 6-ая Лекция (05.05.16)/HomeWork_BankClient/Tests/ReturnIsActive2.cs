using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomeWork_BankClient;

namespace Tests
{
    [TestClass]
    public class ReturnIsActive2
    {
        [TestMethod]
        public void ReturnActive2()
        {
            //Arange
            MetallAccount example = new MetallAccount("");

            //Act
            example.CloseAccount();

            //Assert
            Assert.AreNotEqual(true, example.PrintIsActive);
        }
    }
}
