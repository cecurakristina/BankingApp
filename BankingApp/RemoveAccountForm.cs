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
    public partial class RemoveAccountForm : Form
    {
        //connect to the database
        private string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=1804;Database=Final_Project";

        //instantiate a DatabaseHelper class to use its methods
        DatabaseHelper dbHelper = new DatabaseHelper();
        public RemoveAccountForm()
        {
            InitializeComponent();
        }

        //REMOVE BUTTON
        private void removeButton_Click(object sender, EventArgs e)
        {
            //check if account ID is a valid int
            int accountId;
            if (!int.TryParse(accountIdTextBox.Text, out accountId))
            {
                MessageBox.Show("Please enter a valid account ID.");
                return;
            }
            //call the DeleteAccount method
            dbHelper.DeleteAccount(accountId);
            this.Close();
        }

        //CANCEL BUTTON
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
