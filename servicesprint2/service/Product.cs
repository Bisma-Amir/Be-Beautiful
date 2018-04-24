using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
namespace service
{
    [DataContract]
    public class Product
    {
        private string productname;
        private string productcategory;
        private string productcompany;
        private string productprice;
        private bool isselect;

        [DataMember]
        public string Productname
        {
            get
            {
                return productname;
            }

            set
            {
                productname = value;
            }
        }
        [DataMember]
        public string Productcompany
        {
            get
            {
                return productcompany;
            }

            set
            {
                productcompany = value;
            }
        }




        [DataMember]
        public string Productcategory
        {
            get
            {
                return productcategory;
            }

            set
            {
                productcategory = value;
            }
        }
        [DataMember]
        public string Productprice
        {
            get
            {
                return productprice;
            }

            set
            {
                productprice = value;
            }
        }

        

        [DataMember]
        public bool Isselect { get => isselect; set => isselect = value; }
    }
}