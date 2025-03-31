using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace BankingApp
{
    public partial class AddCustomerForm : Form
    {
        //create connection to database
        private string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=1804;Database=Final_Project";

        //create an instance of the DatabaseHeleper class to be able to use its methods
        private DatabaseHelper dbHelper = new DatabaseHelper();
        public AddCustomerForm()
        {
            InitializeComponent();
        }

        //SAVE BUTTON
        private void saveCustomerButton_Click(object sender, EventArgs e)
        {
            //retrieve user input
            int customerId;
            if (!int.TryParse(customerIdTextBox.Text, out customerId))
            {
                MessageBox.Show("Please enter a valid Customer ID.");
                return;
            }

            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string customerAddress = customerAddressTextBox.Text;
            string customerEmail = customerEmailTextBox.Text;
            string customerPhone = customerPhoneTextBox.Text;

            // Call method to insert into the database
            dbHelper.AddCustomer(customerId, firstName, lastName, customerAddress, customerEmail, customerPhone);
            this.Close(); // Closes the form
        }

        //CANCEL BUTTON
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close(); // Closes the form if cancel is clicked
        }
    }
}
