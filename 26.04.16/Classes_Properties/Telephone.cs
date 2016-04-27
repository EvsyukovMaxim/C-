using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Properties
{
    public class Telephone
    {
        private string _cityCode;
        private string _telephoneNumber;

        public Telephone(string cityCode, string telephoneNumber)
        {
            _cityCode = cityCode;
            _telephoneNumber = telephoneNumber;
        }

        public string FullNumber (string cityCode, string telephoneNumber)
        {
            if (cityCode == null)
            {
                return telephoneNumber;
            }
            return "(" + cityCode + ")" + telephoneNumber;
        }
    }
}
