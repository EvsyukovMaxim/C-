using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firmy_Task1
{
    public class IP : Client
    {
        private string _personFIO;
        private DateTime _birthDate;

        public IP (string personFIO, DateTime birthDate, string Id, string mainTelephoneNumber, long orderSum) : base (Id, mainTelephoneNumber, orderSum)
        {
            _personFIO = "Иванов И.И.";
            _birthDate = new DateTime(1987, 9, 14);
        }

        public void ReturnPersonFIO()
        {
            Console.WriteLine("ИП " + _personFIO);
        }
    }
}
