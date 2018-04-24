using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace service
{
    public class Admin
    {
        private string adminname ;
        private string adminpassword ;
        private string adminaddress;
        private string adminphone;

        public string Adminname
        {
            get
            {
                return adminname;
            }

            set
            {
                adminname = value;
            }
        }

        public string Adminpassword
        {
            get
            {
                return adminpassword;
            }

            set
            {
                adminpassword = value;
            }
        }

        public string Adminaddress
        {
            get
            {
                return adminaddress;
            }

            set
            {
                adminaddress = value;
            }
        }

        public string Adminphone
        {
            get
            {
                return adminphone;
            }

            set
            {
                adminphone = value;
            }
        }
    }
}