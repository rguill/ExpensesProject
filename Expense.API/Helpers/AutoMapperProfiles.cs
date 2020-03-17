using AutoMapper;
using Expense.API.DTOs;
using Expense.API.Models;

namespace Expense.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Expenses, ExpenseToList>();
        }
    }
}