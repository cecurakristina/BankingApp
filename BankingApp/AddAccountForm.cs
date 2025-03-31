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
    public partial class AddAccountForm : Form
    {
        //create connection to database
        private string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=1804;Database=Final_Project";

        //create an instance of the DatabaseHeleper class to be able to use its methods
        private DatabaseHelper dbHelper = new DatabaseHelper();
        public AddAccountForm()
        {
            InitializeComponent();
        }

        //ADD ACCOUNT BUTTON
        private void addAccountButton_Click(object sender, EventArgs e)
        {
            //check if account ID is a valid int
            int accountId;
            if (!int.TryParse(accountIdTextBox.Text, out accountId))
            {
                MessageBox.Show("Please enter a valid account ID.");
                return;
            }
            //make sure account balance is a valid double
            double accountBalance;
            if (!double.TryParse(accountbalanceTextBox.Text, out accountBalance))
            {
                MessageBox.Show("Please enter a valid account balance.");
                return;
            }
            //save values in strings
            string accountType = accountTypeTextBox.Text;
            

            //call the CreateAccount function
            dbHelper.CreateAccount(accountId, accountType, accountBalance);
            this.Close();
        }

        //CANCEL BUTTON
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
