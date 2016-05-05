using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankChet_HomeWork
{
    class SberAccount : GeneralAccount
    {
        public uint FillChet(uint plus)
        {
            if (isActive == true)
            {
                currentSum = currentSum + plus;
                return currentSum;
            }
            else
            {
                return 0; //Это вместо эксепшна, условие для отказа от каких либо действий, в случае, если счет закрыт
            }
        }

        public uint TakeMoneyFromChet (uint minus)
        {
            if (isActive == true)
            {
                currentSum = currentSum - minus;
                return currentSum;
            }
            else
            {
                return 0; //Это вместо эксепшна, условие для отказа от каких либо действий, в случае, если счет закрыт
            }

        }
    }

}
