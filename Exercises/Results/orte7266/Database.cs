using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace CS350_BackendAPI
{
    class Database
    {
        static string dataFileLocation = @"E:\1. University Of Northern Colorado\6. Fall 2017\Software Engineering (CS 350-008)\CS350-BackendAPI\CS350-BackendAPI\SocialMedia.accdb";
        static string oleConnectionString = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Persist Security Info=False;", dataFileLocation);

        //Method: Get Friends
        public static List<double> GetFriends(double UserID)
        {
            string getFriendsQuery = "SELECT * FROM Friends WHERE [User1] = @UserID;";
            List<double> Friends = new List<double>();

            using (OleDbConnection oleConn = new OleDbConnection(oleConnectionString))
            {
                oleConn.Open();
                using (OleDbCommand oleCmd = new OleDbCommand(getFriendsQuery, oleConn))
                {
                    oleCmd.Parameters.AddWithValue("@UserID", UserID);
                    using (OleDbDataReader dr = oleCmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Friends.Add(double.Parse(dr.GetValue(2).ToString()));
                        }
                    }
                }
            }

            return Friends;
        }

        //Method: Add Friendship
        public static bool AddFriendship(double User1ID, double User2ID)
        {
            string insertQuery = "INSERT INTO Friends ([User1],[User2]) VALUES (@User1,@User2);";
            try
            {
                using (OleDbConnection oleConn = new OleDbConnection(oleConnectionString))
                {
                    oleConn.Open();
                    using (OleDbTransaction oleTrans = oleConn.BeginTransaction())
                    {
                        try
                        {
                            using (OleDbCommand oleCmd = new OleDbCommand(insertQuery, oleConn, oleTrans))
                            {
                                oleCmd.Parameters.AddWithValue("@User1", User1ID);
                                oleCmd.Parameters.AddWithValue("@User2", User2ID);
                                oleCmd.ExecuteNonQuery();
                            }
                            using (OleDbCommand oleCmd = new OleDbCommand(insertQuery, oleConn, oleTrans))
                            {
                                oleCmd.Parameters.AddWithValue("@User1", User2ID);
                                oleCmd.Parameters.AddWithValue("@User2", User1ID);
                                oleCmd.ExecuteNonQuery();
                            }
                            oleTrans.Commit();
                            return true;
                        }
                        catch (Exception ex)
                        {
                            oleTrans.Rollback();
                            throw ex;
                        }
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        //Method: Remove Friendship
        public static bool RemoveFriendship(double User1ID, double User2ID)
        {
            string insertQuery = "DELETE FROM Friends WHERE [User1] = @User1 And [User2] = @User2;";
            try
            {
                using (OleDbConnection oleConn = new OleDbConnection(oleConnectionString))
                {
                    oleConn.Open();
                    using (OleDbTransaction oleTrans = oleConn.BeginTransaction())
                    {
                        try
                        {
                            using (OleDbCommand oleCmd = new OleDbCommand(insertQuery, oleConn, oleTrans))
                            {
                                oleCmd.Parameters.AddWithValue("@User1", User1ID);
                                oleCmd.Parameters.AddWithValue("@User2", User2ID);
                                oleCmd.ExecuteNonQuery();
                            }
                            using (OleDbCommand oleCmd = new OleDbCommand(insertQuery, oleConn, oleTrans))
                            {
                                oleCmd.Parameters.AddWithValue("@User1", User2ID);
                                oleCmd.Parameters.AddWithValue("@User2", User1ID);
                                oleCmd.ExecuteNonQuery();
                            }
                            oleTrans.Commit();
                            return true;
                        }
                        catch (Exception ex)
                        {
                            oleTrans.Rollback();
                            throw ex;
                        }
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        //Method: Get Posts
        public static List<Post> GetPosts(double UserID)
        {
            string selectQuery = "SELECT * FROM Posts WHERE [UserID] = @UserID;";
            List<Post> Posts = new List<Post>();
            using (OleDbConnection oleConn = new OleDbConnection(oleConnectionString))
            {
                oleConn.Open();
                using (OleDbCommand oleCmd = new OleDbCommand(selectQuery, oleConn))
                {
                    oleCmd.Parameters.AddWithValue("@UserID", UserID);
                    using (OleDbDataReader dr = oleCmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Post post = new Post(double.Parse(dr.GetValue(0).ToString()),double.Parse(dr.GetValue(1).ToString()), dr.GetValue(2).ToString(),
                                dr.GetValue(3).ToString(), DateTime.Parse(dr.GetValue(4).ToString()));

                            Posts.Add(post);
                        }
                    }
                }
            }
            return Posts;
        }

        //Method: Add Post
        public static Post AddPost(double userID, string Title, string Content)
        {
            string inserQuery = "INSERT INTO Posts ([UserID],[Title],[Content],[TimeStamp]) VALUES (@UserID, @Title, @Content, @Timestamp);";
            string getIDQuery = "SELECT @@Identity;";

            using (OleDbConnection oleConn = new OleDbConnection(oleConnectionString))
            {
                oleConn.Open();
                using (OleDbTransaction oleTrans = oleConn.BeginTransaction())
                {
                    try
                    {
                        DateTime now = DateTime.Now;
                        using (OleDbCommand oleCmd = new OleDbCommand(inserQuery, oleConn, oleTrans))
                        {
                            oleCmd.Parameters.AddWithValue("@UserID", userID);
                            oleCmd.Parameters.AddWithValue("@Title", Title);
                            oleCmd.Parameters.AddWithValue("@Content", Content);
                            oleCmd.Parameters.AddWithValue("@TimeStamp", now);
                        }
                        double postID = 0;
                        using (OleDbCommand oleCmd = new OleDbCommand(getIDQuery, oleConn, oleTrans))
                        {
                            postID = (int)oleCmd.ExecuteScalar();
                        }
                        Post post = new Post(postID, userID, Title, Content, now);
                        oleTrans.Commit();
                        return post;
                    }
                    catch (Exception ex)
                    {
                        oleTrans.Rollback();
                        throw ex;
                    }
                }
            }
        }

        //Method: Remove Post
        public static bool RemovePost(double postID)
        {
            string inserQuery = "DELETE FROM Posts WHERE [PostID] = @PostID;";
            try
            {
                using (OleDbConnection oleConn = new OleDbConnection(oleConnectionString))
                {
                    oleConn.Open();
                    using (OleDbTransaction oleTrans = oleConn.BeginTransaction())
                    {
                        try
                        {
                            using (OleDbCommand oleCmd = new OleDbCommand(inserQuery, oleConn, oleTrans))
                            {
                                oleCmd.Parameters.AddWithValue("@PostID", postID);
                                oleCmd.ExecuteNonQuery();
                            }
                            oleTrans.Commit();
                            return true;
                        }
                        catch (Exception ex)
                        {
                            oleTrans.Rollback();
                            throw ex;
                        }
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        //Method: Clear All Data
        public static bool ClearAll()
        {
            string deleteUsersQuery = "DELETE * FROM Users;";
            string deleteFriendshipsQuery = "DELETE * FROM Friends;";
            string deletePostsQuery = "DELETE * FROM Posts;";
            try
            {
                using (OleDbConnection oleConn = new OleDbConnection(oleConnectionString))
                {
                    oleConn.Open();
                    using (OleDbTransaction oleTrans = oleConn.BeginTransaction())
                    {
                        try
                        {
                            using (OleDbCommand oleCmd = new OleDbCommand(deleteUsersQuery, oleConn, oleTrans))
                            {
                                oleCmd.ExecuteNonQuery();
                            }
                            using (OleDbCommand oleCmd = new OleDbCommand(deleteFriendshipsQuery, oleConn, oleTrans))
                            {
                                oleCmd.ExecuteNonQuery();
                            }
                            using (OleDbCommand oleCmd = new OleDbCommand(deletePostsQuery, oleConn, oleTrans))
                            {
                                oleCmd.ExecuteNonQuery();
                            }
                            oleTrans.Commit();
                            return true;    
                        }
                        catch(Exception ex)
                        {
                            oleTrans.Rollback();
                            throw ex;
                        }
                    }
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
