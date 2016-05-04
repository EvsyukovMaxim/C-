using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankChet_HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //GeneralAccount myGeneralAccount = new GeneralAccount();
            //myGeneralAccount.CloseChet();
            SberAccount mySberAccount = new SberAccount();

            Console.WriteLine("Счет действителен: "+ mySberAccount.CloseSberAccount());
            Console.WriteLine(mySberAccount.FillChet(100));
            Console.WriteLine(mySberAccount.TakeMoneyFromChet(100100));
            Console.WriteLine("Счет действителен: " + mySberAccount.CloseSberAccount());
        }
    }
}
