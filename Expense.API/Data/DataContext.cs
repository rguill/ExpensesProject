using Expense.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Expense.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        public DbSet<Expenses> Expenses { get; set; }
    }
}