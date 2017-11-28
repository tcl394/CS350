using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Take_home_exam;

namespace Take
{
    
   public class Post
    {
        SqlConnection conn;
        private string _topic;
        private string _body;
        
        public string Topic
        {
            get
            {
                return _topic;
            }
            set
            {
                _topic = value;
            }
        }
        public string Body
        {
            get
            {
                return _body;
            }
            set
            {
                _body = value;
            }
        }
        
        public Boolean Add_topics(string email)
        {
            Boolean result = false;
            Person connection = new Person();
            string str1= connection.connection();
            Console.WriteLine("Enter Topic");
            _topic = Console.ReadLine();
            Console.WriteLine("Enter body");
            _body = Console.ReadLine();
                      
            try
            {

                conn = new SqlConnection(str1);
                conn.Open();

                if (conn.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Post (Topic,Body,Email) values(@_topic,@_body,@email)", conn);
                    cmd.Parameters.AddWithValue("@_topic", _topic);
                    cmd.Parameters.AddWithValue("@_body", _body);
                    cmd.Parameters.AddWithValue("@_email", email);
                    
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    result = true;
                    Console.WriteLine("Topic data saved to database");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("something wrong." + ex);
            }
            return result;

        }
        public Boolean List_topics()
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
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Post", conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            Console.WriteLine(reader.GetValue(i));
                        }
                    }
                    result = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something wrong." + ex);
            }
            return result;
        }
        public Boolean Remove_topics()
        {
            Boolean result = false;
            Person connection = new Person();
            string str1 = connection.connection();
            Console.WriteLine("Enter topic to be deleted");
            _topic = Console.ReadLine();
            try
            {

                conn = new SqlConnection(str1);
                conn.Open();

                if (conn.State == System.Data.ConnectionState.Open)
                {

                    SqlCommand cmd = new SqlCommand("Delete from Post where Topic ='" + _topic + "'", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    result = true;
                    Console.WriteLine("Topic successfully deleted!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something wrong." + ex);
            }
            return result;
        }
    }
}
