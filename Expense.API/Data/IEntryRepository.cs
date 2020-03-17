using System.Threading.Tasks;
using Expense.API.Models;

namespace Expense.API.Data
{
    public interface IEntryRepository
    {
         Task<Expenses> EnterExpense(Expenses expense);
    }
}