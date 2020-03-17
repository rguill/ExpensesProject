using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Expense.API.Data;
using Expense.API.DTOs;
using Expense.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Expense.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpenseController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IEntryRepository _repo;
        private readonly IMapper _mapper;
        public ExpenseController(DataContext context, IEntryRepository repo, IMapper mapper)
        {
            _mapper = mapper;
            _repo = repo;
            _context = context;
        }

        // GetExpenses method returns a list of all expenses from the API.
        [HttpGet]
        public async Task<IActionResult> GetExpenses()
        {
            var expenses = await _context.Expenses.ToListAsync();

            var expensesToReturn = _mapper.Map<IEnumerable<ExpenseToList>>(expenses);

            return Ok(expensesToReturn);
        }

        // Entry method posts a new database entry to the API.
        [HttpPost("entry")]
        public async Task<IActionResult> Entry(ExpenseToCreateDTO expenseToCreate)
        {
            var newEntry = new Expenses
            {
                Name = expenseToCreate.Name,
                Date = expenseToCreate.Date,
                Amount = expenseToCreate.Amount.ToString(),
                Description = expenseToCreate.Description
            };

            var createdEntry = await _repo.EnterExpense(newEntry);

            return StatusCode(201);
        }
    }
}