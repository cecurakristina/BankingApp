using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    internal class Customer
    {
        //private fields
        private string _name;
        private string _email;
        private int _customerId;

        //public properties
        public string Name 
        { 
            get { return _name; } 
            set { _name = value; } 
        } 

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public int CustomerId
        {
            get { return _customerId; }
            set { _customerId = value; }
        }

        //constructor
        public Customer(int customerId, string name, string email)
        {
            CustomerId = customerId;
            Name = name;
            Email = email;
        }

        //methods
        public void UpdateEmail (string newEmail)
        {
            Email = newEmail;
        }
   
        // override ToString() to be able to print customer information instead of just class name
        public override string ToString()
        {
            return $"Customer ID: {CustomerId}, Name: {Name}, Email: {Email}";
        }
    }
}
