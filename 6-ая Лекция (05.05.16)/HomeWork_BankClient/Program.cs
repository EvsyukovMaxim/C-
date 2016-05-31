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
            Bank myBank = new Bank();

            AccumulativeAccount myAccumulativeAccount1 = new AccumulativeAccount("1111 1111 1111 1111");
            SavingAccount mySavingAccount2 = new SavingAccount("2222 2222 2222 2222");
            AccumulativeAccount myAccumulativeAccount3 = new AccumulativeAccount("3333 3333 3333 3333");
            SavingAccount mySavingAccount4 = new SavingAccount("4444 4444 4444 4444");
            MetallAccount myMetallAccount5 = new MetallAccount("5555 5555 5555 5555");
            SavingAccount mySavingAccount6 = new SavingAccount("6666 6666 6666 6666");
            AccumulativeAccount myAccumulativeAccount7 = new AccumulativeAccount("7777 7777 7777 7777");
            MetallAccount myMetallAccount8 = new MetallAccount("8888 8888 8888 8888");
            AccumulativeAccount myAccumulativeAccount9 = new AccumulativeAccount("9999 9999 9999 9999");
            SavingAccount mySavingAccount10 = new SavingAccount("1010 1010 1010 1010");
            AccumulativeAccount myAccumulativeAccount11 = new AccumulativeAccount("0000 0000 0000 0000");

            myStandardClient.AddAccount(myAccumulativeAccount1);
            myStandardClient.AddAccount(mySavingAccount2);
            myStandardClient.AddAccount(myAccumulativeAccount3);
            try
            {
                myStandardClient.AddAccount(mySavingAccount4); //4-ый экземпляр для проверки ограничения списка Standard
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }

            myStandardClient.PrintAccountData();

            myStandardClient.CloseClientAccount("1111 1111 1111 1111");

            myStandardClient.PrintAccountData();


            myVipClient.AddAccount(myAccumulativeAccount1);
            myVipClient.AddAccount(mySavingAccount2);
            myVipClient.AddAccount(myAccumulativeAccount3);
            myVipClient.AddAccount(mySavingAccount4);
            myVipClient.AddAccount(myMetallAccount5);
            myVipClient.AddAccount(mySavingAccount6);
            myVipClient.AddAccount(myAccumulativeAccount7);
            myVipClient.AddAccount(myMetallAccount8);
            myVipClient.AddAccount(myAccumulativeAccount9);
            myVipClient.AddAccount(mySavingAccount10);
            try
            {
                myVipClient.AddAccount(myAccumulativeAccount11); //11-ый экземпляр для проверки ограничения списка VIP
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }

            myVipClient.PrintAccountData();

            myVipClient.CloseClientAccount("5555 5555 5555 5555");

            myVipClient.PrintAccountData();

            myBank.Transaction(mySavingAccount2, myAccumulativeAccount3, 10000);
            myStandardClient.PrintAccountData();
            myVipClient.PrintAccountData();
        }
    }
}
