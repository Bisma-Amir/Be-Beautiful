using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bebeautiful
{
    class Admin
    {
        private string adminname = "Maham";
        private string adminpassword="123";
        

        public string Adminname { get => adminname; set => adminname = value; }
        public string Adminpassword { get => adminpassword; set => adminpassword = value; }
       /*public void login(string n,string phone,string address,string pass)
        {
            adminname = n;
            adminphone = phone;
            Adminpassword = address;
            Adminpassword = pass;
        }*/
    }
    
}
