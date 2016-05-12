using ClassWork_ClassClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_ClassClient
{
    class Client : IComparable
    { 
        SberAccount mySberAccount = new SberAccount(50000);
        AccumulativeAccount myAccumulativeAccount = new AccumulativeAccount(100000);
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

        public int CompareTo(object obj)
        {
            Client client =(Client)obj;
            if (GetSum > client.GetSum)
                return 1;
            if (GetSum < client.GetSum)
                return -1;

            return 0;
        }
    }
}
