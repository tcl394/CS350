using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Media_Newby
{
    //Social_Media - Exam 3
    //Christopher Newby
    //CS 350 - Fall 2017
    //Professor Mark Seaman

    class System_Mod
    {
        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@//
        //@@@@@@@@@@@@@@@@@@@@@@@@@@ API FUNCTION CALLS BELOW THIS LINE @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@//
        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@//

        //Clears all data (local & persistent)
        public void Reset_All_Data()
        {
            //Clear local list storage
            Data_Store.person_list.Clear();

            Data_Store.friends_list.Clear();

            Data_Store.posts_list.Clear();

            //Clear local string array test results
            Array.Clear(Data_Store.person_test_results, 0, Data_Store.person_test_results.Length);

            Array.Clear(Data_Store.friend_test_results, 0, Data_Store.friend_test_results.Length);

            Array.Clear(Data_Store.post_test_results, 0, Data_Store.post_test_results.Length);

            //Clear local temporary list storage
            Data_Store.person_list_test.Clear();

            Data_Store.friend_list_test.Clear();

            Data_Store.post_list_test.Clear();

            //GO CLEAR THE DATA FROM FILES HERE
        }

        //Master Import/Export function calls
        public void Export_Data(List<Person> person, List<Friend> friend, List<Post> post)
        {
            string desktop_path = Get_Desktop_Path();

            List<object> result1 = person.Cast<object>().ToList();

            Write_To_CSV(result1, "Person", "Person");

            List<object> result2 = friend.Cast<object>().ToList();

            Write_To_CSV(result2, "Friend", "Friend");

            List<object> result3 = post.Cast<object>().ToList();

            Write_To_CSV(result3, "Post", "Post");
        }

        public void Import_Data()
        {
            Read_From_CSV("Person","Person");

            Read_From_CSV("Friend", "Friend");

            Read_From_CSV("Post", "Post");
        }

        //Gets the path of the desktop for any computer its run on, used for
        public string Get_Desktop_Path()
        {
            return Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory);
        }

        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@//
        //@@@@@@@@@@@@@@@@@@@@@@@@@@ API FUNCTION CALLS ABOVE THIS LINE @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@//
        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@//


        //--------------------------------------------------------------------------------------------//
        //--------------------- PRIVATE CLASS FUNCTION CALLS BELOW THIS LINE -------------------------//
        //--------------------------------------------------------------------------------------------//

        //Convert from different classes of objects to lines in CSV format
        private string Convert_Person_To_CSV(Person p)
        {
            return (p.Get_Person_ID().ToString() + "," + p.Get_Username() + "," + p.Get_PW() + "," + p.Get_FN() + "," + p.Get_LN());
        }

        private string Convert_Friend_To_CSV(Friend f)
        {
            return (f.Get_First_Person().ToString() + "," + f.Get_Second_Person().ToString());
        }

        private string Convert_Post_To_CSV(Post p)
        {
            return (p.Get_Post_ID().ToString() + "," + p.Get_Post_Topic() + "," + p.Get_Author_ID().ToString() +
                "," + p.Get_ReferredBy_ID().ToString() + "," + p.Get_Post_Body());
        }


        //Convert from lines in CSV file format to different classes of objects
        private Person Convert_CSV_To_Person(string line)
        {
            string[] data = line.Split(',');

            Person new_person = new Person(Convert.ToInt32(data[0]), data[1], data[2], data[3], data[4]);

            return new_person;    
        }

        private Friend Convert_CSV_To_Friend(string line)
        {
            string[] data = line.Split(',');

            Friend new_friend = new Friend(Convert.ToInt32(data[0]), Convert.ToInt32(data[1]));

            return new_friend;
        }

        private Post Convert_CSV_To_Post(string line)
        {
            string[] data = line.Split(',');

            Post new_post = new Post(Convert.ToInt32(data[0]), data[1], Convert.ToInt32(data[2]), Convert.ToInt32(data[3]), data[4]);

            return new_post;
        }


        //Takes in a generic object list, a string saying what type of object should be, and the filename you wish to use for it
        private void Write_To_CSV(List<object> list, string object_type, string file_name)
        {
            try
            {
                string file_path = Get_Desktop_Path() + "\\" + file_name + ".txt";

                string data = "";

                Erase_Data_Files(file_name);

                if (object_type.Equals("Person"))
                {
                    List<Person> result = list.Cast<Person>().ToList();

                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(file_path))
                    {
                        for (int i = 0; i < result.Count; i++)
                        {
                            data = Convert_Person_To_CSV(result[i]);

                            file.WriteLine(data);

                            //data = "";
                        }
                    }
                }
                else if (object_type.Equals("Friend"))
                {
                    List<Friend> result = list.Cast<Friend>().ToList();

                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(file_path))
                    {
                        for (int i = 0; i < result.Count; i++)
                        {
                            data = Convert_Friend_To_CSV(result[i]);

                            file.WriteLine(data);

                            //data = "";
                        }
                    }
                }
                else if (object_type.Equals("Post"))
                {
                    List<Post> result = list.Cast<Post>().ToList();

                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(file_path))
                    {
                        for (int i = 0; i < result.Count; i++)
                        {
                            data = Convert_Post_To_CSV(result[i]);

                            file.WriteLine(data);

                            //data = "";
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Unknown object type detected.");

                    return;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong writing to your CSV file");
            }
        }


        //Read from file and convert the CSV formatted items into their individual object types, and add them to the local lists
        private void Read_From_CSV(string object_type, string file_name)
        {
            try
            {
                string file_path = Get_Desktop_Path() + "\\" + file_name + ".txt";

                List<string> incoming = new List<string>();

                if (object_type.Equals("Person"))
                {
                    using (StreamReader sr = new StreamReader(file_path))
                    {
                        // Read the stream to a string
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();

                            incoming.Add(line);
                        }
                    }
                    for(int i = 0; i< incoming.Count; i++)
                    {
                        Person new_person = Convert_CSV_To_Person(incoming[i]);

                        Data_Store.person_list.Add(new_person);
                    }
                }
                else if(object_type.Equals("Friend"))
                {
                    using (StreamReader sr = new StreamReader(file_path))
                    {
                        // Read the stream to a string
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();

                            incoming.Add(line);
                        }
                    }
                    for (int i = 0; i < incoming.Count; i++)
                    {
                        Friend new_friend = Convert_CSV_To_Friend(incoming[i]);

                        Data_Store.friends_list.Add(new_friend);
                    }
                }
                else if (object_type.Equals("Post"))
                {
                    using (StreamReader sr = new StreamReader(file_path))
                    {
                        // Read the stream to a string
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();

                            incoming.Add(line);
                        }
                    }
                    for (int i = 0; i < incoming.Count; i++)
                    {
                        Post new_post = Convert_CSV_To_Post(incoming[i]);

                        Data_Store.posts_list.Add(new_post);
                    }
                }
                else
                {
                    Console.WriteLine("The CSV you're trying to read is unrecognized.");

                    return;
                }
            }
            catch (Exception)
            {

            }
        }


        //Checks if a file exists, deletes if it exists
        private void Erase_Data_Files(string file_name)
        {
            string file_path = Get_Desktop_Path() + "\\" + file_name + ".txt";

            if (File.Exists(file_path))
            {
                File.Delete(file_path);
            }
        }

        //--------------------------------------------------------------------------------------------//
        //--------------------- PRIVATE CLASS FUNCTION CALLS ABOVE THIS LINE -------------------------//
        //--------------------------------------------------------------------------------------------// 
    }
}
