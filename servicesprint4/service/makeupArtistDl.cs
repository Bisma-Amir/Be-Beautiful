using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Windows;
using System.Collections;
using System.Runtime.Serialization;

namespace service
{
    [DataContract]
    public class makeupArtistDl
    {
        [DataMember]
        public static List<MakeupArtist> makeupArtists = new List<MakeupArtist>();

        [DataMember]
        public static List<MakeupArtist> send_request = new List<MakeupArtist>();
        public List<MakeupArtist> commisionadmins= new List<MakeupArtist>();

        public void Addmakeupartist(string name, string password, string phone, string address, string category,string price)
        {
            MakeupArtist m1 = new MakeupArtist();
            m1.Makename = name;
            m1.Makepassword = password;
            m1.Makephone = phone;
            m1.Makeaddress = address;
            m1.Makecategory = category;
            m1.Price = price;
            makeupArtists.Add(m1);
        }
        public bool Isvalidmake(string username, string password)
        {
            bool iffound = false;
            foreach (MakeupArtist m in makeupArtistDl.makeupArtists)
            {
                if (m.Makename == username && m.Makepassword == password)
                    iffound = true;
            }
            return iffound;
        }
        public List<MakeupArtist> getmakeupartist()
        {
            return makeupArtists;

        }
        public List<MakeupArtist> sendrequest(MakeupArtist p)
        {
            send_request.Add(p);
            return send_request;
        }
        public string commission(string price)
        {
            int a;
            int prices = Int32.Parse(price);
            a = 1/10 * prices;
            string ab = a.ToString();
            return ab;
            
            
        }
        public List<MakeupArtist> commisionadmin(string name,string price)
        {
            MakeupArtist m1 = new MakeupArtist();
            m1.Makename = name;
            m1.Price = price;
            commisionadmins.Add(m1);
            return commisionadmins;
        }
    }
}