using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankChet_HomeWork
{
    class SberChet : GeneralAccount
    {

        public void CloseSberChet()
        {
            if (_currentSum < 0)
            {
                CloseChet();
            }
            else
            {
                _isActive = true;
            }
        }
    }

}
