using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace pair_Programming
{

    class Program
    {
                

        static SqlConnection conn;
        static string str1 = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Elhanan\Documents\pairprogramming.mdf;Integrated Security=True;Connect Timeout=30";

        static void Main(string[] args)
        {
            int choise;
            Console.WriteLine("Menu:");
            Console.WriteLine("Please enter 1 to work on auther:");
            Console.WriteLine("Please enter 2 to work on article:");
            choise = Convert.ToInt32(Console.ReadLine());
            if (choise == 1)
            {
                int choi;
                Console.WriteLine("Menu:");
                Console.WriteLine("Please enter 3 to add auther:");
                Console.WriteLine("Please enter 4 to update auther email:");
                Console.WriteLine("Please enter 5 to delete auther:");
                Console.WriteLine("Please enter 6 to see all auther record:");
                choi = Convert.ToInt32(Console.ReadLine());
                if (choi == 3)
                {
                    Add_auther();

                }
                else if (choi == 4)
                {
                    update_auther();
                }
                else if (choi == 5)
                {
                    delete_auther();
                }
                else if (choi == 6)
                {
                    read_auther();
                }
                else
                {
                    Console.WriteLine("Wrong choise please see the menu:");
                }

            }
            else if (choise == 2)
            {

                int choi;
                Console.WriteLine("Menu:");
                Console.WriteLine("Please enter 7 to add article:");
                Console.WriteLine("Please enter 8 to update article:");
                Console.WriteLine("Please enter 9 to delete article:");
                Console.WriteLine("Please enter 10 to see all article record:");
                choi = Convert.ToInt32(Console.ReadLine());
                if (choi == 7)
                {
                    Add_article();

                }
                else if (choi == 8)
                {
                    //update_article();
                }
                else if (choi == 9)
                {
                    //delete_article();
                }
                else if (choi == 10)
                {
                   // read_article();
                }
                else
                {
                    Console.WriteLine("Wrong choise please see the menu:");
                }
            }
        }
        public static void Add_auther()
          {
          
            string name;
            string email;
            Console.WriteLine("Enter auther name");
            name = Console.ReadLine();
            Console.WriteLine("Enter auther email");
            email = Console.ReadLine();
            try
            {
                
                conn = new SqlConnection(str1);
                conn.Open();
                
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO auther (name,email) values(@name,@email)", conn);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    Console.WriteLine("Auther data saved to database");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("something wrong."+ex);
            }
            Console.ReadLine();
          }
        public static void read_auther()
        {
            
            try
            {

                conn = new SqlConnection(str1);
                conn.Open();

                if (conn.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM auther", conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            Console.WriteLine(reader.GetValue(i));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("something wrong." + ex);
            }
            Console.ReadLine();

        }
        public static void update_auther()
        {
            string name;
            string email;
            Console.WriteLine("Enter auther name to change his/her email");
            name = Console.ReadLine();
            Console.WriteLine("Enter new email");
            email = Console.ReadLine();
            try
            {

                conn = new SqlConnection(str1);
                conn.Open();

                if (conn.State == System.Data.ConnectionState.Open)
                {

                    SqlCommand cmd = new SqlCommand("update auther set email = @email Where name='" + name + "'", conn);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.ExecuteNonQuery();  
                    conn.Close();
                    Console.WriteLine("Auther email successfully updated");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("something wrong." + ex);
            }
        }
        
        public static void delete_auther()
        {
            string name;
            Console.WriteLine("Enter auther name to be deleted");
            name = Console.ReadLine();
           
            try
            {

                conn = new SqlConnection(str1);
                conn.Open();

                if (conn.State == System.Data.ConnectionState.Open)
                {

                    SqlCommand cmd = new SqlCommand("Delete from auther where name='" + name + "'", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    Console.WriteLine("Auther successfully deleted!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("something wrong." + ex);
            }
        }



        public static void Add_article()
        {

            string article;
            string body;
            string auterid;
            Console.WriteLine("Enter article name");
            article = Console.ReadLine();
            Console.WriteLine("Enter article body");
            body = Console.ReadLine();
            Console.WriteLine("Enter article body");
            auterid = Console.ReadLine();
            try
            {

                conn = new SqlConnection(str1);
                conn.Open();

                if (conn.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO article (article,body,autherid) values(@article,@body,@auterid)", conn);
                    cmd.Parameters.AddWithValue("@article", article);
                    cmd.Parameters.AddWithValue("@body", body);
                    cmd.Parameters.AddWithValue("@auterid", auterid);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    Console.WriteLine("The article successfully saved to database");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something wrong." + ex);
            }
            Console.ReadLine();
        }
        public static void update_article()
        {
            string article;
            string body;
            Console.WriteLine("Enter article to update its body");
            article = Console.ReadLine();
            Console.WriteLine("Enter new atricle body");
            body = Console.ReadLine();
            try
            {

                conn = new SqlConnection(str1);
                conn.Open();

                if (conn.State == System.Data.ConnectionState.Open)
                {

                    SqlCommand cmd = new SqlCommand("update article set body = @body Where article='" + article + "'", conn);
                    cmd.Parameters.AddWithValue("@body", body);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    Console.WriteLine("Atricle successfully updated");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("something wrong." + ex);
            }
        }
        public static void delete_article()
        {
            string article;
            Console.WriteLine("Enter article to be deleted");
            article = Console.ReadLine();

            try
            {

                conn = new SqlConnection(str1);
                conn.Open();

                if (conn.State == System.Data.ConnectionState.Open)
                {

                    SqlCommand cmd = new SqlCommand("Delete from article where name='" + article + "'", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    Console.WriteLine("Article successfully deleted!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("something wrong." + ex);
            }
        }



    }
}

