using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_BankClient
{
    class StandardClient
    {
        List<BaseAccount> accountsList = new List<BaseAccount>(3);
        public void AddAccount (BaseAccount account)
        {
            accountsList.Add(account);
        }

        public void PrintAccountNumber()
        {
            for (int i = 0; i < accountsList.Count; i++)
            {
                Console.WriteLine($"Сумма на счету Обычного клиента: {accountsList[i].ReturnCurrentSum}, {accountsList[i].ReturnAllDaInfO}");
            }
        }

    }
}
