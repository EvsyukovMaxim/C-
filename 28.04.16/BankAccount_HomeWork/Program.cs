using System;

namespace BankChet_HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //Экземпляры классов
            GeneralAccount myGeneralAccount = new GeneralAccount();
            SberAccount mySberAccount = new SberAccount();
            AccumulativeAccount myAccumulativeAccount = new AccumulativeAccount();

            //Вызовы
            Console.WriteLine(myGeneralAccount.PrintNames()); //Печатаем поля родительского класса

            Console.WriteLine("Сберегательный счет действителен: " + mySberAccount.CloseAccount());
            Console.WriteLine("Остаток после внесения на Сберегательный счет: " + mySberAccount.DepositAccount(-100));
            Console.WriteLine("Остаток после снятия со Сберегательного счета: " + mySberAccount.WithdrawMoneyFromAccount(100100));
            Console.WriteLine("Сберегательный счет действителен: " + mySberAccount.CloseAccount());
            Console.WriteLine(mySberAccount.DepositAccount(100.10)); //Возвращаем "ошибку" - выводим "0"
            Console.WriteLine(mySberAccount.WithdrawMoneyFromAccount(100100) + "\n"); //Возвращаем "ошибку" - выводим "0"


            Console.WriteLine("Внесение на Накопительный счет: " + myAccumulativeAccount.DepositAccount(1000));
            Console.WriteLine("Снятие со счета больше чем первоначальный взнос: " + myAccumulativeAccount.WithdrawMoneyFromAccount(1000));
            Console.WriteLine("Внесение на Накопительный счет: " + myAccumulativeAccount.DepositAccount(100));
            Console.WriteLine("Баланс Накопительного счета после капитализации: " + myAccumulativeAccount.Capitalization(0.01));
        }

    }
}
