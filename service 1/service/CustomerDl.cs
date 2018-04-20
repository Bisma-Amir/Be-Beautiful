using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace service
{
    public class CustomerDl
    {
        public static List<Customer> Customers = new List<Customer>();
        public void Addcustomer(string name ,string password ,string phone,string address)
        {
            Customer m = new Customer();
            m.Custname = name;
            m.Custpassword = password;
            m.Custphone = phone;
            m.Custaddress = address;
            Customers.Add(m);
            
        }
    }
}