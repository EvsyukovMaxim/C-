using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_BankClient
{
    class VipClient
    {
        List<BaseAccount> accountsList = new List<BaseAccount>();

        public void AddAccountVIP(BaseAccount account)
        {
            int listCount = accountsList.Count;
            if (listCount < 10)
            {
                accountsList.Add(account);
            }
            else
            {
                Console.WriteLine("Можно только 10 счетов");
            }
        }

        public void PrintAccountNumber()
        {
            for (int i = 0; i < accountsList.Count; i++)
            {
                Console.WriteLine($"Сумма VIP-клиента: {accountsList[i].ReturnCurrentSum},{accountsList[i].AccountNumber},{accountsList[i].ReturnFIO}");
            }
        }

        public void CloseClientAccount(string accountNumber)
        {
            for (int i = 0; i < accountsList.Count; i++)
            {
                if (accountsList[i].AccountNumber == accountNumber)
                {
                    accountsList.RemoveAt(i);
                    Console.WriteLine("Счет с номером: " + accountNumber + " - закрыт");
                }
            }
        }
    }
}
