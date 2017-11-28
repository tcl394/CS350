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
    public class PostTests
    {
        [TestMethod()]
        public void Add_TopicTest()
        {
            try
            {
                Boolean result = false;
                Post post = new Post();
                post.Topic = " Bezabih and seblework";
                post.Body = "Fikir Eske Mekabir";
                result = post.Add_topics("abex");
                Assert.AreEqual("true", result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Somethig wrong " + ex);
            }
        }
        [TestMethod()]
        public void List_topicsTest()
        {
            try
            {
                Boolean result = false;
                Post post = new Post();
                result = post.List_topics();
                Assert.AreEqual("true", result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Somethig wrong " + ex);
            }
        }
        [TestMethod()]
        public void Remove_topicsTest()
        {
            try
            {
                Boolean result = false;
                Post post = new Post();
                post.Topic = "fikir eske mekabir";
                result = post.Remove_topics();
                Assert.AreEqual("true", result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Somethig wrong " + ex);
            }
        }
    }
}