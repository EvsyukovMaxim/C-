using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_ClassClient
{
    //Родительский класс
    class GeneralAccount
    {
        readonly string _accountNumber;
        readonly string _ownerName;
        protected int _currentSum;
        protected bool _isActive;

        public GeneralAccount (int currentSum)
        {
            _accountNumber = "1234567890123456";
            _ownerName = "Евсюков М.В.";
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
        public int ReturnCurrentSum { get { return _currentSum; } }
    }
}
