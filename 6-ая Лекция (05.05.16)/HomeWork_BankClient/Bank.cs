using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_BankClient
{
    class Bank
    {
        public void Transaction (BaseAccount from, BaseAccount to, int sum)
        {
            from.WithdrawMoneyFromAccount(sum);
            to.DepositAccount(sum);
        }
    }
}
