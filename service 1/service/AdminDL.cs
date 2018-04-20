using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

namespace service
{
    public class AdminDL
    {
        public static List<Admin> Admins = new List<Admin>();
        public void Addadmin(string adminname,string adminpassword,string adminphone,string adminaddress)
        {
            Admin m = new Admin();
            m.Adminname = adminname;
            m.Adminpassword = adminpassword;
            m.Adminphone = adminphone;
            m.Adminaddress = adminaddress;
            Admins.Add(m);


        }
    }
}