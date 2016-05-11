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
            VipClient myVipClient = new VipClient();

            BaseAccount myBaseAccount1 = new BaseAccount();
            SavingAccount mySavingAccount2 = new SavingAccount();
            AccumulativeAccount myAccumulativeAccount3 = new AccumulativeAccount();
            MetallAccount myMetallAccount4 = new MetallAccount(); //4-ый экземпляр дял проверки ограничения списка Standard
            BaseAccount myBaseAccount5 = new BaseAccount();
            SavingAccount mySavingAccount6 = new SavingAccount();
            AccumulativeAccount myAccumulativeAccount7 = new AccumulativeAccount();
            MetallAccount myMetallAccount8 = new MetallAccount();
            BaseAccount myBaseAccount9 = new BaseAccount();
            SavingAccount mySavingAccount10 = new SavingAccount();
            AccumulativeAccount myAccumulativeAccount11 = new AccumulativeAccount(); //11-ый экземпляр дял проверки ограничения списка VIP

            myStandardClient.AddAccount(myBaseAccount1);
            myStandardClient.AddAccount(mySavingAccount2);
            myStandardClient.AddAccount(myAccumulativeAccount3);
            myStandardClient.AddAccount(myMetallAccount4);

            myStandardClient.PrintAccountNumber();

            myVipClient.AddAccount(myBaseAccount1);
            myVipClient.AddAccount(mySavingAccount2);
            myVipClient.AddAccount(myAccumulativeAccount3);
            myVipClient.AddAccount(myMetallAccount4);
            myVipClient.AddAccount(myBaseAccount5);
            myVipClient.AddAccount(mySavingAccount6);
            myVipClient.AddAccount(myAccumulativeAccount7);
            myVipClient.AddAccount(myMetallAccount8);
            myVipClient.AddAccount(myBaseAccount9);
            myVipClient.AddAccount(mySavingAccount10);
            myVipClient.AddAccount(myAccumulativeAccount11);

            myVipClient.PrintAccountNumber();
        }
    }
}
