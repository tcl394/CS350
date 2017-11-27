using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_350_Exam_3
{
    class Social_Network
    {
        public class Person
        {
            public string UserName { get; set; }
            public string Password { get; set; }
            public int UserID { get; set; }
            public List<int> Friends { get; set; }
            public List<string> Posts { get; set; }
            public static bool Create_User(String UserName, String Password, int ID)
            {
                try
                {
                    Person person = new Person();
                    person.UserName = UserName;
                    person.Password = Password;
                    person.UserID = ID;
                    string[] personInfo = { person.UserID.ToString(), person.UserName, person.Password };
                    System.IO.File.AppendAllText(@"C:\Users\Tyler\source\repos\CS 350 Exam 3\social_network_app\bin\user_list.csv", personInfo[0] + "," + personInfo[1] + "," + personInfo[2] + "\n");
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            public static Person Lookup_Person(int UserID)
            {
                Person person = new Person();
                var Lines = File.ReadLines("C:/Users/Tyler/source/repos/CS 350 Exam 3/social_network_app/bin/user_list.csv");
                foreach (var line in Lines)
                {
                    if (line.Split(',')[0].Equals(UserID))
                    {
                        person.UserID = Convert.ToInt32(line.Split(',')[0]);
                        person.UserName = line.Split(',')[1];
                        person.Password = line.Split(',')[2];
                        person.Friends = new List<int> { };
                        person.Friends.Add(Convert.ToInt32(line.Split(',')[3]));
                        return person;
                    }
                }
                return person;
            }
        }
        public class Friend
        {
            public static bool Add_Friend(int FirstID, int SecondID)
            {
                try
                {
                    Person PersonOne = Person.Lookup_Person(FirstID);
                    Person PersonTwo = Person.Lookup_Person(SecondID);
                    PersonOne.Friends = new List<int> { };
                    PersonTwo.Friends = new List<int> { };
                    PersonOne.Friends.Add(SecondID);
                    PersonTwo.Friends.Add(FirstID);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            public static List<int> List_Friends(int LookupID)
            {
                Person person = Person.Lookup_Person(LookupID);
                return person.Friends;
            }
            public static bool Remove_Friend(int FirstID, int SecondID)
            {
                try
                {
                    Person PersonOne = Person.Lookup_Person(FirstID);
                    Person PersonTwo = Person.Lookup_Person(SecondID);
                    PersonOne.Friends = new List<int> { };
                    PersonTwo.Friends = new List<int> { };
                    PersonOne.Friends.Remove(SecondID);
                    PersonTwo.Friends.Remove(FirstID);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
        public class Post
        {
            public static List<string> List_Topics(int UserID)
            {
                Person person = new Person();
                person = Person.Lookup_Person(UserID);
                return person.Posts;
            }
            public static bool AddTopic(int UserID, string Content)
            {
                try
                {
                    Person person = new Person();
                    person = Person.Lookup_Person(UserID);
                    person.Posts = new List<string> { };
                    person.Posts.Add(Content);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            public static bool RemoveTopic(int UserID, string Content)
            {
                try
                {
                    Person person = new Person();
                    person = Person.Lookup_Person(UserID);
                    person.Posts = new List<string> { };
                    person.Posts.Remove(Content);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
        public class MasterSystem
        {
            public static void MasterReset()
            {
                System.IO.File.WriteAllText(@"C:\Users\Tyler\source\repos\CS 350 Exam 3\social_network_app\bin\user_list.csv", string.Empty);
            }
            public static bool ExportData(String filepath)
            {
                try
                {
                    File.Copy(@"C:\Users\Tyler\source\repos\CS 350 Exam 3\social_network_app\bin\user_list.csv", filepath, true);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            public static bool ImportData(String filepath)
            {
                try
                {
                    File.Copy(filepath, @"C:\Users\Tyler\source\repos\CS 350 Exam 3\social_network_app\bin\user_list.csv", true);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
    }
}
