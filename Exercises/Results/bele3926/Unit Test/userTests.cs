using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unit_Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Test.Tests
{
    [TestClass()]
    public class userTests
    {
        string result1;
        string result2;
        string result3;
              

        [TestMethod()]
        public void test_first_name()
        {

            try
            {
                User fn = new User();
                 result1 = fn.Create_first_name("Abiy");
                Assert.AreEqual("Abiy", result1);
            }
            catch (Exception ex)
            {

                Console.WriteLine("First name not set "+ex);
            }
        }
       

        [TestMethod()]
        public void test_last_name()
        {
            try
            {
                User ln = new User();
                result2 = ln.Create_last_name("Belew");
                Assert.AreEqual("Belew", result2);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Last name is not set"+ex);
            }
        }
        [TestMethod()]
        public void test_user_email()
        {
            try
            {
                User em = new User();
                result3 = em.Create_user_email("abiy21@gmail.com");
                Assert.AreEqual("abiy21@gmail.com", result3);
            }
            catch(Exception ex)
            {

                Console.WriteLine("User name is not set " + ex);
            }
        }
        [TestMethod()]
        public void test_create_user()
        {
            try
            {
                User cu = new User();
                string resu = cu.Create_user(result1, result2, result3);

                Assert.AreEqual("Abiy Belew abiy21@gmail.com", resu);
            }
            catch (Exception ex)
            {

                Console.WriteLine("User name is not set " + ex);
            }
        
        }
        [TestMethod()]
        public void test_create()
        {
            try
            {
                if (result1 != "")
                {
                    Console.WriteLine("First name created");
                }
                else if (result2 != "")
                {
                    Console.WriteLine("Last name created");
                }
                else if (result3 != "")
                {
                    Console.WriteLine("user email created");
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(" Some of user date not created"+ex);
            }

        }

    }
    }
