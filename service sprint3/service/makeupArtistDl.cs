﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Windows;
using System.Collections;

namespace service
{
    public class makeupArtistDl
    {
        public static List<MakeupArtist> makeupArtists = new List<MakeupArtist>();
        public void Addmakeupartist(string name, string password, string phone, string address)
        {
            MakeupArtist m1 = new MakeupArtist();
            m1.Makename = name;
            m1.Makepassword = password;
            m1.Makephone = phone;
            m1.Makeaddress = address;
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
    }
}