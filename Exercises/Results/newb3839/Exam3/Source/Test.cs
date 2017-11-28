using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Social_Media_Newby
{
    //*****************************************************************************************************//
    //************************* DEVELOPMENT MOVES AT THE SPEED OF TEST ************************************//
    //*****************************************************************************************************//

    //Social_Media - Exam 3
    //Christopher Newby
    //CS 350 - Fall 2017
    //Professor Mark Seaman

    class Test
    {
        //========================= TEST DATA & LISTS - LOCAL TEST DATA =============================//
        private Person test_person = new Person(1, "Jdoe", "abc123", "John", "Doe");

        private Person test_person1 = new Person(2, "BMan", "123abc", "Barry", "Mannilow");

        private Person test_person2 = new Person(3, "ElRoy", "111abc", "Chuck", "Winslow");

        private Person test_person3 = new Person(4, "BBad", "765qwe", "Javier", "Perez");

        private Friend test_friend = new Friend(2, 1);

        private Friend test_friend1 = new Friend(3, 2);

        private Friend test_friend2 = new Friend(1, 4);

        private Friend test_friend3 = new Friend(4, 3);

        private Post test_post = new Post(1, "ChaCha", 1, 2, "Me likey do da cha cha");

        private Post test_post1 = new Post(2, "ChaCha", 2, 2, "Me likey do da cha cha too");

        private Post test_post2 = new Post(3, "T.P.", 3, 2, "Is 'quilted northern' better than 'cottonelle' toilet paper?");

        private Post test_post3 = new Post(4, "Jello", 4, 4, "Does anyone else hate green jello?!!!");

        private List<Person> person_test_list = new List<Person>();

        private List<Friend> friends_test_list = new List<Friend>();

        private List<Post> posts_test_list = new List<Post>();


        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@//
        //@@@@@@@@@@@@@@@@@@@@@@@@@@ API FUNCTION CALLS BELOW THIS LINE @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@//
        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@//


        //Run master test function call
        public void Run_Master_Test()
        {
            //Execute all test functions
            Person_Registration_Test(1, "abc", "123", "test", "person");

            Person_Login_Test(1, ""); //<---PASS      FAIL ---> //person_login_test(1, "000"); 

            Friend_List_Creation_Test();

            New_Friendship_Test(test_friend);

            Remove_Friendship_Test(test_friend);

            List_All_Posts();

            Add_Topic_From_Friend(test_post);

            Remove_Topic_From_List(test_post);

            Reset_All_Data_Test();

            Export_Data_Test(Data_Store.person_list, Data_Store.friends_list, Data_Store.posts_list);

            Import_Data_Test();
        }

        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@//
        //@@@@@@@@@@@@@@@@@@@@@@@@@@ API FUNCTION CALLS ABOVE THIS LINE @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@//
        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@//

        //--------------------------------------------------------------------------------------------//
        //--------------------- PRIVATE CLASS FUNCTION CALLS BELOW THIS LINE -------------------------//
        //--------------------------------------------------------------------------------------------//

        //====================== PERSON TEST BLOCK ========================//

        //Tests that a user can register to use the system
        private void Person_Registration_Test(int p_ID, string p_uname, string p_pword, string p_fname, string p_lname)
        {
            try
            {
                Data_Store.person_list.Clear();

                Person new_person = new Person(p_ID, p_uname, p_pword, p_fname, p_lname);

                Data_Store.person_list.Add(new_person);

                Data_Store.person_test_results[0] = "Pass";
            }
            catch (Exception)
            {
                Data_Store.person_test_results[0] = "Fail";

                return;
            }
        }

        //Tests that the user can log in using their person ID and password
        private void Person_Login_Test(int p_ID, string p_pword)
        {
            try
            {
                int pID = Data_Store.person_list[0].Get_Person_ID();

                string pw = Data_Store.person_list[0].Get_PW();

                if (Data_Store.person_list[p_ID-1].Person_Login(p_ID, p_pword))
                {
                    Data_Store.person_test_results[1] = "Pass";
                }
                else
                {
                    Data_Store.person_test_results[1] = "Fail";
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        //====================== FRIEND TEST BLOCK ========================//

        //Tests if you can create a list of 
        private void Friend_List_Creation_Test()
        {
            try
            {
                Data_Store.friends_list.Clear(); //Make sure it's clear first!

                Add_Friend_To_List();

                if (Data_Store.friends_list.Count == 4)
                {
                    Data_Store.friend_test_results[0] = "Pass";
                }
                else
                {
                    Data_Store.friend_test_results[0] = "Fail";
                }
            }
            catch (Exception)
            {
                Data_Store.friend_test_results[0] = "Fail";
                return;
            }

        }

        //Tests if a user can add a new friendship to a list
        private void New_Friendship_Test(Friend new_fship)
        {
            try
            {
                List<Friend> temp = Data_Store.friends_list;

                int preTempCount = temp.Count();

                temp.Add(new_fship);

                int postTempCount = temp.Count();

                if (preTempCount != postTempCount)
                {
                    Data_Store.friend_test_results[1] = "Pass";
                }
                else
                {
                    Data_Store.friend_test_results[1] = "Fail";
                }
            }
            catch (Exception)
            {
                Data_Store.friend_test_results[1] = "Fail";

                return;
            }
        }

        //Tests the removal of a friend object from list
        private void Remove_Friendship_Test(Friend rem_fship)
        {
            try
            {
                List<Friend> temp = Data_Store.friends_list;

                int preListCount = temp.Count();

                temp.Remove(rem_fship);

                int postListCount = temp.Count();

                if (preListCount != postListCount)
                {
                    Data_Store.friend_test_results[2] = "Pass";
                }
                else
                {
                    Data_Store.friend_test_results[2] = "Fail";
                }
            }
            catch (Exception)
            {
                Data_Store.friend_test_results[2] = "Pass";

                return;
            }
        }

        private void List_All_Posts()
        {
            Add_Post_To_List();
            
            List<Post> temp = Data_Store.posts_list;

            if(temp.Count == 4)
            {
                Data_Store.post_test_results[0] = "Pass";
            }
            else
            {
                Data_Store.post_test_results[0] = "Fail";
            }
        }

        private void Add_Topic_From_Friend(Post p)
        {
            Data_Store.posts_list.Clear();

            Data_Store.posts_list.Add(p);

            if (!Data_Store.posts_list[0].Get_Author_ID().Equals(Data_Store.posts_list[0].Get_ReferredBy_ID()))
            {
                Data_Store.post_test_results[1] = "Pass";
            }
            else
            {
                Data_Store.post_test_results[1] = "Fail";
            }
        }

        private void Remove_Topic_From_List(Post p)
        {
            Data_Store.posts_list.Clear();

            int preCount = Data_Store.posts_list.Count();

            Data_Store.posts_list.Add(p);

            int midCount = Data_Store.posts_list.Count();

            Data_Store.posts_list.Remove(p);

            int postCount = Data_Store.posts_list.Count();

            if(preCount == postCount)
            {
                Data_Store.post_test_results[2] = "Pass";
            }
            else
            {
                Data_Store.post_test_results[2] = "Fail";
            }
        }

        private void Reset_All_Data_Test()
        {
            Add_Persons_To_List();

            Add_Friend_To_List();

            Add_Post_To_List();

            int[] beforeCount = new int[3];

            beforeCount[0] = Data_Store.person_list.Count();

            beforeCount[1] = Data_Store.friends_list.Count();

            beforeCount[2] = Data_Store.posts_list.Count();

            System_Mod test = new System_Mod();

            test.Reset_All_Data();

            int[] afterCount = new int[3];

            afterCount[0] = Data_Store.person_list.Count();

            afterCount[1] = Data_Store.friends_list.Count();

            afterCount[2] = Data_Store.posts_list.Count();


            for (int i = 0; i < 3; i++)
            {
                if (beforeCount[i] != afterCount[i])
                {
                    Data_Store.system_mod_test_results[0] = "Pass";
                }
                else
                {
                    Data_Store.system_mod_test_results[0] = "Fail";
                }
            }
        }


        private void Export_Data_Test(List<Person> p_list, List<Friend> f_list, List<Post> pst_list)
        {
            Add_Persons_To_List();

            Add_Friend_To_List();

            Add_Post_To_List();

            List<object> obj = p_list.Cast<object>().ToList();

            System_Mod test = new System_Mod();

            test.Export_Data(p_list, f_list, pst_list);

            string path = test.Get_Desktop_Path() + "\\Person.txt";

            if (File.Exists(path))
            {
                Data_Store.system_mod_test_results[1] = "Pass";
            }
            else
            {
                Data_Store.system_mod_test_results[1] = "Fail";
            }
        }

        private void Import_Data_Test()
        {
            System_Mod test = new System_Mod();

            test.Reset_All_Data();

            test.Import_Data();

            if(Data_Store.posts_list.Count == 4)
            {
                Data_Store.system_mod_test_results[2] = "Pass";
            }
            else
            {
                Data_Store.system_mod_test_results[2] = "Fail";
            }
        }
        //==================== TEST OBJECT LIST LOADING METHODS =======================//
        private void Add_Persons_To_List()
        {
            Data_Store.person_list.Add(test_person);

            Data_Store.person_list.Add(test_person1);

            Data_Store.person_list.Add(test_person2);

            Data_Store.person_list.Add(test_person3);
        }

        private void Add_Friend_To_List()
        {
            Data_Store.friends_list.Add(test_friend);

            Data_Store.friends_list.Add(test_friend1);

            Data_Store.friends_list.Add(test_friend2);

            Data_Store.friends_list.Add(test_friend3);
        }

        private void Add_Post_To_List()
        {
            Data_Store.posts_list.Add(test_post);

            Data_Store.posts_list.Add(test_post1);

            Data_Store.posts_list.Add(test_post2);

            Data_Store.posts_list.Add(test_post3);
        }

        //--------------------------------------------------------------------------------------------//
        //--------------------- PRIVATE CLASS FUNCTION CALLS ABOVE THIS LINE -------------------------//
        //--------------------------------------------------------------------------------------------//
    }
}
