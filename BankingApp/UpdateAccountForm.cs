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
    public partial class UpdateBalanceForm : Form
    {
        //connect to the database
        private string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=1804;Database=Final_Project";
        //initialize DatabaseHelper class to be able to use its methods
        DatabaseHelper dbHelper = new DatabaseHelper();
        public UpdateBalanceForm()
        {
            InitializeComponent();
        }

        //UPDATE BUTTON
        private void updateButton_Click(object sender, EventArgs e)
        {
            //check if account ID is a valid int
            int accountId;
            if (!int.TryParse(accountIdTextBox.Text, out accountId))
            {
                MessageBox.Show("Please enter a valid account ID.");
                return;
            }

            //check if balance is a valid double
            double newBalance;
            if (!double.TryParse(newBalanceTextBox.Text, out newBalance))
            {
                MessageBox.Show("Please enter a valid balance.");
                return;
            }
            
            //call UpdateBalance method
            dbHelper.UpdateBalance(accountId, newBalance);
            this.Close();
        }

        //CANCEL BUTTON
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
