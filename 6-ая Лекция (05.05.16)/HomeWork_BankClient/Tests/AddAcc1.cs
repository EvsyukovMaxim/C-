using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomeWork_BankClient;

namespace Tests
{
    [TestClass]
    public class AddAcc1
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void AddAccount1()
        {
            //Arange
            BaseAccount example1 = new BaseAccount("1111 2222 3333 4444");
            BaseAccount example2 = new BaseAccount("2222 2222 3333 4444");
            BaseAccount example3 = new BaseAccount("3333 2222 3333 4444");
            BaseAccount example4 = new BaseAccount("4444 2222 3333 4444");
            StandardClient standartExample = new StandardClient();

            //Act
            standartExample.AddAccount(example1);
            standartExample.AddAccount(example2);
            standartExample.AddAccount(example3);
            standartExample.AddAccount(example4);


            //Assert
            
        }
    }
}
