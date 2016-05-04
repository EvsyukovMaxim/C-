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
        public int _currentSum;
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
            return _isActive = false;
        }
    }
}
