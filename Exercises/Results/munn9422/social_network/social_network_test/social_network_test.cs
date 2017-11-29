using System;
using social_network;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Collections.Generic;


//Use Visual Studio's Test Explorer to run all tests
//to open the test explorer panel in visual studio:
//Test(top bar) > Windows > Test Explorer

namespace social_network_test
{
    [TestClass]
    public class social_network_test
    {

        [TestMethod]
        public void TestAll()
        {
            TestSaveThenLoadFile();
            TestClearAllData();
            TestRegisterNewUser();
            TestAuthenticate();
            TestComposePost();
            TestViewPost();
            TestViewAllUsers();
            TestSendViewRespondFriendRequest();
        }

        [TestMethod]
        public void TestSaveThenLoadFile()
        {
            Person testUser = new Person
            {
                Username = "testUser",
                Password = "testPass",
                FirstName = "David",
                LastName = "Munn",
                Wall = new List<Post>(),
                Friends = new List<string>(),
                FriendRequestsReceived = new List<string>(),
                FriendRequestsSent = new List<string>()
            };

            social_network.System.RegisteredUsers.Add(testUser);
            social_network.System.SaveToFile();
            social_network.System.RegisteredUsers = null;
            social_network.System.LoadFromFile();

            Assert.AreEqual(testUser.Username, social_network.System.RegisteredUsers[0].Username);
            Assert.AreEqual(testUser.Password, social_network.System.RegisteredUsers[0].Password);
            social_network.System.ClearAllData();
        }

        [TestMethod]
        public void TestClearAllData()
        {
            string path = "../../../social_network/data";
            if (!File.Exists(path + "test.txt"))
            { File.Create(path + "test.txt"); } 
            string[] directoryBefore = Directory.GetFiles(path);
            social_network.System.ClearAllData();
            string[] directoryAfter = Directory.GetFiles(path);
            Assert.AreNotEqual(directoryBefore, directoryAfter);
        }

        [TestMethod]
        public void TestRegisterNewUser()
        {
            social_network.System.RegisterNewUser("cs350user", "cs350pass", "firstname", "lastname");
            Assert.AreEqual("cs350user", social_network.System.RegisteredUsers[0].Username);
            social_network.System.ClearAllData();
        }

        [TestMethod]
        public void TestAuthenticate()
        {
            User ClientUser = new User(null);
            social_network.System.RegisterNewUser("cs350user", "cs350pass", "firstname", "lastname");
            ClientUser.Authenticate("cs350user", "cs350pass");
            Assert.AreEqual("cs350user", ClientUser.Self.Username);
            social_network.System.ClearAllData();
        }

        [TestMethod]
        public void TestComposePost()
        {
            User ClientUser = new User(null);
            social_network.System.RegisterNewUser("cs350user", "cs350pass", "firstname", "lastname");
            ClientUser.Authenticate("cs350user", "cs350pass");
            ClientUser.ComposePost("subject line here.", "body content here.");
            Assert.AreEqual("subject line here.", ClientUser.Self.Wall[0].Subject);
            social_network.System.ClearAllData();
        }

        [TestMethod]
        public void TestViewPost()
        {
            User ClientUser = new User(null);
            social_network.System.RegisterNewUser("cs350user", "cs350pass", "firstname", "lastname");
            social_network.System.RegisterNewUser("notfriend", "notfriend", "not", "friend");

            //users can view their own posts.
            ClientUser.Authenticate("notfriend", "notfriend");
            ClientUser.ComposePost("subject line here.", "body content here.");

            //might fail on the off chance that the current minute advances betweem when the original test post
            //made above and the following testpost's time is set below.
            string testPost = String.Format("by: notfriend\nat: {0}, {1}\nsubject: subject line here.\nmessage: body content here.", 
            DateTime.Now.ToShortTimeString(), DateTime.Now.ToShortDateString());
            Assert.AreEqual(testPost, ClientUser.ViewPost(ClientUser.Self.Wall[0]));

            //users see error message if they try to look at the wall of someone who is not their friend.
            ClientUser.Authenticate("cs350user", "cs350pass");
            Assert.AreEqual("Access not allowed. You must be friends with this user to see their wall.", 
                ClientUser.ViewPost(social_network.System.RegisteredUsers[1].Wall[0]));
            social_network.System.ClearAllData();
        }

        [TestMethod]
        public void TestViewAllUsers()
        {
            User ClientUser = new User(null);
            social_network.System.RegisterNewUser("cs350user", "cs350pass", "firstname", "lastname");
            social_network.System.RegisterNewUser("friend", "friend", "friendy", "friend");
            ClientUser.Authenticate("cs350user", "cs350pass");

            ClientUser.ViewAllUsers();
            social_network.System.ClearAllData();
        }

        [TestMethod]
        public void TestSendViewRespondFriendRequest()
        {
            User ClientUser = new User(null);
            social_network.System.RegisterNewUser("cs350user", "cs350pass", "firstname", "lastname");
            social_network.System.RegisterNewUser("friend", "friend", "friendy", "friend");

            ClientUser.Authenticate("cs350user", "cs350pass");
            ClientUser.SendFriendRequest(social_network.System.RegisteredUsers[1]);
            Assert.AreEqual("Friend requests you have sent: \nfriend, friendy, friend\n", ClientUser.ViewSentFriendRequests());

            ClientUser.Authenticate("friend", "friend");
            Assert.AreEqual("Friend requests sent to you: \ncs350user, firstname, lastname\n", ClientUser.ViewReceivedFriendRequests());
            ClientUser.RespondToFriendRequest(true, social_network.System.RegisteredUsers[0]);

            Assert.AreEqual("Friend List: \ncs350user, firstname, lastname\n", ClientUser.ViewFriends());
            social_network.System.ClearAllData();
        }
    }
}
