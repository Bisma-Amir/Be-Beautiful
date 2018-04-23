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
        }

    }
