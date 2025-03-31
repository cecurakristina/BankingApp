using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApp
{
    public partial class AddTransactionForm : Form
    {
        //create connection to database
        private string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=1804;Database=Final_Project";

        //create an instance of the DatabaseHeleper class to be able to use its methods
        private DatabaseHelper dbHelper = new DatabaseHelper();
        public AddTransactionForm()
        {
            InitializeComponent();
        }

        //ADD TRANSACTION BUTTON
        private void addTransactionButton_Click(object sender, EventArgs e)
        {
            //check if transaction ID is a valid int
            int trasactionId;
            if (!int.TryParse(transactionIdTextBox.Text, out trasactionId))
            {
                MessageBox.Show("Please enter a valid transaction ID.");
                return;
            }
            //check if transaction amount is a valid double
            double transactionAmount;
            if (!double.TryParse(transactionAmountTextBox.Text, out transactionAmount))
            {
                MessageBox.Show("Please enter a valid transaction amount.");
                return;
            }
            //check if transaction date is a valid DateTime
            DateTime transactionDate;
            if (!DateTime.TryParse(transactionDateTextBox.Text, out transactionDate))
            {
                MessageBox.Show("Please enter a valid transaction amount.");
                return;
            }
            //save the rest of the values in a variable
            string transactionType = transactiontypeTextBox.Text;
            int accountId = Convert.ToInt32(accountIdTextBox.Text);
            int atmId = Convert.ToInt32(atmIdTextBox.Text);

            //call the CreateTransaction method
            dbHelper.CreateTransaction(trasactionId, transactionAmount, transactionDate, transactionType, accountId, atmId);
        }

        //CANCEL BUTTON
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
