using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace service
{
    public class AdminDL
    {
        public static List<Admin>Admins = new List<Admin>();

        public bool Isvalidadmin(string username, string password)
        {
            bool iffound = false;
            foreach (Admin c in AdminDL.Admins)
            {
                if (c.Adminname ==username  && c.Adminpassword == password)
                    iffound = true;
            }
            return iffound;

        }
    }
}