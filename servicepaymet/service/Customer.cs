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
        private string custcity;

        public string Custname
        {
            get
            {
                return custname;
            }

            set
            {
                custname = value;
            }
        }

        public string Custphone
        {
            get
            {
                return custphone;
            }

            set
            {
                custphone = value;
            }
        }

        public string Custaddress
        {
            get
            {
                return custaddress;
            }

            set
            {
                custaddress = value;
            }
        }

        public string Custpassword
        {
            get
            {
                return custpassword;
            }

            set
            {
                custpassword = value;
            }
        }

        public string Custcity
        {
            get
            {
                return custcity;
            }

            set
            {
                custcity = value;
            }
        }
    }
}

 