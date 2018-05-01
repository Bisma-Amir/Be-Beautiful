using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using System.Runtime.Serialization;
namespace service
{
    [DataContract]
    public class ProductDL
    {
        [DataMember]
        public static List<Product> products = new List<Product>();
        [DataMember]
        public static List<Product> purchasedproduct = new List<Product>();

        public static void Additems(string productname, string productcategory, string productcompany, string productprice)
            {
                Product p = new Product();
                p.Productname = productname;
                p.Productcompany = productcompany;
                p.Productprice = productprice;
                p.Productcategory = productcategory;
                products.Add(p);
            }
            public List<Product> copyproducts()
            {
                List<Product> m = new List<Product>();
                foreach(Product p in ProductDL.products)
                {
                    m.Add(p);
                }
                return m;
            }
        public List<Product> searchbyrange(string name, string range)
        {
            List<Product> mw = new List<Product>();
            int rang = Int32.Parse(range);
            range = rang.ToString();
            foreach(Product p in ProductDL.products)
            {
                int price = Int32.Parse(p.Productprice);
                if (p.Productname == name && price<= rang)
                    mw.Add(p);
            }
            return mw;
        }
        public void updatedproducts(string productname)
            {
                foreach(Product p in ProductDL.products)
                {
                    if (p.Productname==productname)
                    {
                        products.Remove(p);
                    }
                }
            }
        
        public List<Product> purchased_product(Product d)
        {
            purchasedproduct.Add(d);
            return purchasedproduct;
        }
       
        public void deleteproduct(string name,string category,string company,string price)
        {
            Product p = new Product();
            p.Productname = name;
            p.Productcompany = company;
            p.Productprice = price;
            p.Productcategory = category;
            purchasedproduct.Remove(p);
        }
    }

    }
