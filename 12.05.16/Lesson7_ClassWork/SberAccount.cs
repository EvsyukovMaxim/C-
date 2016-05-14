using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_ClassClient
{
    //Сберегательный счет
    class SberAccount : GeneralAccount
    {
        public SberAccount (int currentSum) : base (currentSum)
        {
            _currentSum = 50000;
        }
    }

}
