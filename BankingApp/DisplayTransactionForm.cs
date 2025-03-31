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
    public partial class DisplayTransactionForm : Form
    {
        //establish connection to the database
        private string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=1804;Database=Final_Project";

        //create an instance of the DatabaseHelper class to be able to use its methods
        DatabaseHelper dbHelper = new DatabaseHelper();
        public DisplayTransactionForm()
        {
            InitializeComponent();
        }

        //SEARCH BUTTON
        private void searchButton_Click(object sender, EventArgs e)
        {
            //check if transaction ID is a valid int
            int transactionId;
            if (!int.TryParse(transactionIdTextBox.Text, out transactionId))
            {
                MessageBox.Show("Please enter a valid transaction ID.");
                return;
            }

            //call the DisplayTransaction method
            dbHelper.DisplayTransaction(transactionId);
            this.Close();
        }
    }
}
