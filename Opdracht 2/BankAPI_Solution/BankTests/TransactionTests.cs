using BankLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTests
{
    [TestClass]
    public class TransactionTests : TestBase
    {
        //[TestMethod]
        //public void GetTransactionsTest()
        //{

        //}

        [TestMethod]
        public async Task WriteTransactionTest()
        {
            // Valid transaction.
            Transaction transaction = new Transaction
            {
                TransactionReference = 2,
                AccountNumber = "NL29RABO1938288190",
                StartBalance = 1000,
                Mutation = -50
            };
            Transaction transaction1 = await Interactor.WriteTransaction(transaction);
            Assert.IsNotNull(transaction1);
            Assert.AreEqual(950, transaction1.EndBalance);
            // Transaction Reference not unique
            Assert.ThrowsException<ArgumentException>(() => Interactor.WriteTransaction(transaction1));
        }
    }
}
