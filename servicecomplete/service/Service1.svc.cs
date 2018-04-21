﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Collections;
using System.Windows;
using System.Resources;
using System.ComponentModel;

namespace service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }
        public void Addadmin(string adminname, string adminpassword, string adminphone, string adminaddress)
        {
            AdminDL m = new AdminDL();
            m.Addadmin( adminname, adminpassword, adminphone, adminaddress);
        }
        public void Addcustomer(string name, string password, string phone, string address)
        {
            CustomerDl m = new CustomerDl();
            m.Addcustomer( name,  password, phone, address);
        }
        public void Addmakeupartist(string name, string password, string phone, string address)
        {
            makeupArtistDl m = new makeupArtistDl();
            m.Addmakeupartist(name, password, phone, address);
        }
        public bool isvalidadmin(string username, string password)
        {
            AdminDL a = new AdminDL();
            bool b = a.Isvalidadmin(username, password);
            return b;
        }
        public bool isvalidcust(string username, string password)
        {
            CustomerDl a = new CustomerDl();
            bool b = a.Isvalidcust(username, password);
            return b;
        }
        public bool isvalidmake(string username, string password)
        {
            makeupArtistDl a = new makeupArtistDl();
            bool b = a.Isvalidmake(username, password);
            return b;
        }






        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
