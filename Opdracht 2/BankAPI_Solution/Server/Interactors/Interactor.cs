using BankLibrary;
using BankServer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankServer.Interactors
{
    public class Interactor : IInteractor
    {
        private readonly ApplicationDbContext applicationDbContext;
        private readonly DataAccessDB dataAccess;
        public Interactor(DataAccessDB dataAccess)
        {
            this.dataAccess = dataAccess;
        }

        public Interactor() { }

        public async Task<IEnumerable<Transaction>> GetTransactions()
        {
            return await applicationDbContext.Transactions.ToListAsync();
        }

        public async Task<Transaction> GetTransactionById(int transactionId)
        {
            return await applicationDbContext.Transactions.FirstOrDefaultAsync(i => i.TransactionReference == transactionId);
        }
        public async Task<Transaction> WriteTransaction(Transaction transaction)
        {
            var result = await applicationDbContext.Transactions.AddAsync(transaction);
            await applicationDbContext.SaveChangesAsync();
            return result.Entity;
        }
    }
}
