using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace service
{
    public class BillDL
    {
        public static List<Bill> Bills = new List<Bill>();
        public void Addbill(string card, string code, string mail)
        {
            Bill b = new Bill();
            b.Creditcard = card;
            b.Pincode = code;
            b.Email = mail;
            Bills.Add(b);

        }
    }
}