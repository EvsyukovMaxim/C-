using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankChet_HomeWork
{
    //Рассчетный счет
    class CheckingAccount : SberAccount
    {
        public double Fee(double FeeValue)
        {
            if (_isActive == true)
            {
                if (firstDepositDate == DateTime.Now.Month)
                {
                    return _currentSum;
                }
                else if (firstDepositDate == firstDepositDate++)
                {
                    firstDepositDate = firstDepositDate++;
                    _currentSum = _currentSum - (_currentSum * FeeValue);
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
