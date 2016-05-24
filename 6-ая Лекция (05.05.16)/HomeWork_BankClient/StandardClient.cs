using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_BankClient
{
    class StandardClient : BankClient
    {
        public StandardClient ()
        {
            _accountsQuantity = 3;
        }
        public override void AddAccount(BaseAccount account)
        {
            base.AddAccount(account);
        }
    }
}
