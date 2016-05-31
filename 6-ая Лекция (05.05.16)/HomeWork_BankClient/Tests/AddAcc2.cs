using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomeWork_BankClient;

namespace Tests
{
    [TestClass]
    public class AddAcc2
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void AddAccount2()
        {
            //Arange
            MetallAccount example1 = new MetallAccount("1111 2222 3333 4444");
            SavingAccount example2 = new SavingAccount("2222 2222 3333 4444");
            AccumulativeAccount example3 = new AccumulativeAccount("3333 2222 3333 4444");
            MetallAccount example4 = new MetallAccount("4444 2222 3333 4444");
            SavingAccount example5 = new SavingAccount("5555 2222 3333 4444");
            AccumulativeAccount example6 = new AccumulativeAccount("6666 2222 3333 4444");
            MetallAccount example7 = new MetallAccount("7777 2222 3333 4444");
            SavingAccount example8 = new SavingAccount("8888 2222 3333 4444");
            AccumulativeAccount example9 = new AccumulativeAccount("9999 2222 3333 4444");
            MetallAccount example10 = new MetallAccount("0000 2222 3333 4444");
            SavingAccount example11 = new SavingAccount("1010 2222 3333 4444");
            VipClient vipExample = new VipClient();

            //Act
            vipExample.AddAccount(example1);
            vipExample.AddAccount(example2);
            vipExample.AddAccount(example3);
            vipExample.AddAccount(example4);
            vipExample.AddAccount(example5);
            vipExample.AddAccount(example6);
            vipExample.AddAccount(example7);
            vipExample.AddAccount(example8);
            vipExample.AddAccount(example9);
            vipExample.AddAccount(example10);
            vipExample.AddAccount(example11);


            //Assert

        }
    }
}
