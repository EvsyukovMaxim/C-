using System;

namespace BankChet_HomeWork
{
    //Сберегательный счет
    class SberAccount : GeneralAccount
    {
        protected double firstDeposit = double.NaN; //Первоначальный взнос для Накопительного счета
        protected double firstDepositDate = double.NaN;
        public virtual double DepositAccount(double plus)
        {
            if (_isActive == true)
            {
                if (double.IsNaN(firstDeposit))
                {
                    firstDeposit = plus;
                }
                if (double.IsNaN(firstDepositDate))
                {
                    firstDepositDate = DateTime.Now.Month;
                }
                _currentSum = _currentSum + plus;
                return _currentSum;
            }
            else
            {
                return 0; //Это вместо эксепшна, условие для отказа от каких либо действий, в случае, если счет закрыт
            }
        }

        public virtual double WithdrawMoneyFromAccount(double minus)
        {
            if (_isActive == true)
            {
                _currentSum = _currentSum - minus;
                return _currentSum;
            }
            else
            {
                return 0; //Это вместо эксепшна, условие для отказа от каких либо действий, в случае, если счет закрыт
            }

        }
    }

}
