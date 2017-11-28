using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Media_Newby
{
    //Social_Media - Exam 3
    //Christopher Newby
    //CS 350 - Fall 2017
    //Professor Mark Seaman

    class Person
    {
        //Encapsulate class variables
        private int person_ID { get; set; }
        private string user_name { get; set; }
        private string user_password { get; set; }
        private string first_name { get; set; }
        private string last_name { get; set; }


        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@//
        //@@@@@@@@@@@@@@@@@@@@@@@@@@ API FUNCTION CALLS BELOW THIS LINE @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@//
        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@//

        //Public constructor
        public Person(int p_ID, string p_name, string p_pw, string p_fname, string p_lname)
        {
            person_ID = p_ID;
            user_name = p_name;
            user_password = p_pw;
            first_name = p_fname;
            last_name = p_lname;
        }


        //Get methods for breaking person objects into parts for saving in files
        public int Get_Person_ID()
        {
            return person_ID;
        }
        public string Get_Username()
        {
            return user_name;
        }
        public string Get_PW()
        {
            return user_password;
        }
        public string Get_FN()
        {
            return first_name;
        }
        public string Get_LN()
        {
            return last_name;
        }

        //Login function (EXTRA)
        public bool Person_Login(int login_p_ID, string login_p_pw)
        {
            if (Data_Store.person_list[login_p_ID - 1].user_password.Equals(login_p_pw))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@//
        //@@@@@@@@@@@@@@@@@@@@@@@@@@ API FUNCTION CALLS ABOVE THIS LINE @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@//
        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@//


        //--------------------------------------------------------------------------------------------//
        //--------------------- PRIVATE CLASS FUNCTION CALLS BELOW THIS LINE -------------------------//
        //--------------------------------------------------------------------------------------------//

        //Add person to list
        private void Add_Person_To_List(Person p)
        {
            Data_Store.person_list.Add(p);
        }

        //--------------------------------------------------------------------------------------------//
        //--------------------- PRIVATE CLASS FUNCTION CALLS ABOVE THIS LINE -------------------------//
        //--------------------------------------------------------------------------------------------//
    }
}
