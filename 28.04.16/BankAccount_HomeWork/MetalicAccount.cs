using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankChet_HomeWork
{
    //Обезличенный металлический счет
    class MetalicAccount : GeneralAccount
    {
        protected string _metalType;
        protected double _gramAmount;
        protected double _gramPrice;

        public MetalicAccount (string metalType, double gramAmount, double gramPrice, string ownerName) : base(0, ownerName)
        {
            _metalType = metalType;
            _gramPrice = gramPrice;
            _gramAmount = gramAmount;
        }

        public double ReturnMetallValue { get { return Math.Round( _gramAmount,2); } }

        public double ReturnMetallCurrentSum() //Возвращает сумму на Металлическом счету
        {
            _currentSum = _gramAmount * _gramPrice;
            return Math.Round(_currentSum, 2);
        }

        public double DepositMetalAccount(double plus)
        {
            if (_isActive == true)
            {
                _gramAmount = _gramAmount + (plus / _gramPrice);
                return ReturnMetallValue;
            }
            else
            {
                Console.WriteLine("Счет закрыт, вносить деньги нельзя");
                return 0;
            }
        }

        public double WithdrawFromMetalAccount(double minus)
        {
            if (_isActive == true)
            {
                _gramAmount = _gramAmount - (minus / _gramPrice);
                return ReturnMetallValue;
            }
            else
            {
                Console.WriteLine("Счет закрыт, снимать деньги нельзя");
                return 0;
            }
        }
    }
}
