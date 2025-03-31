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
    public partial class DisplayAccountForm : Form
    {
        //establish connection to the database
        private string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=1804;Database=Final_Project";

        //create an instance of the DatabaseHelper class to be able to use its methods
        DatabaseHelper dbHelper = new DatabaseHelper();
        public DisplayAccountForm()
        {
            InitializeComponent();
        }

        //SEARCH BUTTON
        private void searchButton_Click(object sender, EventArgs e)
        {
            //make sure account ID is a valid int
            int accountId;
            if (!int.TryParse(accountIdTextBox.Text, out accountId))
            {
                MessageBox.Show("Please enter a valid account ID.");
                return;
            }
            //call DisplayAccount function
            dbHelper.DisplayAccount(accountId);
            this.Close();
        }
    }
}
