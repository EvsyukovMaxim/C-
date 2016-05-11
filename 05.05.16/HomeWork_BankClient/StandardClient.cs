using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_BankClient
{
    class StandardClient
    {
        List<BaseAccount> accountsList = new List<BaseAccount>();

        public void AddAccount (BaseAccount account)
        {
            int listCount = accountsList.Count;
            if (listCount < 3)
            {
                accountsList.Add(account);
            }
            else
            {
                Console.WriteLine("Можно только 3 счета");
            }
        }

        public void PrintAccountNumber()
        {
            for (int i = 0; i < accountsList.Count; i++)
            {
                Console.WriteLine($"Сумма Обычного клиента: {accountsList[i].ReturnCurrentSum},{accountsList[i].ReturnAccountNumber},{accountsList[i].ReturnFIO}");
            }
        }

        public string CloseClientAccount(string accountNumber)
        {
            for (int i = 0; i < accountsList.Count; i++)
            {
                if (accountsList[i].ReturnAccountNumber == accountNumber)
                {
                    accountsList.RemoveAt(i);
                }
            }
            return "Счет с номером: " + accountNumber + "- закрыт";
        }

        public void PrintIndex()
        {
            Console.Write(accountsList[2]);
        }
    }
}
