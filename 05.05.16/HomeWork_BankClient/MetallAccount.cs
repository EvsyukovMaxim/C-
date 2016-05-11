using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_BankClient
{
    class MetallAccount : BaseAccount
    {
        public MetallAccount(string accountNumber) : base (accountNumber)
        {
            _accountNumber = accountNumber;
        }
    }
}
