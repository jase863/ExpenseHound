using System.ComponentModel.DataAnnotations;

namespace ExpenseHound.Models
{
    public class Expense
    {
        // Simple name of expense?
        public string Description { get; set; }
        //Amount of expense.
        public decimal Amount { get; set; }
        //Category (Rent, Groceries, etc..)
        public string Category { get; set; }
        //Type of Expense (Fixed, Variable, etc..)
        public string ExpenseType { get; set; }
        //Date of Expense
        public DateTime Date { get; set; }
    }
}
