using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_BankClient
{
    //Сберегательный счет
    class SavingAccount : BaseAccount
    {
        public SavingAccount (string accountNumber) : base (accountNumber)
        {
            _accountNumber = accountNumber;
        }
    }

}
