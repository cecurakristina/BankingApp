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
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
        }


        private void LogInButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "admin" && passwordTextBox.Text == "password")
            {
                this.Hide();
                AdminDashboard dashboard = new AdminDashboard(usernameTextBox.Text);
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Failed login.");
            }
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
