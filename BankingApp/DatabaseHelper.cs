using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace BankingApp
{
    internal class DatabaseHelper
    {
        //create connection to database
        private string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=1804;Database=Final_Project";


        //CRUD OPERATIONS FOR THE ACCOUNT CLASS
        //CREATE: Add a new account
        public void CreateAccount(int accountId, string accountType, double accountBalance)
        {
            using(var connection = new NpgsqlConnection(connectionString))
                try
                {
                    connection.Open();
                    string query = "INSERT INTO account (account_id, account_type, account_balance) VALUES(@id, @type, @balance)";
                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("id", accountId);
                        cmd.Parameters.AddWithValue("type", accountType);
                        cmd.Parameters.AddWithValue("balance", accountBalance);
                        cmd.ExecuteNonQuery();
                    }
                    Console.WriteLine("Account created successfully!");
                }
                catch (Exception ex) 
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
    
        }
        //READ: Display account information
        public void DisplayAccount(int accountId)
        {
            //establish connection to the database
            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM accounts WHERE account_id = @id";
                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("id", accountId);
                        using(var reader  = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                //get the values from the row corresponding to the id and save them in a string
                                string accountType = reader["account_type"].ToString();
                                double accountBalance = Convert.ToDouble(reader["account_balance"]);
                                DateTime dateOpened = Convert.ToDateTime(reader["account_open_date"]);
                                
                                //display the values retrieved
                                MessageBox.Show($"Account ID: {accountId}\nAccount Type: {accountType}\nAccount Balance: {accountBalance}\nDate Opened: {dateOpened}");
                            }
                            else
                            {
                                MessageBox.Show("Account not found.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }
        //UPDATE: Update account balance
        public void UpdateBalance(int accountId, double newBalance)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE accounts SET account_balance = @balance WHERE account_id = @id";
                    using (var cmd = new NpgsqlCommand(query,connection))
                    {
                        cmd.Parameters.AddWithValue("id", accountId );
                        cmd.Parameters.AddWithValue("balance", newBalance);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show(rowsAffected > 0 ? "Balance updated successfully!" : "Account not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }
        //DELETE: Delete an account
        public void DeleteAccount(int accountId)
        {
            //ask for confirmation before removing an account
            var confirmResult = MessageBox.Show("Are you sure you want to delete this account?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult != DialogResult.Yes)
            {
                return;
            }
            //connect to the database
            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM account WHERE account_id = @id";
                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("id", accountId);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show(rowsAffected > 0 ? "Account deleted successfully" : "Account not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        //CRUD OPERATIONS FOR THE CUSTOMER CLASS
        //CREATE: Add a new customer
        public void AddCustomer(int customerId, string firstName, string lastName, string customerAddress, string customerEmail, string customerPhone)
        {
            //establish connection to the database
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO customers (customer_id, first_name, last_name, address, email, phone) VALUES (@id, @firstname, @lastname, @address, @email, @phone)";
                using (var cmd = new NpgsqlCommand(query, connection))
                {
                    try
                    {
                        //pass the method parameter values into the query
                        cmd.Parameters.AddWithValue("id", customerId);
                        cmd.Parameters.AddWithValue("firstname", firstName);
                        cmd.Parameters.AddWithValue("lastname", lastName);
                        cmd.Parameters.AddWithValue("address", customerAddress);
                        cmd.Parameters.AddWithValue("email", customerEmail);
                        cmd.Parameters.AddWithValue("phone", customerPhone);
                        //execute query
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Customer added successfully!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
            }
        }
        //READ: Display customer's information
        public void DisplayCustomer(int customerId)
        {
            //establish connection to the database
            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM customers WHERE customer_id = @id";
                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("id", customerId);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                //get the values from the row corresponding to the id and save them in a string
                                string firstName = reader["first_name"].ToString();
                                string lastName = reader["last_name"].ToString();
                                string address = reader["address"].ToString();
                                string email = reader["email"].ToString();
                                string phone = reader["phone"].ToString();

                                //display the values retreived
                                MessageBox.Show($"ID: {customerId}\nName: {firstName} {lastName}\nAddress: {address}\nEmail: {email}\nPhone: {phone}");
                            }
                            else
                            {
                                MessageBox.Show("Customer not found.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }
        //UPDATE: Update customer's info
        public void UpdateCustomerInfo(int customerId, string columnName, string newValue)
        {
            //check if the column name is valid
            List<string> allowedColumns = new List<string> {"first_name", "last_name", "email", "phone"};
            if (!allowedColumns.Contains(columnName))
            {
                MessageBox.Show("Invalid column name.");
                return;
            }
            //establish connection to the database
            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = $"UPDATE customers SET {columnName} = @newvalue WHERE customer_id = @customerid";
                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("newvalue", newValue);
                        cmd.Parameters.AddWithValue("customerid", customerId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Successfully updated customer information.");
                        }
                        else
                        {
                            MessageBox.Show("Customer not found.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }
        //DELETE: Remove customer from the database
        public void RemoveCustomer(int customerId)
        {
            //ask for confirmation before removing a customer
            var confirmResult = MessageBox.Show("Are you sure you want to delete this customer?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult != DialogResult.Yes)
            {
                return;
            }
            //establish connection to the database
            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM customers WHERE customer_id = @id";
                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("id", customerId);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Customer successfully deleted.");
                        }
                        else
                        {
                            MessageBox.Show("Customer not found.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        //CRUD OPERATIONS FOR THE TRANSACTION CLASS
        //CREATE: Add a new transaction
        public void CreateTransaction(int transactionId, double transactionAmount, DateTime transactionDate, string transactionType, int accountId, int atmId)
        {
            //establish connection with the database
            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO transactions (transaction_id, transaction_amount, transaction_date, transaction_type, account_id, atm_id) VALUES (@id, @amount, @date, @type, @accountid, @atmid)";
                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("id", transactionId);
                        cmd.Parameters.AddWithValue("amount", transactionAmount);
                        cmd.Parameters.AddWithValue("date", transactionDate);
                        cmd.Parameters.AddWithValue("type", transactionType);
                        cmd.Parameters.AddWithValue("accountid", accountId);
                        cmd.Parameters.AddWithValue("atmid", atmId);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successfully created transaction.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }
        //READ: Display a transaction
        public void DisplayTransaction(int transactionId)
        {
            //establish connection to the database
            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM transactions WHERE transaction_id = @id";
                    using (var cmd = new NpgsqlCommand(query,connection))
                    {
                        cmd.Parameters.AddWithValue("id", transactionId );
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string details = $"ID: {reader["transaction_id"]}\n" +
                                                 $"Amount: {reader["transaction_amount"]}\n" +
                                                 $"Date: {reader["transaction_date"]}\n" +
                                                 $"Type: {reader["transaction_type"]}";
                                MessageBox.Show(details, "Transaction Details");
                            }
                            else
                            {
                                MessageBox.Show("Transaction not found.");
                            }
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }
        //UPDATE: Change transaction information
        public void ChangeTransactionInformation(int transactionId, string columnName, string newValue)
        {
            //define allowed columns with their expected types
            Dictionary<string, NpgsqlTypes.NpgsqlDbType> allowedColumns = new Dictionary<string, NpgsqlTypes.NpgsqlDbType>
            {
                { "transaction_amount", NpgsqlTypes.NpgsqlDbType.Numeric },
                { "transaction_date", NpgsqlTypes.NpgsqlDbType.Timestamp },
                { "transaction_type", NpgsqlTypes.NpgsqlDbType.Varchar },
                { "account_id", NpgsqlTypes.NpgsqlDbType.Integer },
                { "atm_id", NpgsqlTypes.NpgsqlDbType.Integer }
            };

            //check if the column name is valid
            if (!allowedColumns.ContainsKey(columnName))
            {
                MessageBox.Show("Invalid column name");
                return;
            }

            //ask for confirmation before updating
            var confirmResult = MessageBox.Show($"Are you sure you want to update {columnName}?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.No)
            {
                return;
            }
            //establish connection to the database
            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = $"UPDATE transactions SET {columnName} = @newvalue WHERE transaction_id = @id";
                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        //add transaction ID parameter
                        cmd.Parameters.AddWithValue("id", transactionId);

                        //convert newValue to the appropriate typeadmin
                        NpgsqlTypes.NpgsqlDbType columnType = allowedColumns[columnName];
                        object convertedValue;

                        try
                        {
                            switch (columnType)
                            {
                                case NpgsqlTypes.NpgsqlDbType.Integer:
                                    convertedValue = int.Parse(newValue);
                                    break;
                                case NpgsqlTypes.NpgsqlDbType.Numeric:
                                    convertedValue = decimal.Parse(newValue);
                                    break;
                                case NpgsqlTypes.NpgsqlDbType.Timestamp:
                                    convertedValue = DateTime.Parse(newValue);
                                    break;
                                case NpgsqlTypes.NpgsqlDbType.Varchar:
                                default:
                                    convertedValue = newValue;
                                    break;
                            }
                            //add parameter with the right type
                            cmd.Parameters.Add(new NpgsqlParameter("newvalue", columnType) { Value = convertedValue });
                        }
                        catch (Exception ex) 
                        {
                            MessageBox.Show($"Error: {ex.Message}");
                        }
                        var rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Successfully updated transaction.");
                        }
                        else
                        {
                            MessageBox.Show("Transaction not found.");
                        }
                    }
                }
                catch (Exception ex) 
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }  
            }
        }
        //DELETE: Remove transaction
        public void RemoveTransaction(int transactionId)
        {
            //make sure transaction id is a positive number
            if (transactionId <= 0)
            {
                MessageBox.Show("Invalid ID.");
                return;
            }
            //ask for confirmation
            var removeConfirmation = MessageBox.Show($"Are you sure you want to remove transaction ID {transactionId}?", "Confirm Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (removeConfirmation == DialogResult.No)
            {
                return;
            }
            //establish connection to the database
            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM transactions WHERE transaction_id = @id";
                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("id", transactionId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"Transaction ID {transactionId} successfully removed.");
                        }
                        else
                        {
                            MessageBox.Show($"Transaction ID {transactionId} not found.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

    }
}
