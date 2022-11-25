using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeldAutomat_ATM_.UI
{
    public class LoginValidator
    {

        public static Users UserChecks(string pin)
        {
            //string aUserInput = WillkommeSprachen.Willkomme();

            CustomerList customerList = new CustomerList();

            var _customers = customerList.getCustomers();

            var user = _customers.Where( x=> x.ATMPin == pin).FirstOrDefault();

            Console.WriteLine(user.balance);

            return user;

            //foreach(Users user in _customers)
            //{
            //   if(user.ATMPin != pin)
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        Console.WriteLine(user.fName);
            //        atmUser = user;
            //        break;
            //    }
            //}
            //return atmUser;
        }
    }

}