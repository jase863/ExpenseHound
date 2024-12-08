using ExpenseHound.Models;

namespace ExpenseHound.Services
{
    public class ExpenseService
    {
        private List<Expense> _expenses = new List<Expense>();

        public IEnumerable<Expense> GetExpenses() => _expenses;

        public void AddExpense(Expense expense) => _expenses.Add(expense);

        public decimal GetTotal() => _expenses.Sum(e => e.Amount);
    }
}
