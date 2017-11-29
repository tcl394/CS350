using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Social_Media_Exam.Classes
{
    public class SystemFunc
    {

        public static List<Person> people = new List<Person>();
        public static List<String> posts = new List<String>();
        public static List<String> friends = new List<String>();

        public static bool resetData()
        {
            try
            {
                File.Delete("data.csv");
                people.Clear();
                return true;
            }
            catch
            {
                return false;
            }

        }
        public static bool exportData()
        {
            try
            {
                string output = "";
                foreach (Person p in people)
                {
                    string posts = string.Join(":", p.posts);
                    string friends = string.Join(":", p.friends);
                    output += p.userIdentification + "," + p.password + "," + posts + "," + friends + Environment.NewLine;

                }
                File.WriteAllText("data.csv", output);
                return true;
            }
            catch
            {
                return false;
            }

        }
        //reads data in
        public static bool importData()
        {
            try
            {
                foreach (string line in File.ReadAllLines("data.csv"))
                {
                    string[] linesplit = line.Split(',');
                    string userID = linesplit[0];
                    string password = linesplit[1];
                    List<int> postID = new List<int>();
                    List<string> friends = linesplit[3].Split(':').ToList<string>();
                    foreach (string id in linesplit[2].Split(':'))
                    {
                        postID.Add(Convert.ToInt32(id));
                    }

                    people.Add(new Person()
                    {
                        userIdentification = userID,
                        password = password,
                        posts = postID,
                        friends = friends
                    });

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
