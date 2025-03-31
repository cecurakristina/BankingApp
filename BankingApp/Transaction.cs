using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    internal class Transaction
    {
        //private fields
        private int _transactionId;
        private double _transactionAmount;
        private string _transactionType;

        //public properties
        int TransactionId 
        {
            get { return _transactionId; }
            set { _transactionId = value; }
        }
        double TransactionAmount
        {
            get { return _transactionAmount; }
            set { _transactionAmount = value; }
        }
        string TransactionType
        {
            get {  return _transactionType; }
            set { _transactionType = value; }
        }
        //constructor
        public Transaction(int transactionId, double transactionAmount, string transactionType)
        {
            TransactionId = transactionId;
            TransactionAmount = transactionAmount;
            TransactionType = transactionType;
        }

        //methods
        public void DisplayTransaction()
        {
            Console.WriteLine($"Transaction ID: {TransactionId}, Transaction Type: {TransactionType}, Transaction Amount: {TransactionAmount}");
        }

        //override toString() to be able to display transaction information
        public override string ToString()
        {
            return $"Transaction ID: {TransactionId}, Transaction Amount: {TransactionAmount}, Transaction Type: {TransactionType}";
        }
    }
}
