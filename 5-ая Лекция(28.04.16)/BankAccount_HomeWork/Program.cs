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
            try
            {
                mySberAccount.DepositAccount(100.10);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                mySberAccount.WithdrawMoneyFromAccount(100100);
            }
            catch (InvalidProgramException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Сработал исключепшн для Сбер счета");
            }
            Console.WriteLine("\n");


            //Накопительный счет
            Console.Write("Остаток после внесения на Накопительный счет: ");
            myAccumulativeAccount.DepositAccount(1000);
            myAccumulativeAccount.Capitalization(10);
            Console.Write("Остаток после снятия с Накопительного счета: ");
            myAccumulativeAccount.WithdrawMoneyFromAccount(1091.67);
            try
            {
                myAccumulativeAccount.WithdrawMoneyFromAccount(1);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Сработал исключепшн для Накопительного счета");
            }
            Console.WriteLine("\n");


            //Расчетный счет
            myCheckingAccount.WithdrawMoneyFromAccount(100000);
            myCheckingAccount.CloseAccount();
            Console.Write("Остаток после внесения на Расчетный счет: ");
            try
            {
                myCheckingAccount.DepositAccount(1000);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Сработал исключепшн для Расчетного счета");
            }
            Console.Write("Остаток после снятия с Расчетного счета: ");
            try
            {
                myCheckingAccount.WithdrawMoneyFromAccount(100);
            }
            catch (InvalidProgramException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Сработал исключепшн для Расчетного счета");
            }
            try
            {
                myCheckingAccount.Fee(10);
            }
            catch (InvalidProgramException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Сработал исключепшн для Расчетного счета");
            }
            Console.WriteLine("\n");


            //Металлический счет
            myMetalicAccount.CloseAccount();
            Console.WriteLine("Баланс в граммах на Металлическом счете: " + myMetalicAccount.ReturnMetallValue + " гр.");
            Console.WriteLine("Баланс в рублях на Металлическом счете: " + myMetalicAccount.ReturnCurrentSum + " руб.");
            Console.WriteLine("Внесено 1500 рублей, баланс в граммах на Металлическом счете: ");
            try
            {
                myMetalicAccount.DepositAccount(1500);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Сработал исключепшн для Металлического счета");
            }
            Console.WriteLine("Снято 2750 рублей, баланс в граммах на Металлическом счете: ");
            try
            {
                myMetalicAccount.WithdrawMoneyFromAccount(2750);
            }
            catch (InvalidProgramException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Сработал исключепшн для Металлического счета");
            }
            try
            {
                myMetalicAccount.WithdrawMoneyFromAccount(216422.65);
            }
            catch (InvalidProgramException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Сработал исключепшн для Металлического счета");
            }
        }
    }
}
