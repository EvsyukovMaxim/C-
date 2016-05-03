using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firmy_Task1
{
    class OOO : Client
    {
        private string _firmName;
        private string _bankAccount;
        public OOO(string firmName, string bankAccount, string Id, string mainTelephoneNumber, long orderSum) : base(Id, mainTelephoneNumber, orderSum)
        {
            _firmName = firmName;
            _bankAccount = bankAccount;
        }
        public void ReturnFirmName()
        {
            Console.WriteLine("OOO" + _firmName);
            Console.WriteLine("Bank Acc" + _bankAccount);
        }
    }

}
