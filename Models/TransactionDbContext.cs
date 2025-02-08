using Microsoft.EntityFrameworkCore;

namespace Bank__Transactions.Models
{
    public class TransactionDbContext:DbContext
    {
        public TransactionDbContext
            (DbContextOptions<TransactionDbContext> options): base(options)
        {}

        public DbSet<Transaction>Transactions { get; set; }
    }
}
