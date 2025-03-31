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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }
        public AdminDashboard(String username)
        {
            InitializeComponent();
            greetingLabel.Text = $"Hello, {username}. What would you like to do today?";
        }

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            AddCustomerForm addCustomerForm = new AddCustomerForm();
            addCustomerForm.ShowDialog();
        }

        private void displayCustomerButton_Click(object sender, EventArgs e)
        {
            DisplayCustomerForm displayCustomerForm = new DisplayCustomerForm();
            displayCustomerForm.ShowDialog();
        }

        private void updateCustomerButton_Click(object sender, EventArgs e)
        {
            UpdateCustomerForm updateCustomerForm = new UpdateCustomerForm();
            updateCustomerForm.ShowDialog();
        }
        private void deleteCustomerButton_Click(object sender, EventArgs e)
        {
            RemoveCustomerForm removeCustomerForm = new RemoveCustomerForm();
            removeCustomerForm.ShowDialog();
        }

        private void addAccountButton_Click(object sender, EventArgs e)
        {
            AddAccountForm addAccountForm = new AddAccountForm();
            addAccountForm.ShowDialog();
        }

        private void displayAccountButton_Click(object sender, EventArgs e)
        {
            DisplayAccountForm displayAccountForm = new DisplayAccountForm();
            displayAccountForm.ShowDialog();
        }

        private void updateAccountButton_Click(object sender, EventArgs e)
        {
            UpdateBalanceForm updateAccountForm = new UpdateBalanceForm();
            updateAccountForm.ShowDialog();
        }

        private void deleteAccountButton_Click(object sender, EventArgs e)
        {
            RemoveAccountForm removeAccountForm = new RemoveAccountForm();
            removeAccountForm.ShowDialog();
        }

        private void addTransactionButton_Click(object sender, EventArgs e)
        {
            AddTransactionForm addTransactionForm = new AddTransactionForm();
            addTransactionForm.ShowDialog();
        }
        private void displayTransactionsButton_Click(object sender, EventArgs e)
        {
            DisplayTransactionForm displayTransactionForm = new DisplayTransactionForm();
            displayTransactionForm.ShowDialog();
        }

        private void updateTransactionButton_Click(object sender, EventArgs e)
        {
            UpdateTransactionForm updateTransactionForm = new UpdateTransactionForm();
            updateTransactionForm.ShowDialog();
        }

        private void deleteTransactionButton_Click(object sender, EventArgs e)
        {
            RemoveTransactionForm removeTransactionForm = new RemoveTransactionForm();
            removeTransactionForm.ShowDialog();
        }
    }
}
