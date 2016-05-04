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
            SberChet mySberChet = new SberChet();

            Console.WriteLine("Счет действителен: "+ mySberChet.CloseSberAccount());
            Console.WriteLine(mySberChet.FillChet(100));
            Console.WriteLine(mySberChet.TakeMoneyFromChet(100001));
            Console.WriteLine("Счет действителен: " + mySberChet.CloseSberAccount());
        }
    }
}
