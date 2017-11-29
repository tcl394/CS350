using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS350_BackendAPI
{
    class User
    {

        //Class Variables
        public double userID { get; }
        public string userName { get; set; }
        public List<double> userFriends { get; set; }
        public List<Post> userPosts { get; set; }

        //Constructor
        public User(double userID, string userName, List<double> userFriends)
        {
            this.userID = userID;
            this.userName = userName;
            this.userFriends = userFriends;
            this.userPosts = Database.GetPosts(this.userID);
        }

        //Method: Add Friendship
        public void AddFriend(double userID)
        {
            Database.AddFriendship(this.userID, userID);
        }

        //Method: Refresh Friends
        public void RefreshFriends()
        {
            this.userFriends = Database.GetFriends(userID);
        }

        //Method: Refresh Posts
        public void RefreshPosts()
        {
            this.userPosts = Database.GetPosts(this.userID);
        }

        //Method: Get Posts
        public List<Post> GetPosts()
        {
            return Database.GetPosts(this.userID);
        }

        //Method: Create Post
        public Post CreatePost(string Title, string Content)
        {
            return Database.AddPost(userID, Title, Content);
        }

        //Method: Remove Post (ID Overload)
        public void RemovePost(double postID)
        {
            Database.RemovePost(postID);
        }
        //Method: Remove Post (Post Overload)
        public void RemovePost(Post post)
        {
            Database.RemovePost(post.postID);
        }
    }
}
