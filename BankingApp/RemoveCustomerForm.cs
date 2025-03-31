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
    public partial class RemoveCustomerForm : Form
    {
        //connect to the database
        private string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=1804;Database=Final_Project";

        //instantiate DatabaseHelper class to use its methods
        DatabaseHelper dbHelper = new DatabaseHelper();
        public RemoveCustomerForm()
        {
            InitializeComponent();
        }

        //REMOVE BUTTON
        private void removeButton_Click(object sender, EventArgs e)
        {
            //check if the customer ID is a valid int
            int customerId;
            if (!int.TryParse(customerIdTextBox.Text, out customerId))
            {
                MessageBox.Show("Please enter a valid customer ID.");
                return;
            }

            //call the RemoveCustomer function
            dbHelper.RemoveCustomer(customerId);
            this.Close();
        }

        //CANCEL BUTTON
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
