using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Test
{
    public class User
    {
        
        static void Main(string[] args)
        {

        }
        public String Create_first_name(string fname)
        {
            return fname;
        }
        public String Create_last_name(string lname)
        {
            return lname;
        }
        public String Create_user_email(string email)
        {
            return email;
        }
        public String Create_user(string fname, string lname, string eamil)
        {
            return fname + " "+ lname +" "+ eamil;
        }

    }
}
