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
        private int discountrate=500;

        public int Billofcustomer { get => billofcustomer; set => billofcustomer = value; }
        public int Discountrate { get => discountrate; set => discountrate = value; }

        public int calculatebill(Product p)
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