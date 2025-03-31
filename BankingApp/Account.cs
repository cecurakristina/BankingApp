using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace BankingApp
{
    internal class Account
    {
        //private fields
        private int _accountId;
        private string _accountType;
        private double _accountBalance;

        //public properties
        public int AccountId
        {
            get { return _accountId; }
            set { _accountId = value; }
        }
        public string AccountType
        {
            get { return _accountType; }
            set { _accountType = value; }
        }
        public double AccountBalance
        {
            get { return _accountBalance; }
            set { _accountBalance = value; }
        }

        //constructor
        public Account (int accountId, string accountType, double accountBalance)
        {
            AccountId = accountId;
            AccountType = accountType;
            AccountBalance = accountBalance;
        }

        //methods
        public void DisplayBalance()
        {
            Console.WriteLine($"Your account balance is ${AccountBalance}.");
        }

        //override toString() to be able to display account information and not just class name
        public override string ToString()
        {
            return $"Account ID: {AccountId}, Account Type: {AccountType}, Account Balance: {AccountBalance}";
        }

        //test retrieving data from PostgreSQL
        public static void RetrieveAccounts()
        {
            //establish the connection
            string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=1804;Database=Final_Project";
            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM accounts";
                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine($"ID: {reader["account_id"]}, Type: {reader["account_type"]}, Balance: {reader["account_balance"]}");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}