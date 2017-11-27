using CS_350_Exam_3_Final_Version;
using System;
using System.Collections.Generic;
using System.Text;

namespace CS_350_Exam_3
{
    class Social_Network_Test
    {
        public static void AllTests()
        {
            try
            {
                RegisterUsersTest();
                LoginTest();
                AddFriendsTest();
                ListFriendsTest();
                RemoveFriendsTest();
                AddTopicTest();
                ListTopicsTest();
                RemoveTopicTest();
                ExportDataTest();
                ImportDataTest();
                ResetDataTest();
            }
            catch
            {
                Console.WriteLine("An error has occured, operations have been stopped");
            }
            

        }

        public static void RegisterUsersTest()
        {
            try
            {
                Console.WriteLine("Registration Test");

                Person p = new Person();
                p.Register("Bruce", "Wayne", "Batman@here.com", "Batman", "test");
                Person t = new Person();
                t.Register("Clark", "Kent", "Superman@here.com", "Superman", "pass");
                Person x = new Person();
                x.Register("Princess Diana", "Of Themyscira", "WW@here.com", "Wonder Woman", "demigod");
                Person y = new Person();
                y.Register("Logan", "X", "WeaponX@here.com", "Wolverine", "WeaponX");
                Person z = new Person();
                z.Register("Tony", "Stark", "IronMan@here.com", "Ironman", "pep");
                Person a = new Person();
                a.Register("Peter", "Parker", "FNSM@here.com", "Spiderman", "MJ");

                Console.WriteLine("End of Registration.\nEnter to continue.\n");
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("An error has occured, operations have been stopped");
            }
            
        }

        public static void LoginTest()
        {
            try
            {
                Console.WriteLine("Login Test");

                Person p = new Person();
                p.Login("Batman", "test");
                Person t = new Person();
                t.Login("Superman", "pass");


                Console.WriteLine("End of Loign.\nEnter to continue\n");
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("An error has occured, operations have been stopped");
            }
            
        }

        public static void AddFriendsTest()
        {
            try
            {
                Console.WriteLine("Add Friends Test");

                Person p = new Person();
                p.Login("Batman", "test");

                Person t = new Person();
                t.Login("Superman", "pass");

                Person x = new Person();
                x.Login("Wonder Woman", "demigod");

                Person y = new Person();
                y.Login("Wolverine", "WeaponX");

                Person z = new Person();
                z.Login("Ironman", "pep");

                Person a = new Person();
                a.Login("Spiderman", "MJ");

                Friend f = new Friend();
                f.AddFriendship(p, t);
                f.AddFriendship(p, x);
                f.AddFriendship(z, a);
                f.AddFriendship(y, a);
                f.AddFriendship(p, z);

                Console.WriteLine("End of adding friends.\nEnter to continue.\n");
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("An error has occured, operations have been stopped");
            }
            
        }

        public static void ListFriendsTest()
        {
            try
            {
                Console.WriteLine("List Friends Test");

                Friend f = new Friend();

                f.ListFriends();

                Console.WriteLine("End of listing friends.\nEnter to continue\n");
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("An error has occured, operations have been stopped");
            }
            
        }

        public static void RemoveFriendsTest()
        {
            try
            {
                Console.WriteLine("Remove friends test");

                Person p = new Person();
                Person t = new Person();
                p.Login("Batman", "test");
                t.Login("Superman", "pass");

                Friend f = new Friend();
                f.RemoveFriendship(p, t);

                Console.WriteLine("End of removing friends.\nEnter to continue\n");
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("An error has occured, operations have been stopped");
            }
            
        }

        public static void AddTopicTest()
        {
            try
            {
                Console.WriteLine("Add topic test");

                Person p = new Person();
                p.Login("Batman", "test");
                Person t = new Person();
                t.Login("Superman", "pass");
                Person z = new Person();
                z.Login("Ironman", "pep");


                Post post = new Post();
                post.AddTopic(p, "Science", "Science is cool!", "Science is amazing! There is a lot to learn from science and it has helped advance the world in many ways.");

                Post post2 = new Post();
                post2.AddTopic(t, "Programming", "Programming is fun", "Programming takes time to learn but once you do it is very powerful!");

                Post post3 = new Post();
                post3.AddTopic(z, "Industry", "The future of war", "The future of war will be won with mechanical soldiers");

                Console.WriteLine("End of adding topics.\nEnter to continue\n");
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("An error has occured, operations have been stopped");
            }
            
        }

