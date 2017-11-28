using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Media_Newby
{
    class Friend
    {
        //Social_Media - Exam 3
        //Christopher Newby
        //CS 350 - Fall 2017
        //Professor Mark Seaman


        //Encapsulate class variables
        private int person_ID_1 { get; set; }
        private int person_ID_2 { get; set; }


        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@//
        //@@@@@@@@@@@@@@@@@@@@@@@@@@ API FUNCTION CALLS BELOW THIS LINE @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@//
        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@//

        //Public Constructor
        public Friend(int p_ID_1, int p_ID_2)
        {
            //self - friend
            person_ID_1 = p_ID_1;
            person_ID_2 = p_ID_2;
        }

        //Get methods for extracting object information
        public int Get_First_Person()
        {
            return person_ID_1;
        }
        public int Get_Second_Person()
        {
            return person_ID_2;
        }

        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@//
        //@@@@@@@@@@@@@@@@@@@@@@@@@@ API FUNCTION CALLS ABOVE THIS LINE @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@//
        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@//


        //--------------------------------------------------------------------------------------------//
        //--------------------- PRIVATE CLASS FUNCTION CALLS BELOW THIS LINE -------------------------//
        //--------------------------------------------------------------------------------------------//

        //Add/Remove methods
        private void Add_Friend(Friend f)
        {
            Data_Store.friends_list.Add(f);
        }

        private void Remove_Friend(Friend f)
        {
            Data_Store.friends_list.Remove(f);
        }

        //Find person's friends by using their own ID to search for instances of friendships
        private List<Friend> Get_Person_Friend_List(int p_ID)
        {
            List<Friend> temp = new List<Friend>();
            for (int i = 0; i < Data_Store.friends_list.Count; i++)
            {
                if (Data_Store.friends_list[i].person_ID_1 == p_ID || Data_Store.friends_list[i].person_ID_2 == p_ID)
                {
                    temp.Add(Data_Store.friends_list[i]);
                }
            }
            return temp;
        }

        //--------------------------------------------------------------------------------------------//
        //--------------------- PRIVATE CLASS FUNCTION CALLS ABOVE THIS LINE -------------------------//
        //--------------------------------------------------------------------------------------------//
    }
}
