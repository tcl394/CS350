using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Media_Exam.Classes
{
    public class Post
    {
        public static int postID
        {
            get; set;
        }
        public string content
        {
            get; set;
        }
        public static List<String> topic = new List<String>();

        public static bool listTopic()
        {
            try
            {
                string output = "";

                foreach (string t in topic)
                {
                    output += t + ":";
                }
                Console.WriteLine(output);

                return true;
            }
            catch
            {
                return false;
            }
            
        }
        public static bool addTopic(string newTopic)
        {
            try
            {
                if (topic.Contains(newTopic))
                {

                }
                else
                {
                    topic.Add(newTopic);
                }
                return true;
            }
            catch
            {
                return false;
            }

        }
        public static bool removeTopic(string removedTopic)
        {
            try
            {
                if (topic.Contains(removedTopic))
                {
                    topic.Remove(removedTopic);
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
