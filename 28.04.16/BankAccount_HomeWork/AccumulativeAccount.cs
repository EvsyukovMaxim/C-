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
        public override double WithdrawMoneyFromAccount(double minus)
        {
            if (minus >= firstDeposit)
            {
                return base.WithdrawMoneyFromAccount(minus);
            }
            return 0;//Это вместо эксепшна, условие для отказа от каких либо действий, в случае, если снимаешь денег больше, чем первоначальный взнос
        }

        public double Capitalization(double capitalizationPercent)
        {
            if (_isActive == true)
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
            else
            {
                return 0; //Это вместо эксепшна, условие для отказа от каких либо действий, в случае, если счет закрыт
            }
        }
    }
}
