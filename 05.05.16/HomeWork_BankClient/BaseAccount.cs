using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_BankClient
{
    public class BaseAccount
    {
        protected string _accountNumber;
        readonly string _ownerName;
        protected int _currentSum;
        protected bool _isActive;

        public BaseAccount(string accountNumber)
        {
            _accountNumber = accountNumber;
            _ownerName = "Евсюков М.В.";
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
        public string ReturnAccountNumber { get { return "Номер счета:" + _accountNumber; } }
        public string ReturnFIO { get { return "ФИО: " + _ownerName; } }
    }
}