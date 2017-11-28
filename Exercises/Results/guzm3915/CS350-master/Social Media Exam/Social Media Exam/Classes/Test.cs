using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Social_Media_Exam.Classes;
using System.Diagnostics;

namespace Social_Media_Exam
{
    class Test
    {
        static void Main(string[] args)
        {
            test_addFriendPerson();
            test_addFriendship();
            test_addPost();
            test_addTopic();
            test_exportData();
            test_importData();
            test_listTopic();
            test_removeFriendPerson();
            test_removeFriendship();
            test_removePost();
            test_removeTopic();
            test_resetData();
            test_viewFriendship();
        }
        static void test_resetData()
        {
            Debug.Assert(SystemFunc.resetData());
        }
        static void test_importData()
        {
            Debug.Assert(SystemFunc.importData());
        }
        static void test_exportData()
        {
            Debug.Assert(SystemFunc.exportData());
        }
        static void test_listTopic()
        {
            Debug.Assert(Post.listTopic());
        }
        static void test_addTopic()
        {
            Debug.Assert(Post.addTopic("Topic Test"));
        }
        static void test_removeTopic()
        {
            Debug.Assert(Post.removeTopic("Topic Test"));
        }
        static void test_viewFriendship()
        {
            Debug.Assert(Friend.viewFriend());
        }
        static void test_addFriendship()
        {
            Debug.Assert(Friend.newFriendship("Test Friend"));
        }
        static void test_removeFriendship()
        {
            Debug.Assert(Friend.removeFriendship("Test Friend"));
        }
        static void test_addFriendPerson()
        {
            Debug.Assert(Person.addFriend("Person Add Friend Test"));
        }
        static void test_removeFriendPerson()
        {
            Debug.Assert(Person.removeFriend("Person Add Friend Test"));
        }
        static void test_addPost()
        {
            Debug.Assert(Person.addPost(1));
        }
        static void test_removePost()
        {
            Debug.Assert(Person.removePost(1));
        }
    }
}
