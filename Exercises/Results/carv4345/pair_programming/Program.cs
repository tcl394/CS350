using System;
using System.Threading;

namespace unitTest
{
    public class User
    {
        public string First { get; set; }
        public string Last { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public int Uid { get; }
        public User(String first, String last, String email)
        {
            Random rnd = new Random();
            First = first;
            Last = last;
            Email = email;
            Name = first + " " + last;
            Uid = rnd.Next(1000, 10000);
        }
    }
   
    class Program
    {

        public void Test_create()
        {
            User test = new User("Jack", "Johnson", "jj@myMan.com"); // Instantiates properly.

            Console.WriteLine("The users name is " + test.Name);
            Thread.Sleep(1000);
        }


        static void Main()
        {
            

        }
    }

}