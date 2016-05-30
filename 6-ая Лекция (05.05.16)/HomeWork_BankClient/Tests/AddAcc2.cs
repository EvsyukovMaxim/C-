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
            BaseAccount example1 = new BaseAccount("1111 2222 3333 4444");
            BaseAccount example2 = new BaseAccount("2222 2222 3333 4444");
            BaseAccount example3 = new BaseAccount("3333 2222 3333 4444");
            BaseAccount example4 = new BaseAccount("4444 2222 3333 4444");
            BaseAccount example5 = new BaseAccount("5555 2222 3333 4444");
            BaseAccount example6 = new BaseAccount("6666 2222 3333 4444");
            BaseAccount example7 = new BaseAccount("7777 2222 3333 4444");
            BaseAccount example8 = new BaseAccount("8888 2222 3333 4444");
            BaseAccount example9 = new BaseAccount("9999 2222 3333 4444");
            BaseAccount example10 = new BaseAccount("0000 2222 3333 4444");
            BaseAccount example11 = new BaseAccount("1010 2222 3333 4444");
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
