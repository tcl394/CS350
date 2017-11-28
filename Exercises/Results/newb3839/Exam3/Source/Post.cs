using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Media_Newby
{
    //Social_Media - Exam 3
    //Christopher Newby
    //CS 350 - Fall 2017
    //Professor Mark Seaman

    class Post
    {
        //Encapsulate class variables
        private int Post_ID { get; set; }
        private string Post_Topic { get; set; }
        private int Post_Author_ID {get; set;}
        private int Post_ReferredBy_ID { get; set; }
        private string Post_Body { get; set; }


        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@//
        //@@@@@@@@@@@@@@@@@@@@@@@@@@ API FUNCTION CALLS BELOW THIS LINE @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@//
        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@//

        //Public constructor
        public Post(int p_ID, string p_top, int p_auth, int p_refby_ID, string p_body)
        {
            Post_ID = p_ID;
            Post_Topic = p_top;
            Post_Author_ID = p_auth;
            Post_ReferredBy_ID = p_refby_ID;
            Post_Body = p_body;
        }

        //Get methods for retrieving individual object information
        public int Get_Post_ID()
        {
            return Post_ID;
        }

        public string Get_Post_Topic()
        {
            return Post_Topic;
        }

        public int Get_Author_ID()
        {
            return Post_Author_ID;
        }

        public int Get_ReferredBy_ID()
        {
            return Post_ReferredBy_ID;
        }

        public string Get_Post_Body()
        {
            return Post_Body;
        }

        //Search for posts from certain author
        public List<Post> Get_Posts_For_User(int p_ID)
        {
            List<Post> temp = new List<Post>();

            for (int i = 0; i < Data_Store.posts_list.Count; i++)
            {
                if (Data_Store.posts_list[i].Post_Author_ID.Equals(p_ID))
                {
                    temp.Add(Data_Store.post_list_test[i]);
                }
            }
            return temp;
        }

        //Add post to friend by inserting own ID as author
        public void Add_Post_To_Friend(int p_ID, string p_top, int p_auth, int p_refby_ID, string p_bod)
        {
            Post post_from_friend = new Post(p_ID, p_top, p_auth, p_refby_ID, p_bod);

            Data_Store.posts_list.Add(post_from_friend);
        }

        //Remove post from list
        public void Remove_Post(Post p)
        {
            Data_Store.posts_list.Remove(p);
        }

        //Add post to list
        public void Add_Post_To_List(Post p)
        {
            Data_Store.posts_list.Add(p);
        }
        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@//
        //@@@@@@@@@@@@@@@@@@@@@@@@@@ API FUNCTION CALLS ABOVE THIS LINE @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@//
        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@//


        //--------------------------------------------------------------------------------------------//
        //--------------------- PRIVATE CLASS FUNCTION CALLS BELOW THIS LINE -------------------------//
        //--------------------------------------------------------------------------------------------//

        //None needed

        //--------------------------------------------------------------------------------------------//
        //--------------------- PRIVATE CLASS FUNCTION CALLS ABOVE THIS LINE -------------------------//
        //--------------------------------------------------------------------------------------------//
    }
}
