using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Media_Exam
{
    public class Person
    {
        //Public variables. User ID, post stuff, and friends. Posts and Friends are lists.
        public string userIdentification
        {
            get;
            set;
        }
        public string password
        {
            get;
            set;
        }
        public static List<int>posts
        {
            get;
            set;
        }
        public static List<string>friends
        {
            get;
            set;
        }

        //friend control classes
        public static bool addFriend(string newFriend)
        {
            try
            {
                if (friends.Contains(newFriend))
                {
                    return true;
                }
                else //if it doesnt contain the friend
                {
                    friends.Add(newFriend);
                }
                return true;    
            }
            catch
            {
                return false;
            }
           
        }
        public static bool removeFriend(string soonToBeNotAFriend)
        {
            try
            {
                if (friends.Contains(soonToBeNotAFriend))
                {
                    friends.Remove(soonToBeNotAFriend);
                    //And now, as fortold by the variable profecy, he is no longer a friend
                }
                return true;
            }
            catch
            {
                return false;
            }

        }

        //Post control classes
        public static bool addPost(int id)
        {
            try
            {
                if (posts.Contains(id))
                {
                    return true;
                }
                else //if it doesnt contain the post ID
                {
                    posts.Add(id);
                }
                return true;   
            }
            catch
            {
                return false;
            }
           
        }
        public static bool removePost(int id)
        {
            try
            {
                if (posts.Contains(id))
                {
                    posts.Remove(id);
                }
                //Begone, post!
                return true;    
            }
            catch
            {
                return false;
            }
            
        }
    }
}
