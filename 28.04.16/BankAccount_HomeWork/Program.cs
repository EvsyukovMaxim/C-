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
            AccumulativeAccount myAccumulativeAccount = new AccumulativeAccount(100000, "Петров П.П.", 10000);
            CheckingAccount myCheckingAccount = new CheckingAccount(100000, "Сидоров С.С.");
            MetalicAccount myMetalicAccount = new MetalicAccount(100000, "Крузенштерн И.Ф.");

            //Вызовы
            Console.WriteLine("Сберегательный счет действителен: " + mySberAccount.CloseAccount());
            Console.Write("Остаток после внесения на Сберегательный счет: ");
            mySberAccount.DepositAccount(1000);
            Console.Write("Остаток после снятия со Сберегательного счета: ");
            mySberAccount.WithdrawMoneyFromAccount(101000);
            mySberAccount.CloseAccount();
            mySberAccount.DepositAccount(100.10); //Возвращаем "ошибку"
            mySberAccount.WithdrawMoneyFromAccount(100100); //Возвращаем "ошибку"


            Console.Write("Остаток после внесения на Накопительный счет: ");
            myAccumulativeAccount.DepositAccount(1000);
            Console.Write("Остаток после снятия с Накопительного счета: ");
            myAccumulativeAccount.WithdrawMoneyFromAccount(91000);
            myAccumulativeAccount.WithdrawMoneyFromAccount(1);
            //Console.WriteLine("Внесение на Накопительный счет: " + myAccumulativeAccount.DepositAccount(100));
            //Console.WriteLine("Остаток Накопительного счета после капитализации: " + myAccumulativeAccount.Capitalization(0.01));


            //Console.WriteLine("Внесение на Расчетный счет: " + myCheckingAccount.DepositAccount(1000));
            //Console.WriteLine("Снятие с Расчетного счета: " + myCheckingAccount.WithdrawMoneyFromAccount(100));
            //Console.WriteLine("Заряжаем процент за обслуживание и тогда остаток на Расчетном счете: " + myCheckingAccount.Fee(0.01));


            //Console.WriteLine("Количество метала на Металлическом счету: " + myMetalicAccount.ReturnGramAmount() + " грамм");
            //Console.WriteLine("После внесения 1000 рублей, Мтеллический счет составляет: " + myMetalicAccount.DepositMetalAccount(1000) + "грамм");
            //Console.WriteLine("После изъятия 1000 рублей, Мтеллический счет составляет: " + myMetalicAccount.WithdrawFromMetalAccount(1000) + "грамм");
        }

    }
}
