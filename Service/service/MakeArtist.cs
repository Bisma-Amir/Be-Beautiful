using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace service
{
    public class MakeupArtist
    {
        private string makename;
        private string makephone;
        private string makeaddress;
        private string makepassword;

        public string Makename { get => makename; set => makename = value; }
        public string Makephone { get => makephone; set => makephone = value; }
        public string Makeaddress { get => makeaddress; set => makeaddress = value; }
        public string Makepassword { get => makepassword; set => makepassword = value; }
    }
}