        public static void ListTopicsTest()
        {
            try
            {
                Console.WriteLine("List topics test");

                Post post = new Post();
                string topics = post.ListTopics();
                Console.WriteLine(topics);

                Console.WriteLine("End of listing topics.\nEnter to continue\n");
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("An error has occured, operations have been stopped");
            }
            
        }

        public static void RemoveTopicTest()
        {
            try
            {
                Console.WriteLine("Remove topic test");

                Person t = new Person();
                t.Login("Superman", "pass");
                Post post = new Post();
                post.RemoveTopic(t, "Programming", "Programming is fun");

                Console.WriteLine("End of removing topics.\nEnter to continue\n");
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("An error has occured, operations have been stopped");
            }
            
        }

        public static void ExportDataTest()
        {
            try
            {
                Console.WriteLine("Export data test");

                string usersFile = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\users.txt";
                string friendsFile = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\friends.txt";
                string postsFile = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\posts.txt";

                Social_Networking_System sys = new Social_Networking_System();

                sys.ExportData(usersFile, 1);
                sys.ExportData(friendsFile, 2);
                sys.ExportData(postsFile, 3);


                List<string> users = Tools.ReadFileSplitComma(usersFile);
                Console.WriteLine("Users:\n");
                foreach (string u in users)
                {
                    Console.WriteLine(u);
                }
                Console.WriteLine("\n");


                List<string> friends = Tools.ReadFileSplitNewLine(friendsFile);
                Console.WriteLine("Friends:\n");
                foreach (string f in friends)
                {
                    Console.WriteLine(f);
                }
                Console.WriteLine("\n");


                List<string> posts = Tools.ReadFileSplitComma(postsFile);
                Console.WriteLine("Posts:\n");
                foreach (string p in posts)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine("\n");

                Console.WriteLine("End of exporting data.\nEnter to continue\n");
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("An error has occured, operations have been stopped");
            }

        }
        
        public static void ImportDataTest()
        {
            try
            {
                Console.WriteLine("Import Data test");

                string usersFile = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\users.txt";
                string friendsFile = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\friends.txt";
                string postsFile = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\posts.txt";

                Social_Networking_System sys = new Social_Networking_System();
                sys.ResetData();
                sys.ImportData(usersFile, 1);
                sys.ImportData(friendsFile, 2);
                sys.ImportData(postsFile, 3);

                List<string> users = Tools.ReadFileSplitComma(Social_Networking_System.PersonFilePath);
                Console.WriteLine("Users:\n");
                foreach (string u in users)
                {
                    Console.WriteLine(u);
                }
                Console.WriteLine("\n");


                List<string> friends = Tools.ReadFileSplitNewLine(Social_Networking_System.friendsFilePath);
                Console.WriteLine("Friends:\n");
                foreach (string f in friends)
                {
                    Console.WriteLine(f);
                }
                Console.WriteLine("\n");


                List<string> posts = Tools.ReadFileSplitComma(Social_Networking_System.PostFilePath);
                Console.WriteLine("Posts:\n");
                foreach (string p in posts)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine("\n");

                Console.WriteLine("End of importing data.\nEnter to continue\n");
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("An error has occured, operations have been stopped");
            }
            
        }

        public static void ResetDataTest()
        {
            try
            {
                Console.WriteLine("Reset Data Test");

                string usersFile = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\users.txt";
                string friendsFile = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\friends.txt";
                string postsFile = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\posts.txt";
                //Only needs to be done when tests are run.
                Tools.DeleteFile(usersFile);
                Tools.DeleteFile(friendsFile);
                Tools.DeleteFile(postsFile);


                Social_Networking_System sys = new Social_Networking_System();
                sys.ResetData();

                Console.WriteLine("End of resetting data.\nEnter to continue\n");
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("An error has occured, operations have been stopped");
            }
            
        }
    }
}
