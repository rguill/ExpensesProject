namespace Expense.API.Models
{
    public class Expenses
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Amount { get; set; }
        public string Description { get; set; }
    }
}