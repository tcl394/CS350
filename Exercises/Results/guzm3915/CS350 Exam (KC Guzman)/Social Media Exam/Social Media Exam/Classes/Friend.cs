using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Media_Exam.Classes
{
    public class Friend
    {
        public static List<String> friends = new List<String>();


        public static bool viewFriend()
        {
            try
            {
                string output = "";

                foreach (string f in friends)
                {
                    output += f + ":";
                }
                Console.WriteLine(output);

                return true;
            }
            catch
            {
                return false;
            }

        }

        //Friendship is Magic!
        //Confirms new friend between users
        public static bool newFriendship(string newFriend)
        {
            try
            {
                if (friends.Contains(newFriend))
                {

                }
                else
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

        //When the Magic of Friendship fails...
        //removes friend
        public static bool removeFriendship(string oldFriend)
        {
            try
            {
                if (friends.Contains(oldFriend))
                {
                    friends.Remove(oldFriend);
                }
                else
                {

                }
                return true;
            }
            catch
            {
                return false;
            }

        }
    }
}
