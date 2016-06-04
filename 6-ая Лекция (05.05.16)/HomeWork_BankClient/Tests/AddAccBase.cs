using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomeWork_BankClient;

namespace Tests
{
    [TestClass]
    public class AddAccBase
    {
        [TestMethod]
        public void AddAccountBase()
        {
            //Arange
            BaseAccChild myBaseAccChild = new BaseAccChild("1111 2222 3333 4444");
            BankClientChild myBankClientChild = new BankClientChild();

            //Act
            myBankClientChild.AddAccount(myBaseAccChild);
            //Не ловим эксепшн, т.к. его тут и не должно быть. Отсутствия эксепшна при добавление счета - и есть положительный результат теста

            //Assert
        }
    }
}
