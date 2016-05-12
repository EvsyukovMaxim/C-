using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankChet_HomeWork
{
    //Накопительный счет
    class AccumulativeAccount : SberAccount
    {
        protected uint _firstDeposit; //Первоначальный взнос для Накопительного счета
        public AccumulativeAccount (double currentSum, string ownerName, uint firstDeposit) : base(currentSum, ownerName)
        {
            _firstDeposit = firstDeposit;
        }
        public override void WithdrawMoneyFromAccount(double minus)
        {
            double a = 0;
            a = _currentSum - minus;
            if (a >= _firstDeposit)
            {
                base.WithdrawMoneyFromAccount(minus);
            }
            else
            {
                Console.WriteLine("Ошибка!!! Остаток на счете должен быть не меньше первоначального взноса");
            }
            
        }

        public void Capitalization(double capitalizationPercent)
        {
            double a = ((_currentSum * (capitalizationPercent / 100)) / 12);
            Console.WriteLine("Сумма капитализации Накопительного счета: " + Math.Round(a,2));
            Console.Write("Общий остаток Накопительного счета после капитализации: "); DepositAccount(Math.Round(a,2));
        }
    }
}
