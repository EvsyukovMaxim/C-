using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomeWork_BankClient;

namespace Tests
{
    public class BankClientChild : BankClient
    {
        public BankClientChild()
        {
            _accountsQuantity = 1;
        }
    }
}
