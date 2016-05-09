using BankChet_HomeWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankChet_HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Экземпляры классов
            //GeneralAccount myGeneralAccount = new GeneralAccount();
            //SberAccount mySberAccount = new SberAccount();
            //AccumulativeAccount myAccumulativeAccount = new AccumulativeAccount();

            ////Вызовы
            //Console.WriteLine(myGeneralAccount.PrintNames()); //Печатаем некоторые поля родительского класса

            //Console.WriteLine("Сберегательный счет действителен: "+ mySberAccount.CloseAccount());
            //Console.WriteLine("Остаток после внесения на Сберегательный счет: " + mySberAccount.DepositAccount(-100));
            //Console.WriteLine("Остаток после снятия со Сберегательного счета: " + mySberAccount.WithdrawMoneyFromAccount(100100));
            //Console.WriteLine("Сберегательный счет действителен: " + mySberAccount.CloseAccount());

            //Console.WriteLine(mySberAccount.DepositAccount(100.10)); //Возвращаем "ошибку" - выводим "0"
            //Console.WriteLine(mySberAccount.WithdrawMoneyFromAccount(100100) + "\n"); //Возвращаем "ошибку" - выводим "0"


            //Console.WriteLine("Внесение на Накопительный счет: " + myAccumulativeAccount.DepositAccount(1000)); //Возвращаем "ошибку" - выводим "0"
            ////Console.WriteLine("Снятие со счета больше чем первоначальный взнос: " + myAccumulativeAccount.WithdrawMoneyFromAccount(100)); //Возвращаем "ошибку" - выводим "0"
            //Console.WriteLine("Снятие со счета больше чем первоначальный взнос: " + myAccumulativeAccount.WithdrawMoneyFromAccount(1001));
            Client myCient = new Client(); 
            Console.WriteLine(myCient.GetSum);

        }

    }
}
