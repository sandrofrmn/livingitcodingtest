using BankLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankServer.Interactors
{
    public interface IInteractor
    {
        Task<IEnumerable<Transaction>> GetTransactions();
        Task<Transaction> GetTransactionById(int transactionId);
        Task<Transaction> WriteTransaction(Transaction transaction);
    }
}
