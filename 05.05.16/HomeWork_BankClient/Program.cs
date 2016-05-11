using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_BankClient
{
    class Program
    {
        static void Main(string[] args)
        {
            StandardClient myStandardClient = new StandardClient();
            BaseAccount myBaseAccount1 = new BaseAccount();
            SavingAccount mySavingAccount2 = new SavingAccount();
            AccumulativeAccount myAccumulativeAccount3 = new AccumulativeAccount();
            AccumulativeAccount myAccumulativeAccount4 = new AccumulativeAccount();
            myStandardClient.AddAccount(myBaseAccount1);
            myStandardClient.AddAccount(mySavingAccount2);
            myStandardClient.AddAccount(myAccumulativeAccount3);
            myStandardClient.AddAccount(myAccumulativeAccount4);

            myStandardClient.PrintAccountNumber();
            myStandardClient.PrintAccountIndex();
        }
    }
}
