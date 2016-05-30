using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_BankClient
{
    public class VipClient : BankClient
    {
        public VipClient()
        {
            _accountsQuantity = 10;
        }
    }
}
