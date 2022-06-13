using BankLibrary;

namespace BankClient.Models
{
    public class TransactionModel
    {
        private int transactionReference;
        // An IBAN number
        private string accountNumber;
        // Starting balance in euros.
        private double startBalance;
        private double endBalance;
        // Addition or deduction in euros.
        private double mutation;
        private string description;

        public int TransactionReference => transactionReference;

        public string AccountNumber
        {
            get => accountNumber;
            set => accountNumber = value;
        }

        public double StartBalance
        {
            get => startBalance;
            set => startBalance = value;
        }

        public double EndBalance
        {
            get => endBalance;
            set => endBalance = value;
        }

        public double Mutation
        {
            get => mutation;
            set => mutation = value;
        }

        public string Description
        {
            get => description;
            set => description = value;
        }

        public TransactionModel() { SetTransaction(null); }

        private void SetTransaction(Transaction transaction)
        {
            if (transaction != null)
            {
                transactionReference = transaction.TransactionReference;
                accountNumber = transaction.AccountNumber;
                startBalance = transaction.StartBalance;
                endBalance = transaction.EndBalance;
                mutation = transaction.Mutation;
                description = transaction.Description;              
            }
            else
            {
                transactionReference = 0;
            }
        }

        public Transaction GetTransaction()
        {
            return new Transaction
            {
                TransactionReference = TransactionReference,
                AccountNumber = AccountNumber,
                StartBalance = StartBalance,
                EndBalance = EndBalance,
                Mutation = Mutation,
                Description = Description
            };
        }
    }
}
