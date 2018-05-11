using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
namespace service
{
    [DataContract]
    public class Customer
    {
        private string custname;
        private string custphone;
        //[DataMember]
        private string custaddress;
        //[DataMember]
        private string custpassword;
        //[DataMember]
        private string custcity;


        [DataMember]

        public string Custname
        {
            get
            {
                return custname;
            }

            set
            {
                custname = value;
            }
        }
        [DataMember]
        public string Custphone
        {
            get
            {
                return custphone;
            }

            set
            {
                custphone = value;
            }
        }
        [DataMember]
        public string Custaddress
        {
            get
            {
                return custaddress;
            }

            set
            {
                custaddress = value;
            }
        }
        [DataMember]
        public string Custpassword
        {
            get
            {
                return custpassword;
            }

            set
            {
                custpassword = value;
            }
        }
        [DataMember]
        public string Custcity
        {
            get
            {
                return custcity;
            }

            set
            {
                custcity = value;
            }
        }
    }
}

 