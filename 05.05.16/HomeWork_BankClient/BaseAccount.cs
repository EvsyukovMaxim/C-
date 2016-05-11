using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_BankClient
{
    public abstract class BaseAccount
    {
        protected int _currentSum;
        protected bool _isActive;

        public BaseAccount()
        {
            _currentSum = 100000;
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
        public int ReturnCurrentSum { get {return _currentSum; } }
    }
}