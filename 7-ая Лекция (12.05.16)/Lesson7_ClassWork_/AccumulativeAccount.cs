using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_ClassClient
{
    //Накопительный счет
    class AccumulativeAccount : GeneralAccount
    {
        public AccumulativeAccount (int currentSum) : base (currentSum)
        {
        }
    }
}
