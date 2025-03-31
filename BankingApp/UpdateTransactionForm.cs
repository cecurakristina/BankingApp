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
    public partial class UpdateTransactionForm : Form
    {
        //connect to the database
        private string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=1804;Database=Final_Project";

        //instantiate DatabaseHelper class to use its methods
        DatabaseHelper dbHelper = new DatabaseHelper();
        public UpdateTransactionForm()
        {
            InitializeComponent();
        }

        //UPDATE BUTTON
        private void updateButton_Click(object sender, EventArgs e)
        {
            //check if transaction ID is a valid int
            int transactionId;
            if (!int.TryParse(transactionidTextBox.Text, out transactionId))
            {
                MessageBox.Show("Please enter a valid transaction ID.");
                return;
            }
            //save values in a string
            string columnName = valueNameTextBox.Text;
            string newValue = newValueTextBox.Text;
            //
            dbHelper.ChangeTransactionInformation(transactionId, columnName, newValue);
            this.Close();
        }

        //CANCEL BUTTON
        private void cancelButton_Click(object sender, EventArgs e)
        {

        }
    }
}
