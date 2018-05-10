using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace service
{
    [DataContract]
    public class Bill
    {
        [DataMember]
        private int billofcustomer;
        private int discountrate = 500;
        private string creditcard;
        private string pincode;
        private string email;
        

        public int Billofcustomer
        {
            get
            {
                return billofcustomer;
            }

            set
            {
                billofcustomer = value;
            }
        }

        public int Discountrate
        {
            get
            {
                return discountrate;
            }

            set
            {
                discountrate = value;
            }
        }

        public string Creditcard
        {
            get
            {
                return creditcard;
            }

            set
            {
                creditcard = value;
            }
        }

        

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Pincode
        {
            get
            {
                return pincode;
            }

            set
            {
                pincode = value;
            }
        }

        public int calculatebill()
        {
           
            foreach (Product pro in ProductDL.purchasedproduct)
            {
                int price = int.Parse(pro.Productprice);
                Billofcustomer = Billofcustomer + price;

            }
            return Billofcustomer;
        }
        public int calculatediscount(int dis)
        {
            int a = dis;

            if (a >= 3000)
            {

                a = a - Discountrate;
                return a;
            }

            return 0;
        }
    }
}