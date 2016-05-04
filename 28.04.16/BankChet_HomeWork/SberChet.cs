using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankChet_HomeWork
{
    class SberChet : GeneralAccount
    {
        public bool CloseSberChet()
        {
            if (_currentSum < 0)
            {
                CloseChet();
                return _isActive;
            }
            else
            {
                return _isActive;
            }
        }

        public int FillChet(int plus)
        {
            return _currentSum + plus;
        }

        public int TakeMoneyFromChet (int minus)
        {
            return _currentSum - minus;
        }
    }

}
