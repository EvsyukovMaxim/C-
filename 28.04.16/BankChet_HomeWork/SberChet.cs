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

        public int FillChet(int summa)
        {
            return _currentSum + summa;
        }

        public int TakeMoneyFromChet (int summa)
        {
            return _currentSum - summa;
        }
    }

}
