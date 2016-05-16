using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_BankClient
{
    class StandardClient : BankClient
    {
        public override void AddAccount(BaseAccount account)
        {
            N = 3;
            base.AddAccount(account);
        }
    }
}
