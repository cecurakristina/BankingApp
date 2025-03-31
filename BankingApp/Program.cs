using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace BankingApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //create a connection to PostgreSQL
            //save the path to the database in a string
            string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=1804;Database=Final_Project";
            //create an instance of NpgsqlConnection class provided by the NpgSql library
            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Successfully connected to the database!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
            //start the application
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginWindow());
        }
    }
}
