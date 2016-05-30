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
            BaseAccount example = new BaseAccount("");

            //Act
            example.CloseAccount();

            //Assert
            Assert.AreEqual(false, example.PrintIsActive);
        }
    }
}
