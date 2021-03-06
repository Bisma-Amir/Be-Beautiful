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
        public void Addmakeupartist(string name, string password, string phone, string address,string category,string price)
        {
            makeupArtistDl m = new makeupArtistDl();
            m.Addmakeupartist(name, password, phone, address,category,price);
        }
        public List<Bill> Addbill(string card, string code, string mail)
        {
            BillDL b = new BillDL();
            List<Bill> Billes = new List<Bill>();

            Billes=b.Addbill(card, code, mail);
            return Billes;
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
        public void Additems(string productname, string productcategory, string productcompany, string productprice)
        {
            ProductDL.Additems(productname, productcategory, productcompany, productprice);
        }
        public List<Product> copyproducts()
        {
            ProductDL p = new ProductDL();
            List<Product> m = new List<Product>();
            m=p.copyproducts();
            return m;

        }
        public int calculatediscount(int dis)
        {
            Bill m = new Bill();
            int b = m.calculatediscount(dis);
            return b;
        }
        public List<Product> get_products()
        {
            return ProductDL.products;
        }
        public List<Product> searchbyrange(string name, string range)
        {
            ProductDL p = new ProductDL();
            List<Product> m = new List<Product>();
            m = p.searchbyrange(name,range);
            return m;

        }
        public List<Product> purchased_product(Product d)
        {
            ProductDL p = new ProductDL();
            List<Product> m = new List<Product>();
            m = p.purchased_product(d);
            return m;
        }
        public List<MakeupArtist> sendrequest(MakeupArtist d)
        {
            makeupArtistDl p = new makeupArtistDl();
            List<MakeupArtist> m = new List<MakeupArtist>();
            m = p.sendrequest(d);
            return m;
        }
        public int calculatebill()
        {
            Bill a = new Bill();
            int b = a.calculatebill();
            return b;
        }
       
        public void deleteproduct(string name, string category, string company, string price)
        {
            ProductDL p1 = new ProductDL();
            p1.deleteproduct(name, category, company, price);
           
        }
        public List<MakeupArtist> getmakeupartist()
        {
            return makeupArtistDl.makeupArtists;
        }
        public void mahi(Customer p)
        {

        }
        public List<Customer> addrequestedcustomer(string n)
        {
            //CustomerDl k = new CustomerDl();
            //k.addrequestedcustomer( p);
           return CustomerDl.addrequestedcustomer(n);

        }
        public string commission(string price)
        {
            makeupArtistDl s = new makeupArtistDl();
            string a = s.commission(price);

            return a;

        }
        public List<MakeupArtist> commisionadmin(string name, string price)
        {
            makeupArtistDl p = new makeupArtistDl();
            List<MakeupArtist> m = new List<MakeupArtist>();
            m = p.commisionadmin(name, price);
            return m;
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
