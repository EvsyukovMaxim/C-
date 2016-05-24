using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_BankClient
{
    abstract class BankClient
    {
        protected int _accountsQuantity;
        public BankClient ()
        {
            _accountsQuantity = 0;
        }
        
        List<BaseAccount> accountsList = new List<BaseAccount>();
        public virtual void AddAccount(BaseAccount account)
        {
            int listCount = accountsList.Count;
            if (listCount < _accountsQuantity)
            {
                accountsList.Add(account);
            }
            else
            {
                Console.WriteLine("Доступное количество счетов, не более: " + _accountsQuantity);
            }
        }

        public void PrintAccountNumber()
        {
            for (int i = 0; i < accountsList.Count; i++)
            {
                Console.WriteLine($"Сумма на счету: {accountsList[i].ReturnCurrentSum}, Номер счета: {accountsList[i].AccountNumber}, ФИО: {accountsList[i].ReturnFIO}, Активен: {accountsList[i].PrintIsActive}");
            }
        }

        public void CloseClientAccount(string accountNumber)
        {
            for (int i = 0; i < accountsList.Count; i++)
            {
                if (accountsList[i].AccountNumber == accountNumber)
                {
                    accountsList[i].CloseAccount();
                    Console.WriteLine("Счет с номером: " + accountNumber + " - закрыт");
                    
                }
            }
        }
    }
}
