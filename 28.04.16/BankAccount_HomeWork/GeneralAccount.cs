using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankChet_HomeWork
{
    //Родительский класс
    class GeneralAccount
    {
        readonly string _accountNumber;
        readonly string _ownerName;
        protected double _currentSum;
        protected bool _isActive;

        public GeneralAccount (double currentSum, string ownerName)
        {
            _accountNumber = "1234567890123456";
            _ownerName = ownerName;
            _currentSum = currentSum;
            _isActive = true;
        }

        public bool CloseAccount()
        {
            if (_currentSum <= 0)
            {
                _isActive = false;
                return _isActive;
            }
            else
            {
                return _isActive;
            }
        }
    }
}
