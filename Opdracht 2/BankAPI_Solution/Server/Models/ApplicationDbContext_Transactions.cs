using Microsoft.EntityFrameworkCore;
using BankLibrary;

namespace BankServer.Models
{
    public partial class ApplicationDbContext : DbContext
    {
        public DbSet<Transaction> Transactions { get; set; }

        static partial void SetAdditionalConfiguration_Transactions(ModelBuilder builder)
        {
            SetConfigurationTransactions(builder);
        }

        private static void SetConfigurationTransactions(ModelBuilder builder)
        {
            builder.Entity<Transaction>().Property(i => i.AccountNumber).IsRequired().HasMaxLength(50);
            builder.Entity<Transaction>().Property(i => i.Mutation).IsRequired();
        }

        static partial void SeedDatabase_Transactions(ModelBuilder builder)
        {
            SeedTransactions(builder);
        }

        private static void SeedTransactions(ModelBuilder builder)
        {
            builder.Entity<Transaction>().HasData(new Transaction
            {
                TransactionReference = 1,
                AccountNumber = "NL10RABO9182987610",
                StartBalance = 1000.95,
                Mutation = -35.95,
                Description = "Food",
            });
        }
    }
}
