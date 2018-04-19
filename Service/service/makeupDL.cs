using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

namespace service
{
    public class MAkeupDl
    {
        public static List<MakeupArtist> Makeup = new List<MakeupArtist>();
        public bool Isvalidmake(string username, string password)
        {
            bool iffound = false;
            foreach (MakeupArtist m in MAkeupDl.Makeup)
            {
                if (m.Makename == username && m.Makepassword == password)
                    iffound = true;
            }
            return iffound;
        }
    }
}