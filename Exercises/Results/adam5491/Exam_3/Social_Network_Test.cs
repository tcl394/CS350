using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_350_Exam_3
{
    class Social_Network_Test
    {
        static void Main(string[] args)
        {
            Test_User_Create();
            Test_User_Lookup();
            Test_Add_Friend();
            Test_List_Friends();
            Test_Remove_Friends();
            Test_AddTopic();
            Test_List_Topics();
            Test_RemoveTopic();
            Test_ExportData();
            Test_ImportData();
            Test_Master_Reset_UserInfo();

        }
        public static void Test_User_Create()
        {
            bool success = Social_Network.Person.Create_User("TAdams", "iLoveCats", 1004);
            Debug.Assert(success == true, "User not properly created.");   
        }
        public static void Test_User_Lookup()
        {
            Social_Network.Person person = Social_Network.Person.Lookup_Person(1002);
            Debug.Assert(person != null, "User does not exist.");
        }
        public static void Test_Add_Friend()
        {
            bool success = Social_Network.Friend.Add_Friend(1002, 1003);
            Debug.Assert(success == true, "Failed to add friend.");
        }
        public static void Test_List_Friends()
        {
            Social_Network.Friend.List_Friends(1000);
        }
        public static void Test_Remove_Friends()
        {
            bool success = Social_Network.Friend.Remove_Friend(1002, 1003);
            Debug.Assert(success == true, "Failed to remove friend.");
        }
        public static void Test_AddTopic()
        {
            bool success = Social_Network.Post.AddTopic(1003, "Cats");
            Debug.Assert(success == true, "Failed to add topic.");
        }
        public static void Test_List_Topics()
        {
            Social_Network.Post.List_Topics(1003);
        }
        public static void Test_RemoveTopic()
        {
            bool success = Social_Network.Post.RemoveTopic(1003, "Cats");
            Debug.Assert(success == true, "Failed to remove topic.");
        }
        public static void Test_Master_Reset_UserInfo()
        {
            Social_Network.MasterSystem.MasterReset();
            var csvFileLength = new System.IO.FileInfo("C:/Users/Tyler/source/repos/CS 350 Exam 3/social_network_app/bin/user_list.csv").Length;
            Debug.Assert(csvFileLength == 0, "User list not successfully reset.");
        }
        public static void Test_ExportData()
        {
            bool success = Social_Network.MasterSystem.ExportData("C:/Users/Tyler/Desktop/test.csv");
            Debug.Assert(success == true, "Failed to export data. Check file path.");
        }
        public static void Test_ImportData()
        {
            bool success = Social_Network.MasterSystem.ImportData("C:/Users/Tyler/Desktop/test.csv");
            Debug.Assert(success == true, "Failed to import data. Check file path.");
        }
    }
}
