using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomeWork_BankClient;

namespace Tests
{
    [TestClass]
    public class DepositAccTest
    {
        [TestMethod]
        public void DepositAccountTest1_0()
        {
            //Arange
            MetallAccount exampleMet = new MetallAccount("");
            SavingAccount exampleSav = new SavingAccount("");

            //Act
            exampleMet.DepositAccount(100);

            //Assert
            Assert.AreEqual(100100, exampleMet.ReturnCurrentSum);
        }

        public void DepositAccountTest1_1()
        {
            //Arange
            MetallAccount exampleMet = new MetallAccount("");
            SavingAccount exampleSav = new SavingAccount("");

            //Act
            exampleMet.DepositAccount(100);

            //Assert
            Assert.AreNotEqual(100000, exampleMet.ReturnCurrentSum);
        }

        public void DepositAccountTest1_2()
        {
            //Arange
            MetallAccount exampleMet = new MetallAccount("");
            SavingAccount exampleSav = new SavingAccount("");

            //Act
            exampleMet.DepositAccount(100);

            //Assert
            Assert.AreNotEqual(99000, exampleSav.ReturnCurrentSum);
        }

        [ExpectedException(typeof(InvalidOperationException))]
        public void DepositAccountTest2()
        {
            //Arange
            MetallAccount exampleMet = new MetallAccount("");
            SavingAccount exampleSav = new SavingAccount("");

            //Act
            exampleSav.DepositAccount(-1000);

            //Assert
            Assert.AreNotEqual(100000, exampleMet.ReturnCurrentSum);
        }

        public void DepositAccountTest3()
        {
            //Arange
            MetallAccount exampleMet = new MetallAccount("");
            SavingAccount exampleSav = new SavingAccount("");

            //Act
            exampleSav.DepositAccount(-1000);

            //Assert
            Assert.AreNotEqual(99000, exampleSav.ReturnCurrentSum);
        }
    }
}
