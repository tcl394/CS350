using Microsoft.VisualStudio.TestTools.UnitTesting;
using Take;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Take.Tests
{
    [TestClass()]
    public class FriendTests
    {
        [TestMethod()]
        public void Send_Friend_requestTest()
        {

            try
            {
                Boolean result = false;
                Friend friend = new Friend();
                result = friend.Send_Friend_request("abex@gmail.com");
                Assert.AreEqual("true", result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Somethig wrong " + ex);
            }
        }
        [TestMethod()]
        public void NoteficationTest()
        {

            try
            {
                Boolean result = false;
                Friend friend = new Friend();
                //result = friend.Notefication("abex")
                Assert.AreEqual("true", result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Somethig wrong " + ex);
            }
        }


        [TestMethod()]
        public void Remove_FriendshipTest()
        {

            try
            {
                Boolean result = false;
                Friend friend = new Friend();
                result = friend.Remove_Friendship();
                Assert.AreEqual("true", result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Somethig wrong " + ex);//Confirm_Friendship_request
            }
        }
        [TestMethod()]
        public void Confirm_Friendship_requestTest()
        {

            try
            {
                Boolean result = false;
                Friend friend = new Friend();
                result = friend.Confirm_Friendship_request("abex","ende");
                Assert.AreEqual("true", result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Somethig wrong " + ex);//List_Friends
            }
        }
        [TestMethod()]
        public void List_FriendsTest()
        {

            try
            {
                Boolean result = false;
                Friend friend = new Friend();
                result = friend.List_Friends("abex");
                Assert.AreEqual("true", result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Somethig wrong " + ex);//Remove_Friend_request
            }
        }
        [TestMethod()]
        public void Remove_Friend_requestTest()
        {

            try
            {
                Boolean result = false;
                Friend friend = new Friend();
                result = friend.Remove_Friend_request("abex");
                Assert.AreEqual("true", result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Somethig wrong " + ex);
            }
        }
    }
}