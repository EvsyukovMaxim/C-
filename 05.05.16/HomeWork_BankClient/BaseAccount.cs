using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_BankClient
{
    public class BaseAccount
    {
        readonly string _accountNumber;
        readonly string _ownerName;
        protected int _currentSum;
        protected bool _isActive;

        public BaseAccount()
        {
            _accountNumber = "1324567891231597";
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
        public string ReturnAllDaInfO { get { return "Номер счета: " + _accountNumber + ", ФИО: " + _ownerName; } }
    }
}