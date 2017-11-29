using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CS350_BackendAPI
{
    class Test
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Test Case Results: " + RunTests());
            Thread.Sleep(10000);
        }
        public static bool RunTests()
        {
            //User Creation Test
            try
            {
                LoginRegistration.RegisterUser("Rafi", "password", "NotRafi", "test@test.com");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return false;
            }

            //User Login Test
            try
            {
                LoginRegistration.Login("Rafi", "password");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return false;
            }

            //Get Friends Method Test
            try
            {
                Database.GetFriends(7).Count();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return false;
            }

            //Add Friendship Test
            try
            {
                Database.AddFriendship(2, 7);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return false;
            }

            //Remove Friendship Test
            try
            {
                Database.RemoveFriendship(2, 7);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return false;
            }

            //Get Posts Test
            try
            {
                Database.GetPosts(7);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return false;
            }

            //Add Post and Remove Post Test
            try
            {
                Post post = Database.AddPost(7, "test", "sample");
                Database.RemovePost(post.postID);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return false;
            }

            //Remove All Test
            try
            {
                Database.ClearAll();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return false;
            }
            return true;
        }
    }
}
