using System.Threading.Tasks;
using Expense.API.Models;

namespace Expense.API.Data
{
    public class EntryRepository : IEntryRepository
    {
        private readonly DataContext _context;
        public EntryRepository(DataContext context)
        {
            _context = context;

        }
        public async Task<Expenses> EnterExpense(Expenses expense)
        {
            await _context.Expenses.AddAsync(expense);
            await _context.SaveChangesAsync();

            return expense;
        }
    }
}