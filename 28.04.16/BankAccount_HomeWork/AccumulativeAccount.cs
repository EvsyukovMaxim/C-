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

        public double Capitalization(double capitalizationPercent)
        {
            if (firstDepositDate == DateTime.Now.Month)
            {
                return _currentSum;
            }
            else if (firstDepositDate == firstDepositDate ++)
            {
                firstDepositDate = firstDepositDate ++;
                _currentSum = _currentSum * (capitalizationPercent + 1);
                return _currentSum;
            }
            else
            {
                return 0;
            }
        }
    }
}
