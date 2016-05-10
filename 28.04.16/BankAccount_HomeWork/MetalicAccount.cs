using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankChet_HomeWork
{
    //Обезличенный металлический счет
    class MetalicAccount : SberAccount
    {
        protected string _metalType;
        protected double _gramAmount;
        protected double _gramPrice;

        public MetalicAccount () : base ()
        {
            _metalType = "Gold";
            _gramPrice = 1246.53;
        }

        public double ReturnMetalValue() //Возвращает эквивалент в металле (переводит рубли в граммы)
        {
            if (_isActive == true)
            {
                _gramAmount = _currentSum / _gramPrice;
                return Math.Round(_gramAmount, 2);
            }
            else
            {
                return 0; //Это вместо эксепшна, условие для отказа от каких либо действий, в случае, если счет закрыт
            }
        }

        public double DepositMetalAccount(double plus)
        {
            if (_isActive == true)
            {
                _currentSum = _currentSum + plus;
                return ReturnMetalValue();
            }
            else
            {
                return 0; //Это вместо эксепшна, условие для отказа от каких либо действий, в случае, если счет закрыт
            }
        }

        public double WithdrawFromMetalAccount(double minus)
        {
            if (_isActive == true)
            {
                _currentSum = _currentSum - minus;
                return ReturnMetalValue();
            }
            else
            {
                return 0; //Это вместо эксепшна, условие для отказа от каких либо действий, в случае, если счет закрыт
            }
        }
    }
}
