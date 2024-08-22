using Microsoft.EntityFrameworkCore;

namespace crud.Models
{
    public class CrudDbContext : DbContext
    {
        public DbSet<Expense> Expenses{get; set;}
        public CrudDbContext(DbContextOptions<CrudDbContext> options):base(options)
        {
            
        }
    }
}
