using Expense.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Expense.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        // Property allows the DataContext class to know about the Expenses Model.
        // Declares property as public DbSet of type Expenses. Name of the DbSet represents the table name when 
        // database is created.
        public DbSet<Expenses> Expenses { get; set; }
    }
}