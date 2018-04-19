using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

namespace service
{
    public class CustomerDL
    {
        public static List<Customer> Customers = new List<Customer>();

        public bool Isvalidcust(string username, string password)
        {
            bool iffound = false;
            foreach(Customer c in CustomerDL.Customers)
            {
                if (c.Custname == username && c.Custpassword == password)
                    iffound = true;
            }
            return iffound;

        }

    }
}