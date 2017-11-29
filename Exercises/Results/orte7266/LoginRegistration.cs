using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace CS350_BackendAPI
{
    class LoginRegistration
    {
        //Database Connection Information
        static string dataFileLocation = @"E:\1. University Of Northern Colorado\6. Fall 2017\Software Engineering (CS 350-008)\CS350-BackendAPI\CS350-BackendAPI\SocialMedia.accdb";
        static string oleConnectionString = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Persist Security Info=False;", dataFileLocation);

        //Method: Register User
        public static User RegisterUser(string Username, string Password, string fullName, string Email)
        {
            object[] parameters = { Username, Password, fullName, Email };
            string insertUserQuery = string.Format("INSERT INTO Users ([Username], [Password], [FullName], [Email]) VALUES ('{0}','{1}','{2}','{3}');", parameters);
            string getIDQuery = "Select @@Identity;";
            int userID = 0;
            using (OleDbConnection oleconn = new OleDbConnection(oleConnectionString))
            {
                oleconn.Open();
                using (OleDbTransaction oleTrans = oleconn.BeginTransaction())
                {
                    try
                    {
                        using (OleDbCommand oleCmd = new OleDbCommand(insertUserQuery, oleconn, oleTrans))
                        {
                            oleCmd.ExecuteNonQuery();
                        }
                        using (OleDbCommand oleCmd = new OleDbCommand(getIDQuery, oleconn, oleTrans))
                        {
                            userID = (int)oleCmd.ExecuteScalar();
                        }
                        oleTrans.Commit();
                        User newUserObj = new User(userID, Username, new List<double>());
                        return newUserObj;
                    }
                    catch (Exception ex)
                    {
                        oleTrans.Rollback();
                        throw ex;
                    }
                }
            }
        }

        //Method: Login User
        public static User Login(string username, string password)
        {
            string getUserQuery = "SELECT * FROM Users WHERE [Username] = @Username AND [Password] = @Password";
            using (OleDbConnection oleConn = new OleDbConnection(oleConnectionString))
            {
                oleConn.Open();
                object[] user = new object[6];
                using (OleDbCommand oleCmd = new OleDbCommand(getUserQuery, oleConn))
                {
                    oleCmd.Parameters.AddWithValue("@Username", username);
                    oleCmd.Parameters.AddWithValue("@Password", password);
                    using (OleDbDataReader dr = oleCmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            dr.GetValues(user);
                        }
                    }
                }
                if (user == null)
                {
                    Exception ex = new Exception("User Not Found");
                    throw ex;
                }
                else
                {
                    double userID = double.Parse(user[0].ToString());
                    List<double> friends = Database.GetFriends(userID);
                    User userObj = new User(userID, user[1].ToString(), friends);
                    return userObj;
                }
            }
        }
    }
}
