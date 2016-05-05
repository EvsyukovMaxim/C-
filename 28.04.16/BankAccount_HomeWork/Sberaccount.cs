using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankChet_HomeWork
{
    class SberAccount : GeneralAccount
    {
        public uint FillChet(uint plus)
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

        public uint TakeMoneyFromChet (uint minus)
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
