using System;

namespace Expense.API.Models
{
    public class Expenses
    {
        // Model used for expenses.
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Amount { get; set; }
        public string Description { get; set; }
    }
}