using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankChet_HomeWork
{
    class GeneralAccount
    {
        internal long _accountNumber;
        internal string _ownerName;
        internal uint _currentSum;
        internal bool _isActive;

        public GeneralAccount ()
        {
            _accountNumber = 1234567890123456;
            _ownerName = "Евсюков М.В.";
            _currentSum = 100000;
            _isActive = true;
        }

        public bool CloseAccount()
        {
            if (_currentSum == 0)
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
