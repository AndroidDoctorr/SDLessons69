using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _08_Interfaces.Currency
{
    [TestClass]
    public class TransactionTests
    {
        private decimal _debt;

        private void PayDebt(ICurrency payment)
        {
            _debt -= payment.Value;
            Console.WriteLine($"You have paid ${payment.Value} towards your debt!");
        }

        [TestInitialize]
        public void Arrange()
        {
            _debt = 9000.13m;
        }

        [TestMethod]
        public void PayDebtTest()
        {
            PayDebt(new Dollar());
            PayDebt(new ElectronicPayment(532.17m));

            decimal expectedDebt = 9000.13m - 533.17m;

            Assert.AreEqual(_debt, expectedDebt);
        }

        [TestMethod]
        public void InjectingIntoConstructors()
        {
            var dollar = new Dollar();
            var ePayment = new ElectronicPayment(317.2m);

            var firstTransaction = new Transaction(dollar);
            var secondTransaction = new Transaction(ePayment);

            Console.WriteLine(firstTransaction.GetTransactionType());
            Console.WriteLine(secondTransaction.GetTransactionType());

            Assert.AreEqual("Dollar", firstTransaction.GetTransactionType());
            Assert.AreEqual("Electronic Payment", secondTransaction.GetTransactionType());
        }
    }
}
