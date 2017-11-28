
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Take;

namespace Take_home_exam
{
    public class Person
    {
        SqlConnection conn;
        public string connection()
        {
            
            string str1 = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Elhanan\Documents\HomeTakeExam.mdf;Integrated Security=True;Connect Timeout=30";
            return str1;
        }
        private string _first_name;
        private string _last_name;
        private string _email;
        private string _password;
        private string _friendemail;
        public string FriendEmail
        {
            get
            {
                return _friendemail;
            }
            set
            {
                _friendemail = value;
            }
        }
        public string First_Name
        {
            get
            {
                return _first_name;
            }
            set
            {
                _first_name = value;
            }
        }
        public string Last_Name
        {
            get
            {
                return _last_name;
            }
            set
            {
                _last_name = value;
            }
        }
        public string E_mail
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }
        public string Pass_word
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }
        public Boolean Registration()
        {
            Boolean result = false;
            
            try
            {

                conn = new SqlConnection(connection());
                conn.Open();

                if (conn.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Person (Email,FirstName,LastName,Password) values(@_email,@_first_name,@_last_name,@_password)", conn);
                    cmd.Parameters.AddWithValue("@_email", _email);
                    cmd.Parameters.AddWithValue("@_first_name", _first_name);
                    cmd.Parameters.AddWithValue("@_last_name", _last_name);
                    cmd.Parameters.AddWithValue("@_password", _password);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    result = true;
                    Console.WriteLine("user data saved to database");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("something wrong." + ex);
            }
            return result;
        }
        public Boolean Login(string email, string password)
        {
            Boolean result = false;
            try
            {

                conn = new SqlConnection(connection());
                conn.Open();

                if (conn.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Person WHERE Email='" + email + "' and Password = '" + password + "' ", conn);

                    DataTable dt = new DataTable();
                    SqlDataReader rd = cmd.ExecuteReader();
                    dt.Load(rd);
                    if (dt.Rows.Count == 1)
                    {
                        result = true;
                        Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-**-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
                        Console.WriteLine("-----------------------Welcomm + "+ email);
                        Console.WriteLine("-----------------------Main Menu-----------");
                        Console.WriteLine("Enter FR to send friend request");
                        Console.WriteLine("Enter FL to list all friends");
                        Console.WriteLine("Enter FD to delete friend");
                        Console.WriteLine("Enter FL to list all friends");
                        Console.WriteLine("Enter FN to friend request notification");
                        Console.WriteLine("Enter AT to create topic");
                        Console.WriteLine("Enter LT to list all topics");
                        Console.WriteLine("Enter RT to remove topic");
                        Console.WriteLine("Yoo");
                        Console.WriteLine("Select what you want to do");
                        string chose = Console.ReadLine();
                        Friend friend = new Friend();
                        Post post = new Post();
                        if (chose.Equals("FN"))
                        {
                            Console.WriteLine("You have friend request from");
                            string f_email = friend.Notefication(email);
                            Console.WriteLine("Email   :" + f_email);
                            Console.WriteLine("If you want to confirm friend request enter Y");
                            string confermation = Console.ReadLine();
                            if (confermation.Equals("Y"))
                            {
                                friend.Confirm_Friendship_request(email, f_email);
                                friend.Remove_Friend_request(f_email);
                            }
                            else if (confermation.Equals("N"))
                            {
                                friend.Remove_Friend_request(f_email);
                            }
                        }

                        else if (chose.Equals("FL"))
                        {
                            friend.List_Friends(email);
                        }
                        else if (chose.Equals("FR"))
                        {
                            friend.Send_Friend_request(email);
                        }
                        else if (chose.Equals("FD"))
                        {
                            friend.Remove_Friendship();
                        }
                        else if (chose.Equals("AT"))
                        {
                            post.Add_topics(email);
                        }

                        else if (chose.Equals("LT"))
                        {
                            post.List_topics();
                        }
                        else if (chose.Equals("RT"))
                        {
                            post.Remove_topics();
                        }
                        result = true;
                    }

                }
                else
                {
                    Console.WriteLine("Passowrd or Email you enterd is incorrect");
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
