using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_BankClient
{
    //Сберегательный счет
    public class SavingAccount : BaseAccount
    {
        public SavingAccount (string accountNumber) : base (accountNumber)
        {
            AccountNumber = accountNumber;
        }
    }

}
