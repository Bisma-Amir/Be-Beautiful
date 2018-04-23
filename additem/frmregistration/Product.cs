using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmregistration
{
    class Product
    {
        private string productname;
        private string productcompany;
        private string productcategory;
        private string productprice;


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
    }
}
