using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using System.Runtime.Serialization;

namespace service
{
    [DataContract]
    public class CustomerDl
    {
        [DataMember]
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
        
        public bool Isvalidcust(string username, string password)
        {
            bool iffound = false;
            foreach (Customer c in CustomerDl.Customers)
            {
                if (c.Custname == username && c.Custpassword == password)
                    iffound = true;
            }
            return iffound;

        }

    }
}