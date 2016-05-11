using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_BankClient
{
    class StandartClient
    {
        public void addAccount (BaseAccount account)
        {
            List<BaseAccount> accountsList = new List<BaseAccount>();
            if (account < 4)
            {
                accountsList.Add(account);
            }
        }
    }
}
