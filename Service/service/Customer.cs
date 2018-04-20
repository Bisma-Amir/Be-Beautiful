using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace service
{
    public class Customer
    {
        private string custname;
        private string custphone;
        private string custaddress;
        private string custpassword;

        public string Custname { get => custname; set => custname = value; }
        public string Custphone { get => custphone; set => custphone = value; }
        public string Custaddress { get => custaddress; set => custaddress = value; }
        public string Custpassword { get => custpassword; set => custpassword = value; }
    }
}