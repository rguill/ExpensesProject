using System.ComponentModel.DataAnnotations;

namespace Expense.API.DTOs
{
    public class ExpenseToCreateDTO
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public float Amount { get; set; }

        [Required]
        public string Description { get; set; }
    }
}