using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Take_home_exam;

namespace Take
{
   public class System1
    {
        private string table_name;
        public string Table_Name
        {
            get
            {
                return table_name;

            }
            set
            {
                table_name = value;
            }
        }
        SqlConnection conn;
        public Boolean Reset_table()
        {
            Boolean result = false;
            Person connection = new Person();
            string str1 = connection.connection();
            Console.WriteLine("enter table name ");
            string table_name = Console.ReadLine();
            
            try
            {

                conn = new SqlConnection(str1);
                conn.Open();

                if (conn.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand("TRUNCATE TABLE "+ table_name, conn);
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
       /* public Boolean Export_table(string table_name)
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
                    DataTable Dtnew = new DataTable();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM " + table_name, conn);
                    cmd.ExecuteNonQuery();
                    //conn.Close();
                    cmd.(Dtnew);
                    result = true;

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("something wrong." + ex);
            }
            return result;

        }*/
    }
}
