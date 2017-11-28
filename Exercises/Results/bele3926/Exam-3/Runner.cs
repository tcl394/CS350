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
    public class Runner
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("If you are new user enter R to registor ");
            Console.WriteLine("If you are already a user  enter L to login ");
            string chose = Console.ReadLine();
            Person person = new Person();
            if (chose.Equals("R"))
            {
                Console.WriteLine("Enter user first name");
                person.First_Name  = Console.ReadLine();
                Console.WriteLine("Enter user last name");
                person.Last_Name = Console.ReadLine();
                Console.WriteLine("Enter user email");
                person.E_mail = Console.ReadLine();
                Console.WriteLine("Enter user password");
                person.Pass_word = Console.ReadLine();
                person.Registration();
            }
            else if (chose.Equals("L"))
            {
                Console.WriteLine("Enter your email");
                string _email = Console.ReadLine();
                Console.WriteLine("Enter your password");
                string _password = Console.ReadLine();
                person.Login(_email, _password);
            }
            

        }
    }
}