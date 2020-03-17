namespace Expense.API.DTOs
{
    public class ExpenseToList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public double Amount { get; set; }
        public string Description { get; set; }
    }
}