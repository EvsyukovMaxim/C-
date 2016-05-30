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
            BaseAccount example = new BaseAccount("");

            //Act
            example.CloseAccount();

            //Assert
            Assert.AreNotEqual(true, example.PrintIsActive);
        }
    }
}
