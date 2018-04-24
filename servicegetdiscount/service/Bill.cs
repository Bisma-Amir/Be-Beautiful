using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace service
{
    public class Bill
    {
        private int billofproduct;
        private int discountrate = 500;

        public int Billofproduct
        {
            get
            {
                return billofproduct;
            }

            set
            {
                billofproduct = value;
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
        public int calculatediscount(int dis)
        {
            int a = dis;

            if (a >= 3000)
            {

                a= a-Discountrate;
                return a;
            }

            return 0;
        }

    }
}
