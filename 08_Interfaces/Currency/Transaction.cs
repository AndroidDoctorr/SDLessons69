using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Interfaces.Currency
{
    public class Transaction
    {
        private readonly ICurrency _currency;

        public Transaction(ICurrency currency)
        {
            _currency = currency;
            DateOfTransaction = DateTime.Now;
        }

        public DateTime DateOfTransaction { get; set; }

        public string GetTransactionType()
        {
            return _currency.Name;
        }

        public decimal GetTransactionAmount()
        {
            return _currency.Value;
        }
    }
}
