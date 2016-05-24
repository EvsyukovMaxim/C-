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

        public virtual void DepositAccount(double plus)
        {
            if (_isActive == true)
            {
                _currentSum = _currentSum + plus;
                Console.WriteLine(_currentSum);
            }
            else
            {
                throw new InvalidOperationException ("Счет закрыт, вносить деньги нельзя");
            }
        }

        public virtual void WithdrawMoneyFromAccount(double minus)
        {
            if (_isActive == true)
            {
                if (minus <= _currentSum)
                {
                    _currentSum = _currentSum - minus;
                    Console.WriteLine(_currentSum);
                }
                else
                {
                    Console.WriteLine("Остаток на счете меньше снимаемой суммы");
                }

            }
            else
            {
                Console.WriteLine("Счет закрыт, снимать деньги нельзя");
            }
        }

        public virtual double ReturnCurrentSum { get { return _currentSum; } }
    }
}
