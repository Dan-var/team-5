using System;
using System.Collections.Generic;
using System.Linq;

namespace ExpenseTracker
{
    class Expense : BaseEntity
    {
        public decimal Amount { get; }
        public string Category { get; }
        public DateTime Date { get; }

        public Expense(int id, decimal amount, string category) : base(id)
        {
            Amount = amount;
            Category = category;
            Date = DateTime.Now;
        }

        public override string ToString()
        {
            return $"[{Date}] {Category}: {Amount} UAH";
        }
    }
}
