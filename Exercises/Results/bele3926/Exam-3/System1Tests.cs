using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Take;

namespace Take_home_examTests
{
    [TestClass()]
    public class System1Tests
    {
        [TestMethod()]
        public void Reset_tableTest()
        {
            try
            {
                Boolean result = false;
                System1 post = new System1();
                post.Table_Name = "Request";
                result = post.Reset_table();
                Assert.AreEqual("true", result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Somethig wrong " + ex);
            }
        }
    }
}
