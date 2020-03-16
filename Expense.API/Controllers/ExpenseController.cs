using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Expense.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Expense.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpenseController : ControllerBase
    {
        private readonly DataContext _context;
        public ExpenseController(DataContext context)
        {
            _context = context;
        }

        // GET api/expense
        [HttpGet]
        public async Task<IActionResult> GetExpenses()
        {
            var expenses = await _context.Expenses.ToListAsync();

            return Ok(expenses);
        }

        // GET api/expense/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetExpense(int id)
        {
            var expense = await _context.Expenses.FirstOrDefaultAsync(x => x.Id == id);

            return Ok(expense);
        }

        // POST api/expense
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/expense/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/expense/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}