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

            BaseAccount myBaseAccount1 = new BaseAccount("1111 1111 1111 1111");
            SavingAccount mySavingAccount2 = new SavingAccount("2222 2222 2222 2222");
            AccumulativeAccount myAccumulativeAccount3 = new AccumulativeAccount("3333 3333 3333 3333");
            MetallAccount myMetallAccount4 = new MetallAccount("4444 4444 4444 4444"); //4-ый экземпляр дял проверки ограничения списка Standard
            BaseAccount myBaseAccount5 = new BaseAccount("5555 5555 5555 5555");
            SavingAccount mySavingAccount6 = new SavingAccount("6666 6666 6666 6666");
            AccumulativeAccount myAccumulativeAccount7 = new AccumulativeAccount("7777 7777 7777 7777");
            MetallAccount myMetallAccount8 = new MetallAccount("8888 8888 8888 8888");
            BaseAccount myBaseAccount9 = new BaseAccount("9999 9999 9999 9999");
            SavingAccount mySavingAccount10 = new SavingAccount("1010 1010 1010 1010");
            AccumulativeAccount myAccumulativeAccount11 = new AccumulativeAccount("0000 0000 0000 0000"); //11-ый экземпляр дял проверки ограничения списка VIP

            myStandardClient.AddAccount(myBaseAccount1);
            myStandardClient.AddAccount(mySavingAccount2);
            myStandardClient.AddAccount(myAccumulativeAccount3);
            //myStandardClient.AddAccount(myMetallAccount4);

            myStandardClient.PrintAccountNumber();

            myStandardClient.CloseClientAccount("2222 2222 2222 2222");



            myVipClient.AddAccountVIP(myBaseAccount1);
            myVipClient.AddAccountVIP(mySavingAccount2);
            myVipClient.AddAccountVIP(myAccumulativeAccount3);
            myVipClient.AddAccountVIP(myMetallAccount4);
            myVipClient.AddAccountVIP(myBaseAccount5);
            myVipClient.AddAccountVIP(mySavingAccount6);
            myVipClient.AddAccountVIP(myAccumulativeAccount7);
            myVipClient.AddAccountVIP(myMetallAccount8);
            myVipClient.AddAccountVIP(myBaseAccount9);
            myVipClient.AddAccountVIP(mySavingAccount10);
            //myVipClient.AddAccountVIP(myAccumulativeAccount11);

            myVipClient.PrintAccountNumber();
        }
    }
}
