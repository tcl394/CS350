using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Net;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Collections;

namespace social_network
{

    public static class System
    {
        #region global system properties
        public static List<Person> RegisteredUsers = new List<Person>();
        #endregion
        #region public methods

        public static void LoadFromFile()
        {
            using (var stream = new FileStream("../../../social_network/data/RegisteredUsers.xml", FileMode.OpenOrCreate))
            {
                var XML = new XmlSerializer(typeof(List<Person>));
                RegisteredUsers = (List<Person>)XML.Deserialize(stream);
            }
        }

        public static void SaveToFile()
        {
            using (var stream = new FileStream("../../../social_network/data/RegisteredUsers.xml", FileMode.Create))
            {
                var XML = new XmlSerializer(typeof(List<Person>));
                XML.Serialize(stream, RegisteredUsers);
            }
        }

        public static void RegisterNewUser(string user, string pass, string first, string last)
        {
            Person newUser = new Person
            {
                Username = user,
                Password = pass,
                FirstName = first,
                LastName = last,
                Friends = new List<string>(),
                Wall = new List<Post>(),
                FriendRequestsReceived = new List<string>(),
                FriendRequestsSent = new List<string>()
            };
            RegisteredUsers.Add(newUser);
            SaveToFile();
        }

        public static void ClearAllData()
        {
            RegisteredUsers = new List<Person>();

            string[] directory = Directory.GetFiles("../../../social_network/data/");
            foreach(string path in directory)
            {
                File.Delete(path);
            }
        }

        #endregion
    }

    public class Person
    {
        #region fields
        private string username;
        private string firstName;
        private string lastName;
        private string password;
        private List<string> friends;
        private List<Post> wall;
        private List<string> friendRequestsReceived;
        private List<string> friendRequestsSent;
        #endregion
        #region public properties
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public List<string> Friends
        {
            get { return friends; }
            set { friends = value; }
        }

        /// <summary>
        /// a chronological list of posts
        /// wall posts are posted either by the user to their own wall
        /// or from other users on to their wall. 
        /// </summary>
        public List<Post> Wall
        {
            get { return wall; }
            set { wall = value; }
        }
        public List<string> FriendRequestsReceived
        {
            get { return friendRequestsReceived; }
            set { friendRequestsReceived = value; }
        }
        public List<string> FriendRequestsSent
        {
            get { return friendRequestsSent; }
            set { friendRequestsSent = value; }
        }
        #endregion
    }

    public class Post
    {
        #region fields
        private DateTime postDate;
        private string subject;
        private string body;
        private string author;
        #endregion
        #region public properties
        public DateTime PostDate
        {
            get { return postDate; }
            set { postDate = value; }
        }
        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }
        public string Body
        {
            get { return body; }
            set { body = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        #endregion
    }

    /// <summary>
    /// represents all the actions a user can do when logged in to the system.
    /// </summary>
    public class User
    {
        #region fields
        private Person self;
        #endregion
        #region public properties;
        public Person Self
        {
            get { return self; }
        }
        #endregion
        #region public methods

        //constructor
        public User(Person thisUser)
        {
            self = thisUser;
        }

        public void ComposePost(string subject, string body, Person postingTo = null)
        {
            //if default, post to their own wall.
            postingTo = postingTo ?? this.self;
            postingTo.Wall.Add(new Post
            {
                Subject = subject,
                Body = body,
                PostDate = DateTime.Now,
                Author = this.self.Username
            });
            System.SaveToFile();
        }

        public void SendFriendRequest(Person requestedPerson)
        {
            requestedPerson.FriendRequestsReceived.Add(this.self.Username);
            this.self.FriendRequestsSent.Add(requestedPerson.Username);
            System.SaveToFile();
        }

        public void RespondToFriendRequest(bool isConfirmed, Person sentBy)
        {
            if (!this.self.FriendRequestsReceived.Remove(sentBy.Username))
            {
                return;
            }
            if (isConfirmed)
            {
                this.self.Friends.Add(sentBy.Username);
                sentBy.Friends.Add(this.Self.Username);
            }
            System.SaveToFile();
        }

        public List<Post> ViewWall(Person personToView)
        {
            if (!this.self.Friends.Contains(personToView.Username))
            {
                return null;
            }
            return personToView.Wall;
        }

        public string ViewPost(Post postToView)
        {
            string author = null;

            if(this.self.Username == postToView.Author)
            {
                author = this.self.Username;
            } else {
                foreach (string friend in this.self.Friends)
                {
                    if (String.Compare(author, friend) == 0)
                    {
                        author = friend;
                        break;
                    }
                }
            }
            
            if (author == null)
            {
                return "Access not allowed. You must be friends with this user to see their wall.";
            }

            return "by: " + postToView.Author + "\n"
                + "at: " + postToView.PostDate.ToShortTimeString() + ", "
                + postToView.PostDate.ToShortDateString() + "\n"
                + "subject: " + postToView.Subject + "\n"
                + "message: " + postToView.Body;
        }

        private string viewUsers(List<Person> listToView)
        {
            string users = "";
            foreach(Person p in listToView)
            {
                users += string.Concat(p.Username, ", ", p.FirstName, ", ", p.LastName, "\n");
            }
            return users;
        }

        public string ViewAllUsers()
        {
            string users = "All Registered Users: \n";
            users += viewUsers(System.RegisteredUsers);
            return users;
        }

        public string ViewFriends()
        {
            string users = "Friend List: \n";
            users += viewUsers(getMatchingPeople(this.self.Friends));
            return users;
        }

        private List<Person> getMatchingPeople(List<string> usernames)
        {
            List<Person> matches = System.RegisteredUsers.Where(person => usernames.Contains(person.Username)).ToList();
            return matches;
        } 

        public string ViewSentFriendRequests()
        {
            string users = "Friend requests you have sent: \n";
            users += viewUsers(getMatchingPeople(this.self.FriendRequestsSent));
            return users;
        }

        public string ViewReceivedFriendRequests()
        {
            string users = "Friend requests sent to you: \n";
            users += viewUsers(getMatchingPeople(this.self.FriendRequestsReceived));
            return users;
        }

        public void Authenticate(string username, string password)
        {
            Person thisUser = null;
            System.LoadFromFile();
            foreach (Person p in System.RegisteredUsers)
            {
                if (username == p.Username)
                {
                    thisUser = p;
                    break;
                }
            }
            if (thisUser != null)
            {
                if (String.CompareOrdinal(password, thisUser.Password) == 0)
                {
                    this.self = thisUser;
                }
            }
        }

        #endregion
    }
}
