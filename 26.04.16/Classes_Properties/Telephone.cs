using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Properties
{
    public class Telephone
    {
        readonly string _cityCode;
        readonly string _telephoneNumber;

        public Telephone()
        {
            _cityCode = "999";
            _telephoneNumber = "9999999";
        }

        public string FullNumber
        {
            get
            {
                if (_cityCode == null)
                {
                    return _telephoneNumber;
                }
                return "(" + _cityCode + ")" + _telephoneNumber;
            }
            
        }
    }
}
