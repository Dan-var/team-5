using System;
using System.Collections.Generic;

// Абстрактний клас, що містить загальні властивості для всіх сутностей
abstract class BaseEntity
{
    public int Id { get; }
    protected BaseEntity(int id) => Id = id;
}

// Інтерфейс для об'єктів, які можуть зберігати витрати
interface IExpenseTrackable
{
    void AddExpense(decimal amount, string category);
    void ShowExpenses();
    decimal GetTotalExpenses();
}

// Клас користувача, який може мати витрати
class User : BaseEntity, IExpenseTrackable
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

// Клас витрат
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

// Основна програма
class Program
{
    static void Main()
    {
        User user = new User(1, "Ivan");
        user.AddExpense(100, "Groceries");
        user.AddExpense(50, "Transport");
        user.ShowExpenses();
        Console.WriteLine($"Total expenses: {user.GetTotalExpenses()} UAH");
    }
}
