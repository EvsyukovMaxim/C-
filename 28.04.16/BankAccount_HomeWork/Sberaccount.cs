using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount_HomeWork
{
    class SberAccount : GeneralAccount
    {
        public double FillChet(double plus)
        {
            if (_isActive == true)
            {
                _currentSum = _currentSum + plus;
                return _currentSum;
            }
            else
            {
                return 0; //Это вместо эксепшна, условие для отказа от каких либо действий, в случае, если счет закрыт
            }
        }

        public double TakeMoneyFromChet (double minus)
        {
            if (_isActive == true)
            {
                _currentSum = _currentSum - minus;
                return _currentSum;
            }
            else
            {
                return 0; //Это вместо эксепшна, условие для отказа от каких либо действий, в случае, если счет закрыт
            }

        }
    }

}
