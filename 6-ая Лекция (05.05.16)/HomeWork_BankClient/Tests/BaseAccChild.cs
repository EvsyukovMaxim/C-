using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomeWork_BankClient;

namespace Tests
{
    public class BaseAccChild : BaseAccount
    {
        public BaseAccChild(string accountNumber) : base(accountNumber)
        {
            AccountNumber = accountNumber;
        }
    }
}
