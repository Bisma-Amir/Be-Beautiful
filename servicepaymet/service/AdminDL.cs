using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using System.Runtime.Serialization;
namespace service
{
    [DataContract]
    public class AdminDL
    {
        [DataMember]
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
        public bool Isvalidadmin(string username, string password)
        {
            bool iffound = false;
            foreach (Admin c in AdminDL.Admins)
            {
                if (c.Adminname == username && c.Adminpassword == password)
                    iffound = true;
            }
            return iffound;

        }
    }
}