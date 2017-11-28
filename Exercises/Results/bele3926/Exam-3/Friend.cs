using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Take_home_exam;

namespace Take
{
    public class Friend
    {
        SqlConnection conn;
        private string user_email;
        private string friend_email;
        public string User_Email
        {
            get
            {
                return user_email;
            }
            set
            {
                user_email = value;
            }
        }
        public string Friend_Email
        {
            get
            {
                return friend_email;
            }
            set
            {
                friend_email = value;
            }
        }
        public Boolean Send_Friend_request(string user_email)
        {
            Boolean result = false;
            Person connection = new Person();
            string str1 = connection.connection();
            Console.WriteLine("Enter email address of a person you want friend with");
            friend_email = Console.ReadLine();
            
            try
            {

                conn = new SqlConnection(str1);
                conn.Open();

                if (conn.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Request (UserEmail,SenderEmail) values(@user_email,@friend_email)", conn);
                    cmd.Parameters.AddWithValue("@user_email", user_email);
                    cmd.Parameters.AddWithValue("@friend_email", friend_email);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    result = true;
                    Console.WriteLine("Friend request seccessfully sent");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("something wrong." + ex);
            }
            return result;
        }
    
        public Boolean List_Friends(string useremail)
        {
            int a=0;
            var Friend_list1 = new ArrayList();
            string[] Friend_list = new string[20];
            Person per = new Person();
            Person connection = new Person();
            string str1 = connection.connection();
            try
            {

                conn = new SqlConnection(str1);
                conn.Open();

                if (conn.State == System.Data.ConnectionState.Open)
                {


                    SqlCommand cmd = new SqlCommand(String.Format("SELECT * FROM Friends where UserEmail ='" + useremail +"'"), conn);
                    DataTable dt = new DataTable();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);

                    for (a = 0; a < dt.Rows.Count; a++)
                    {
                        var k1 =dt.Rows[a]["FriendsEmail"].ToString();
                        var k="";
                        k = dt.Rows[a]["UserEmail"].ToString();

                        Console.WriteLine( k1);
                    }


                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something wrong." + ex);
            }
            return true;
        }

    
        public Boolean Remove_Friendship()
        {
            Boolean result = false;
            Person connection = new Person();
            string str1 = connection.connection();
            Console.WriteLine("Enter your friend email to be removed from friends list ");
            string _friends_email= Console.ReadLine();
            try
            {

                conn = new SqlConnection(str1);
                conn.Open();

                if (conn.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand("Delete from Friends where FriendsEmail ='"+_friends_email+"'", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    result = true;
                    Console.WriteLine("Friendship seccessfully removed");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("something wrong." + ex);
            }
            return result;

        }
        public Boolean Confirm_Friendship_request(string User_email, string Friends_email)
        {
            Boolean result = false;
            Person connection = new Person();
            string str1 = connection.connection();
            try
            {

                conn = new SqlConnection(str1);
                conn.Open();

                if (conn.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Friends (UserEmail,FriendsEmail) values(@User_email,@Friends_email)", conn);
                    cmd.Parameters.AddWithValue("@User_email", User_email);
                    cmd.Parameters.AddWithValue("@Friends_email", Friends_email);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    result = true;
                    
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("something wrong." + ex);
            }
            return result;
        }

    
        public string  Notefication(string email)
        {
            string senderemail="";
            Person per = new Person();
            Person connection = new Person();
            string str1 = connection.connection();
            try
            {

                conn = new SqlConnection(str1);
                conn.Open();

                if (conn.State == System.Data.ConnectionState.Open)
                {
                                    

                    SqlCommand cmd = new SqlCommand(String.Format("SELECT * FROM Request where UserEmail ='" + email + "'"), conn);
                    DataTable dt = new DataTable();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                    
                    for (int a = 0; a < dt.Rows.Count; a++)
                    {
                        per.E_mail = dt.Rows[a]["UserEmail"].ToString();
                        senderemail = dt.Rows[a]["SenderEmail"].ToString();
                        
                        
                    }

                                      
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something wrong." + ex);
            }
            return senderemail;
        }

        public Boolean Remove_Friend_request(string email_to_be_removed)
        {
            Boolean result = false;
            Person connection = new Person();
            string str1 = connection.connection();
            
            try
            {

                conn = new SqlConnection(str1);
                conn.Open();

                if (conn.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand("Delete from Request where SenderEmail ='" + email_to_be_removed + "'", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    result = true;
                    
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("something wrong." + ex);
            }
            return result;

        }
    }
}
