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
            MetallAccount example1 = new MetallAccount("1111 2222 3333 4444");
            SavingAccount example2 = new SavingAccount("2222 2222 3333 4444");
            AccumulativeAccount example3 = new AccumulativeAccount("3333 2222 3333 4444");
            MetallAccount example4 = new MetallAccount("4444 2222 3333 4444");
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
