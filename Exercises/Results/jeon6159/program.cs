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
        public string conectionString;

        Data Source = (@"LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Elhanan\Documents\pairprogramming.mdf;Integrated Security = True; Connect Timeout = 30
         ///Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Elhanan\Desktop\FinalProject\Final\Final\MainDB.mdf;Integrated Security = True");

        private string name;
        private string email;

        static void Main(string[] args)
        {
            
        }
        public void add_auther()
        {
            if (ConnectionState.Closed == connection.State)
                    {
                        connection.Open();
                    }
            SqlCommand cmd = new SqlCommand("insert into auther (name,email) values(@name,@email)", connection);
            cmd.Parameters.AddWithValue("@Firstname",name);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.ExecuteNonQuery();
        }
        public void read_auther()
        {

        }
        public void update_auther()
        {
            SqlCommand cmd = new SqlCommand("update auther set name = @name,email = @email,Where email='" + email + "'", connection);
            cmd.Parameters.AddWithValue("@title", name);
            cmd.Parameters.AddWithValue("@author", email);
                    }
        public void delete_auther()
        {
            //connection.Open();
            SqlCommand cmd = new SqlCommand("Delete from auther where email=" + email, connection);
            cmd.ExecuteNonQuery();
        }
    }
}
