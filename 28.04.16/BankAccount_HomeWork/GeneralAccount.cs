using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankChet_HomeWork
{
    class GeneralAccount
    {
        internal long accountNumber;
        internal string ownerName;
        internal uint currentSum;
        internal bool isActive;

        public GeneralAccount ()
        {
            accountNumber = 1234567890123456;
            ownerName = "Евсюков М.В.";
            currentSum = 100000;
            isActive = true;
        }

        public bool CloseAccount()
        {
            if (currentSum == 0)
            {
                isActive = false;
                return isActive;
            }
            else
            {
                return isActive;
            }
        }
    }
}
