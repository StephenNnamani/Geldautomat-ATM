using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeldAutomat_ATM_.UI
{
    public class CustomerList
    {
        public List<Users> getCustomers()
        {
            List<Users> Customers = new List<Users>()
            {
                new Users
                {
                    fName = "Stephen",
                    lName = "Nnamani",
                    accountNumber = "1234567890",
                    ATMNumber = "12345678",
                    ATMPin = "1234",
                    balance = 1000000,
                },
                new Users
                {
                    fName = "Fvour",
                    lName = "Kelvin",
                    accountNumber = "0987654321",
                    ATMNumber = "87654321",
                    ATMPin = "4321",
                    balance = 80000,
                },
                new Users
                {
                    fName = "Chisom",
                    lName = "Nnamani",
                    accountNumber = "5432167890",
                    ATMNumber = "43215678",
                    ATMPin = "2134",
                    balance = 100000,
                }
            };
            return Customers;
        }

    }
}
