using System;
using System.ComponentModel.DataAnnotations;

namespace BankLibrary
{
    public class Transaction
    {
        // Id
        [Key]
        public int TransactionReference { get; set; }
        // An IBAN number
        public string AccountNumber { get; set; }
        // Starting balance in euros.
        public double StartBalance { get; set; }
        // Addition or deduction in euros.
        public double Mutation { get; set; }
        public string Description { get; set; }
        public double EndBalance
        {
            get
            {
                return StartBalance + Mutation;
            }
            set { }
        }
    }
}
