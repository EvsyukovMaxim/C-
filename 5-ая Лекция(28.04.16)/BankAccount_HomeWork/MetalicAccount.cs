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

        public override double ReturnCurrentSum  //Возвращает сумму на Металлическом счету
        { get
            {
                _currentSum = _gramAmount * _gramPrice;
                return Math.Round(_currentSum, 2);
            }
        }

        public override void DepositAccount(double plus)
        {
            if (_isActive == true)
            {
                _gramAmount = _gramAmount + (plus / _gramPrice);
                Console.WriteLine(ReturnMetallValue + " гр.");
            }
            else
            {
                Console.WriteLine("Счет закрыт, вносить деньги нельзя");
            }
        }

        public override void WithdrawMoneyFromAccount(double minus)
        {
            if (_isActive == true)
            {
                if (minus <= ReturnCurrentSum)
                {
                    _gramAmount = _gramAmount - (minus / _gramPrice);
                    Console.WriteLine(ReturnMetallValue + " гр.");
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
    }
}
