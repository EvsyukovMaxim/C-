using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_BankClient
{
    public class BaseAccount
    {
        //protected string _accountNumber;
        readonly string _ownerName;
        protected int _currentSum;
        protected bool _isActive;

        public BaseAccount(string accountNumber)
        {
            AccountNumber = accountNumber;
            _ownerName = "Евсюков М.В.";
            _currentSum = 100000;
            _isActive = true;
        }

        public bool CloseAccount()
        {
                _isActive = false;
                return _isActive;
        }

        public bool PrintIsActive { get { return _isActive; } }
        public int ReturnCurrentSum { get { return _currentSum; } }

        public string AccountNumber { get; protected set; }
        public string ReturnFIO { get { return _ownerName; } }

        public int DepositAccount(int plus)
        {
            _currentSum = _currentSum + plus;
            return _currentSum;
        }

        public int WithdrawMoneyFromAccount(int minus)
        {
            _currentSum = _currentSum - minus;
            return _currentSum;
        }
    }
}