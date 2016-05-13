using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankChet_HomeWork
{
    //Расчетный  счет
    class CheckingAccount : SberAccount
    {
        public CheckingAccount (double currentSum, string ownerName) : base(currentSum, ownerName)
        {

        }
        public void Fee(double feeValue)
        {
            double a = ((_currentSum * (feeValue / 100)) / 12);
            Console.WriteLine("Сумма платы за обслуживание Расчетного счета: " + Math.Round(a, 2));
            Console.Write("Общий остаток Расчетного счета после обслуживания: "); WithdrawMoneyFromAccount(Math.Round(a, 2));
        }
    }
}
