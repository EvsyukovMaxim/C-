using System;

namespace BankChet_HomeWork
{
    //Сберегательный счет
    class SberAccount : GeneralAccount
    {
        public SberAccount (double currentSum, string ownerName) : base (currentSum, ownerName)
        {

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
                Console.WriteLine("Счет закрыт, вносить деньги нельзя");
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
    }

}
