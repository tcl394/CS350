using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;

namespace Social_Media_Newby
{
    //Social_Media - Exam 3
    //Christopher Newby
    //CS 350 - Fall 2017
    //Professor Mark Seaman

    class Data_Store
    {
        //Data_Store lists & arrays below are local storage

        //Non-test local storage of persons, friends and posts
        public static List<Person> person_list = new List<Person>();

        public static List<Friend> friends_list = new List<Friend>();

        public static List<Post> posts_list = new List<Post>();


        //Test pass/fail results storage for each module
        public static string[] person_test_results = new string[2];

        public static string[] friend_test_results = new string[3];

        public static string[] post_test_results = new string[3];

        public static string[] system_mod_test_results = new string[3];


        //Temporary test lists
        public static List<Person> person_list_test = new List<Person>();

        public static List<Friend> friend_list_test = new List<Friend>();

        public static List<Post> post_list_test = new List<Post>();
    }
}
