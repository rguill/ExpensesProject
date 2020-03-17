using System;
using System.ComponentModel.DataAnnotations;

namespace Expense.API.DTOs
{
    public class ExpenseToCreateDTO
    {
        // Data Transfer Object for setting up expenses to send to the API.
        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public double Amount { get; set; }

        [Required]
        public string Description { get; set; }
    }
}