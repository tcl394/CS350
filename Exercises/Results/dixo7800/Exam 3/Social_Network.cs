using CS_350_Exam_3;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CS_350_Exam_3_Final_Version
{
    class Social_Network
    {
        static void Main(string[] args)
        {
            //This must be run everytime.
            Social_Networking_System sys = new Social_Networking_System();
            sys.ResetData();


            Social_Network_Test.AllTests();
        }
    }

    class Friend
    {
        //maybe the person should have a list of friends of type friend
        List<string> Friends = new List<string>();

        public void ListFriends()
        {
            Friends = Tools.ReadFileSplitNewLine(Social_Networking_System.friendsFilePath);

            /*foreach (string f in friendsList)
            {
                //Console.WriteLine(f);
                Friends.Add(f);
            }*/

            foreach(string f in Friends)
            {
                Console.WriteLine(f);
            }

        }

        public void AddFriendship(Person one, Person two)
        {
            //Console.WriteLine("Username: " + one.Username);
            Friends.Add(one.Username + "," + two.Username);

            string line = one.Username + "," + two.Username;

            Console.WriteLine("Friendship " + line + " added");

            /*foreach(string s in Friends)
            {
                Console.WriteLine(s);
            }*/

            Tools.WriteFile(Social_Networking_System.friendsFilePath, line);


        }

        public void RemoveFriendship(Person one, Person two)
        {
            Friends = Tools.ReadFileSplitNewLine(Social_Networking_System.friendsFilePath);

            Friends.Remove(one.Username + "," + two.Username + "\r");
            Friends.Remove(two.Username + "," + one.Username + "\r");

            string allRemainingFriends = "";

            foreach(string f in Friends)
            {
                allRemainingFriends = allRemainingFriends + f + "\n";
            }

            Tools.WriteNotAppendingFile(Social_Networking_System.friendsFilePath, allRemainingFriends);

            Console.WriteLine("Freindship " + one.Username + "," + two.Username + " removed");

        }
    }

    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }


        public void Register(string fname, string lname, string email, string uname, string pw)
        {
            FirstName = fname;
            LastName = lname;
            Email = email;
            Username = uname;
            Password = pw;

            AddUser();

        }

        public void Login(string uname, string pw)
        {
            Username = uname;
            Password = pw;

            //Console.WriteLine(Username);
            //Console.WriteLine(Password);

            List<string> usersfile = Tools.ReadFileSplitComma(Social_Networking_System.PersonFilePath);

            List<int> needsRemoval = new List<int>();

            foreach(string u in usersfile)
            {
                if(u == "" || u == null)
                {
                    needsRemoval.Add(usersfile.IndexOf(u));
                }
            }

            foreach(int n in needsRemoval)
            {
                usersfile.RemoveAt(n);
            }

            /*foreach(string r in usersfile)
            {
                Console.WriteLine(r);
            }*/

            bool userFound = false;
            bool passFound = false;

            for (int i = 3; i < usersfile.Count; i = i + 5)
            {
                string test = usersfile[i];
                //Console.WriteLine(test + " " + Username);
                if (test == Username)
                {
                    //Console.WriteLine("User exists");
                    userFound = true;
                    break;
                }
            }

            for (int i = 4; i < usersfile.Count; i = i + 5)
            {
                string test = usersfile[i];
                //Console.WriteLine(test + " " + Password);
                if (test == Password)
                {
                    //Console.WriteLine("Password found");
                    passFound = true;
                    break;
                }
            }

            if (userFound == true && passFound == true)
            {
                Console.WriteLine("Successful Login");
            }
            else
            {
                Console.WriteLine("Login failed");
            }

        }

        private void AddUser()
        {

            string line = FirstName + "," + LastName + "," + Email + "," + Username + "," + Password;

            Tools.WriteFile(Social_Networking_System.PersonFilePath, line);

            Console.WriteLine("Successful Registration!");
        }
    }

    class Post
    {
        public string Topic { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Author { get; set; }


        public void postWarning()
        {
            Console.WriteLine("\nPlease do not have any commas in your topic, your title, or your body. \nOtherwise errors will occur. Thank you for your cooperation.\nEnter to Continue\n");
            Console.ReadKey();
        }
        public string ListTopics()
        {
            List<string> posts = Tools.ReadFileSplitComma(Social_Networking_System.PostFilePath);

            List<string> topics = new List<string>();

            string allTopics = "";

            for (int i = 0; i < posts.Count; i = i + 4)
            {
                if (posts[i] == null || posts[i] == "")
                {
                    break;
                }
                string top = posts[i];
                string title = posts[i + 1];
                string tt = top + "," + title;
                topics.Add(tt);
            }

            foreach (string t in topics)
            {
                allTopics = allTopics + t + "\n";
            }

            return allTopics;
        }

        public void AddTopic(Person p, string topic, string title, string body)
        {

            postWarning();

            if (topic.Contains(",") || title.Contains(",") || body.Contains(","))
            {
                Console.WriteLine("Error");
                return;
            }

            Topic = topic;
            Title = title;
            Body = body;
            Author = p.Username;

            string line = Topic + "," + Title + "," + Body + "," + Author;

            Tools.WriteFile(Social_Networking_System.PostFilePath, line);

            Console.WriteLine("Topic added");
        }

        public void RemoveTopic(Person p, string topic, string title)
        {
            Topic = topic;
            Title = title;
            Author = p.Username;

            List<string> posts = Tools.ReadFileSplitComma(Social_Networking_System.PostFilePath);

            for (int i = 0; i < posts.Count; i = i + 4)
            {
                if (posts[i] == "")
                {
                    break;
                }
                string top = posts[i];
                string tit = posts[i + 1];
                string bod = posts[i + 2];
                string aut = posts[i + 3];

                if (Topic == top && Title == tit && Author == aut)
                {
                    posts.Remove(top);
                    posts.Remove(tit);
                    posts.Remove(bod);
                    posts.Remove(aut);
                }
            }

            string allPosts = "";

            for (int i = 0; i < posts.Count; i = i + 4)
            {

                if (posts[i] == "")
                {
                    break;
                }

                string top = posts[i];
                string tit = posts[i + 1];
                string bod = posts[i + 2];
                string aut = posts[i + 3];

                allPosts = allPosts+ top + "," + tit + "," + bod + "," + aut + "\n";
            }

            Tools.WriteNotAppendingFile(Social_Networking_System.PostFilePath, allPosts);

            Console.WriteLine("Topic Removed");

        }
    }

    class Social_Networking_System
    {

        private static string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public static string PersonFilePath = desktopPath + "\\Social_Networking_Users.txt";
        public static string friendsFilePath = desktopPath + "\\Social_Network_Friends.txt";
        public static string PostFilePath = desktopPath + "\\Social_Networking_Posts.txt";

        public void ResetData()
        {
            Tools.DeleteFile(PersonFilePath);
            Tools.DeleteFile(friendsFilePath);
            Tools.DeleteFile(PostFilePath);

        }

        public void ExportData(string FilePath, int option)
        {
            if (option == 1)
            {
                File.Copy(PersonFilePath, FilePath);
            }
            else if (option == 2)
            {
                File.Copy(friendsFilePath, FilePath);
            }
            else if (option == 3)
            {
                File.Copy(PostFilePath, FilePath);
            }
            else
            {
                Console.WriteLine("Sorry that is not one of the options, the operation could not be completed.");
            }

        }

        public void ImportData(string FilePath, int option)
        {
            if (option == 1)
            {
                File.Copy(FilePath, PersonFilePath);
            }
            else if (option == 2)
            {
                File.Copy(FilePath, friendsFilePath);
            }
            else if (option == 3)
            {
                File.Copy(FilePath, PostFilePath);
            }
            else
            {
                Console.WriteLine("Sorry that is not one of the options, the operation could not be completed.");
            }
        }
    }

    class Tools
    {
        private static void CheckForFile(string FilePath)
        {
            bool t = File.Exists(FilePath);

            if (t == false)
            {
                CreateFile(FilePath);
            }
        }

        private static void CreateFile(string FilePath)
        {
            try
            {
                File.Create(FilePath).Dispose();
            }
            catch (Exception e)
            {
                Console.WriteLine("Creating the file failed");
                Console.WriteLine(e);
                Console.Read();
            }
        }

        public static void WriteFile(string FilePath, string line)
        {
            CheckForFile(FilePath);

            using (StreamWriter sw = new StreamWriter(FilePath, append: true))
            {
                sw.WriteLine(line);
                sw.Dispose();
            }
        }

        public static List<string> ReadFileSplitComma(string FilePath)
        {
            CheckForFile(FilePath);

            List<string> readInFile = new List<string>();

            using (StreamReader sr = new StreamReader(FilePath))
            {
                //SD: .Replace(Environment.NewLIne, ",") should remove the new line characters!
                string all = sr.ReadToEnd().Replace(Environment.NewLine, ",");
                readInFile = all.Split(',').ToList();
                sr.Dispose();
            }

            return readInFile;
        }

        public static List<string> ReadFileSplitNewLine(string FilePath)
        {
            CheckForFile(FilePath);

            List<string> readInFile = new List<string>();

            using (StreamReader sr = new StreamReader(FilePath))
            {
                //SD: .Replace(Environment.NewLIne, ",") should remove the new line characters!
                string all = sr.ReadToEnd();
                readInFile = all.Split('\n').ToList();
                sr.Dispose();
            }

            return readInFile;
        }

        public static void WriteNotAppendingFile(string FilePath, string line)
        {
            CheckForFile(FilePath);

            using (StreamWriter sw = new StreamWriter(FilePath, append: false))
            {
                sw.WriteLine(line);
                sw.Dispose();
            }
        }

        public static void DeleteFile(string FilePath)
        {
            File.Delete(FilePath);
        }
    }
}
