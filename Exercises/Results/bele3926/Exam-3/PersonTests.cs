using Microsoft.VisualStudio.TestTools.UnitTesting;
using Take_home_exam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Take;

namespace Take_home_exam.Tests
{
    [TestClass()]
    public class PersonTests
    {

        [TestMethod()]
        public void RegistrationTest()
        {
            try
            {
                Boolean result = false;
                Person person = new Person();
                person.E_mail = "abiy@gmail.com";
                person.First_Name = "Endale";
                person.Last_Name = "Amde";
                person.Pass_word = "abiy";
                result = person.Registration();
                Assert.AreEqual("true", result);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Somethig wrong " + ex);
            }
        }

        [TestMethod()]
        public void LoginTest()
        {
            try
            {
                Boolean result = false;
                Person person = new Person();
                result = person.Login("abex", "123");
                Assert.AreEqual("true", result);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Somethig wrong " + ex);
            }
        }
       
    }
}