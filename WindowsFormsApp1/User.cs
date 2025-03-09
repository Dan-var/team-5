using System;
using System.Collections.Generic;
using System.Linq;

namespace ExpenseTracker 
{
    public class User : BaseEntity, IExpenseTrackable
    {
        public string Name { get; }
        private List<Expense> Expenses { get; }

        public User(int id, string name) : base(id)
        {
            Name = name;
            Expenses = new List<Expense>();
        }

        public void AddExpense(decimal amount, string category)
        {
            Expenses.Add(new Expense(Expenses.Count + 1, amount, category));
        }

        public void ShowExpenses()
        {
            Console.WriteLine($"User {Name}'s expenses:");
            foreach (var expense in Expenses)
            {
                Console.WriteLine(expense);
            }
        }

        public decimal GetTotalExpenses() => Expenses.Sum(e => e.Amount);
    }
}
