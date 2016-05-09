using BankChet_HomeWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankChet_HomeWork
{
    class Client
    { 
        SberAccount mySberAccount = new SberAccount();
        AccumulativeAccount myAccumulativeAccount = new AccumulativeAccount();
        public int GetSum
        {
            get
            {
                int Sum = 0;
                List<GeneralAccount> accounts = new List<GeneralAccount>();
                accounts.Add(mySberAccount);
                accounts.Add(myAccumulativeAccount);
                for (int i = 0; i < accounts.Count; i++)
                {
                    Sum = Sum + accounts[i].ReturnCurrentSum();
                }
                return Sum;
            }
        }

    }
}
