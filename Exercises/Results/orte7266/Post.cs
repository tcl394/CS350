using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS350_BackendAPI
{
    class Post
    {
        public double postID { get; set; }
        public double userID { get; set; }
        public string Title { get; set;  }
        public string Content { get; set; }
        public DateTime timeStamp { get; set; }

        public Post(double postID, double userID, string Title, string Content, DateTime timeStamp)
        {
            this.userID = userID;
            this.Title = Title;
            this.Content = Content;
            this.timeStamp = timeStamp;
        }
    }
}
