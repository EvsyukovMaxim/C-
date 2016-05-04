using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankChet_HomeWork
{
    class SberAccount : GeneralAccount
    {

        //public bool CloseSberAccount()
        //{
        //    if (_currentSum == 0)
        //    {
        //        CloseAccount();
        //        return _isActive;
        //    }
        //    else
        //    {
        //        return _isActive;
        //    }
        //}

        public uint FillChet(uint plus)
        {
            _currentSum = _currentSum + plus;
            return _currentSum;
        }

        public uint TakeMoneyFromChet (uint minus)
        {
            _currentSum = _currentSum - minus;
            return _currentSum;
        }
    }

}
