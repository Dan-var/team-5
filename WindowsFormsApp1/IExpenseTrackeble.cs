using System;
using System.Collections.Generic;
using System.Linq;

namespace ExpenseTracker
{
    interface IExpenseTrackable
    {
        void AddExpense(decimal amount, string category);
        void ShowExpenses();
        decimal GetTotalExpenses();
    }
}
