using System;

namespace BankChet_HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //Экземпляры классов
            GeneralAccount myGeneralAccount = new GeneralAccount(100000, "Евсюков М.В.");
            SberAccount mySberAccount = new SberAccount(100000, "Иванов И.И.");
            AccumulativeAccount myAccumulativeAccount = new AccumulativeAccount(10000, "Петров П.П.", 10000);
            CheckingAccount myCheckingAccount = new CheckingAccount(100000, "Сидоров С.С.");
            MetalicAccount myMetalicAccount = new MetalicAccount("Gold", 87.65, 2483.43, "Крузенштерн И.Ф.");

            //Вызовы

            //Сберегательный счет
            Console.WriteLine("Сберегательный счет действителен: " + mySberAccount.CloseAccount());
            Console.Write("Остаток после внесения на Сберегательный счет: ");
            mySberAccount.DepositAccount(1100);
            Console.Write("Остаток после внесения на Сберегательный счет: ");
            mySberAccount.DepositAccount(-100);
            Console.Write("Остаток после снятия со Сберегательного счета: ");
            mySberAccount.WithdrawMoneyFromAccount(101000);
            mySberAccount.CloseAccount();
            mySberAccount.DepositAccount(100.10); //Возвращаем "ошибку"
            mySberAccount.WithdrawMoneyFromAccount(100100); //Возвращаем "ошибку"
            Console.WriteLine("\n");


            //Накопительный счет
            Console.Write("Остаток после внесения на Накопительный счет: ");
            myAccumulativeAccount.DepositAccount(1000);
            myAccumulativeAccount.Capitalization(10);
            Console.Write("Остаток после снятия с Накопительного счета: ");
            myAccumulativeAccount.WithdrawMoneyFromAccount(1091.67);
            myAccumulativeAccount.WithdrawMoneyFromAccount(1);
            Console.WriteLine("\n");


            //Расчетный счет
            //myCheckingAccount.WithdrawMoneyFromAccount(100000);
            //myCheckingAccount.CloseAccount();
            Console.Write("Остаток после внесения на Расчетный счет: ");
            myCheckingAccount.DepositAccount(1000);
            Console.Write("Остаток после снятия с Расчетного счета: ");
            myCheckingAccount.WithdrawMoneyFromAccount(100);
            myCheckingAccount.Fee(10);
            Console.WriteLine("\n");


            //Металлический счет
            //myMetalicAccount.CloseAccount();
            Console.WriteLine("Баланс в граммах на Металлическом счете: " + myMetalicAccount.ReturnMetallValue + " гр.");
            Console.WriteLine("Баланс в рублях на Металлическом счете: " + myMetalicAccount.ReturnMetallCurrentSum() + " руб.");
            Console.WriteLine("Внесено 1500 рублей, баланс в граммах на Металлическом счете: ");
            myMetalicAccount.DepositAccount(1500);
            Console.WriteLine("Снято 2750 рублей, баланс в граммах на Металлическом счете: ");
            myMetalicAccount.WithdrawMoneyFromAccount(2750);
        }

    }
}
