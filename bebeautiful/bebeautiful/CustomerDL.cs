using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace bebeautiful
{
    class CustomerDL
    {
       public static List<Customer> Customers = new List<Customer>();
        public void addcust(Customer c)
        {
            Customers.Add(c);

        }
    }
}
