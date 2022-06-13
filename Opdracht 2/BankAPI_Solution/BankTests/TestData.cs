using BankLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTests
{
    public static class TestData
    {
        public static List<Transaction> Transactions = new List<Transaction>
        {
            new Transaction
            {
                TransactionReference = 1,
                Description = "test transaction",
                AccountNumber = "NL10RABO9212029122",
                StartBalance = 500,
                Mutation = -30.95
            }
        };
    }
}
