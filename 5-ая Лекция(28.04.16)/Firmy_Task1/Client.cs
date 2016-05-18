using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firmy_Task1
{
    public class Client
    {
        private string _Id;
        private string _mainTelephoneNumber;
        private long _orderSum;

        public Client (string Id, string mainTelephoneNumber, long orderSum)
        {
            _Id = "123456789";
            _mainTelephoneNumber = "(999) 123-45-67";
            _orderSum = 480530;
        }
        public void ReturnOrderSum()
        {
            Console.WriteLine("Сумма заказа: " + _orderSum + " руб.");
        }
    }
}
