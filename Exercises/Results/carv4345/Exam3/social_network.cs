// Written by Robert Carver 11/20/17 - 11/26/17 for CS350. 
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace social_network
{
    public class User
    {
        public string First { get; set; }
        public string Last { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Uid { get; set; }
        public string password { get; set; }
        public List<int> Posts { get; set; }
        public List<String> Friends { get; set; }

        public User(String first, String last, String email, String uid, List<int> posts, List<string> friends)
        {
            First = first;
            Last = last;
            Email = email;
            Name = first + " " + last;
            Uid = uid;
            Posts = posts;
            Friends = friends;
            password = "CHANGE_ME";
        }
        public void AddPost(int ID)
        {
            if (!Posts.Contains(ID))
            {
                Posts.Add(ID);
            }
        }
        public void AddFriend(string f)
        {
            if (!Friends.Contains(f))
            {
                Friends.Add(f);
            }

        }
        public void RemoveFriend(string f)
        {
            if (Friends.Contains(f))
            {
                Friends.Remove(f);
            }
        }
        public void RemovePost(int ID)
        {
            if(Posts.Contains(ID))
            {
                Posts.Remove(ID);
            }
        }
    }
    public class Post
    {
        public int PID { get; set; }
        public string ownerID { get; set; }
        public string Content { get; set; }
        public string TimeStamp { get; set; }
        public string TaggedUsers { get; set; }
        public Post(int pid, string content, string time, string tagged, string oID)
        {
            PID = pid;
            Content = content;
            TimeStamp = time;
            TaggedUsers = tagged;
            ownerID = oID;
        }
    }
   
    class Program
    {      
        public class SocialMedia
        {
            static void Main()
            {
                
            }
            public static List<User> users = new List<User>();
            public static List<Post> posts = new List<Post>();
            public static User currentUID;

            public static bool UserLogin(string uid, string password)
            {
                try
                {
                    if (users.Contains(users.Find(user => user.Uid == uid)))
                    {
                       if(password == users.Find(user => user.Uid == uid).password)
                        {
                            currentUID = users.Find(user => user.Uid == uid);
                            return true;
                        }
                    }
                    return false;
                }
                catch
                {
                    return false;
                }
            }
            public static bool InitUser(string UID, string first, string last, string email, List<int> posts, List<string> friends)
            {
                try
                {
                    if (!users.Contains(users.Find(user => user.Uid == UID)))
                    {
                        users.Add(new User(first, last, email, UID, posts, friends));

                    }
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            public static bool InitPost(string content, string tagged, string oID)
            {
                try
                {
                    int pid = posts.Count + 1;
                    posts.Add(new Post(pid, content, DateTime.Now.ToString("yyy-MM-dd HH:mm:ss.ffffff"), tagged, oID));
                    users.Find(user => user.Uid == oID).AddPost(pid);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            public static bool ExportData()
            {
                using (StreamWriter writetext = new StreamWriter("social_export.txt"))                {
                    
                    foreach (User user in users)
                    {
                        string friendString = string.Join(",", user.Friends.ToArray());
                        string postString = string.Join(",", user.Posts.ToArray());
                        writetext.WriteLine(user.First + "," + user.Last + "," + user.Email + "," + user.Uid + "[" + friendString + "]" + postString);
                    }
                    writetext.WriteLine("End Users");
                    foreach (Post post in posts)
                    {
                        writetext.WriteLine(post.PID + "|" + post.Content + "|" + post.TimeStamp + "|" + post.TaggedUsers);
                    }
                }

                return true;
            }          
            public static bool ImportData()
            {

                using (StreamReader file = new StreamReader("social_export.txt"))
                {
                    string line;
                    int count = 0;
                    while ((line = file.ReadLine())!=null)
                    {
                        if (line != "End Users" && count == 0)
                        {
                            string[] splitA = line.Split("[");
                            string[] splitB = splitA[0].Split(",");

                            string[] dataLists = splitA[1].Split("]");
                            string[] initPosts = dataLists[1].Split(",");
                            if (initPosts.Length > 0)
                            {
                                int[] intPosts = Array.ConvertAll(initPosts, int.Parse);

                                List<int> listPosts = intPosts.ToList();

                                string[] initFriends = dataLists[0].Split(",");
                                List<string> listFriends = initFriends.ToList();

                                InitUser(splitB[3], splitB[0], splitB[1], splitB[2], listPosts, listFriends);
                            }
                        }
                        if (line == "End Users") { count = 5; }
                        else
                        {
                            string[] postArray = line.Split("|");
                            if (postArray.Length > 2)
                            {
                                InitPost(postArray[1], postArray[3], postArray[0]);
                            }
                        }
                    }
                }

                    return true;
            }
            public static bool ResetSystem()
            {
                users.Clear();
                posts.Clear();
                return true;
            }
            public static bool DeleteUser(string uid)
            {
                try
                {
                    if (users.Contains(users.Find(user => user.Uid == uid)))
                    {
                        users.Remove(users.Find(user => user.Uid == uid));
                        
                    }
                    return true;

                }
                catch
                {
                    return false;
                }
            }
            public static bool DeletePost(int pid, string uid)
            {
                try
                {
                    if(posts.Contains(posts.Find(post => post.PID == pid)))
                    {
                        posts.Remove(posts.Find(post => post.PID == pid));
                        users.Find(user => user.Uid == uid).RemovePost(pid);
                        
                    }
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            public static bool AddFriend(string uid, string friendUID)
            {
                try
                {
                    
                    users.Find(user => user.Uid == friendUID).AddFriend(uid);
                    users.Find(user => user.Uid == uid).AddFriend(friendUID);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            public static bool DeleteFriend(string uid, string friendUID)
            {
                try
                {
                    users.Find(user => user.Uid == uid).RemoveFriend(friendUID);
                    users.Find(user => user.Uid == friendUID).RemoveFriend(uid);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            public static List<string> GetFriends(string uid)
            {
                if (users.Contains(users.Find(user => user.Uid == uid)))
                {
                    return users.Find(user => user.Uid == uid).Friends;
                }
                else
                {
                    return null;
                }
            }
            public static List<int> GetFriendPosts(string uid)
            {
                if (users.Contains(users.Find(user => user.Uid == uid)))
                {
                    List<int> postFriends = new List<int>();
                    foreach(string f in users.Find(user => user.Uid == uid).Friends)
                    {
                        
                        foreach (int pID in users.Find(user => user.Uid == f).Posts)
                        {
                            postFriends.Add(pID);
                        }
                        
                    }
                    return postFriends;
                }
                return null;
            }
                        
        }
    }
}