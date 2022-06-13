using BankLibrary;
using Microsoft.EntityFrameworkCore;

namespace BankServer.Models
{
    public interface IApplicationDbContext
    {
        DbSet<Transaction> Transactions { get; }
    }
}
