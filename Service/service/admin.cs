using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace service
{
    public class Admin
    {
        private string adminname ;
        private string adminpassword;
        private string adminphone;
        private string adminaddress;

        public string Adminname { get => adminname; set => adminname = value; }
        public string Adminpassword { get => adminpassword; set => adminpassword = value; }
        public string Adminphone { get => adminphone; set => adminphone = value; }
        public string Adminaddress { get => adminaddress; set => adminaddress = value; }
    }
}