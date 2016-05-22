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
        AccumulativeAccount myAccumulativeAccount = new AccumulativeAccount(50000);
        SberAccount mySberAccount = new SberAccount(100000);
        public int GetSumSber { get { return mySberAccount.ReturnCurrentSum; } }
        public int GetSumAccum { get { return myAccumulativeAccount.ReturnCurrentSum; } }
        public int CompareTo(object obj)
        {
            Client client = (Client)obj;
            if (client.GetSumAccum > client.GetSumSber)
                return 1;
            if (client.GetSumAccum < client.GetSumSber)
                return -1;

            return 0;
        }
    }
}
