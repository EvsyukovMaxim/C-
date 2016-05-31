using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_BankClient
{
    public class MetallAccount : BaseAccount
    {
        public MetallAccount(string accountNumber) : base (accountNumber)
        {
            AccountNumber = accountNumber;
        }
    }
}
