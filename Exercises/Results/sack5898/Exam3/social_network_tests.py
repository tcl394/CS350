#social_network_test.py

#*****************************#
#       Lucas Sackrison       #
#       CS 350 - Exam 3       #
#      November 26, 2017      #
#*****************************#

from os.path import exists
from files import read_csv, read_file, write_csv, write_file

#*****************************#
#     User Function Tests     #
#*****************************#

def test_create_user1():
    testUser1 = user('Elon', 'Musk', 1)
    create_user(testUser1)
    
def test_create_user2():
    testUser2 = user('James', 'Franco', 2)
    create_user(testUser2)

def test_set_user():
    set_user(testUser)

#*****************************#
#     Post Function Tests     #
#*****************************#

def test_create_post():
    create_post('This is a text post')

def test_edit_post():
    edit_post(0,'This is the new text')

def test_delete_post():
    delete_post(0)

def test_list_posts():
    lists_posts(testUser)

#*****************************#
#  Friendship Function Tests  #
#*****************************#

def test_add_friendship():
    add_friendship(testUser1, testUser2)

def test_list_friends():
    list_friends(testUser1)

def test_remove_friendship():
    remove_friendship(testUser1, testUser2)

#*****************************#
#   System Function Tests     #
#*****************************#

def test_create_database_sheet():
    create_database_sheet()

def test_export_data():
    export_data()

def test_inport_data():
    inport_data()

#*****************************#
#        Run All Tests        #
#*****************************#

def run_all_tests():
    testSystem = system()
    test_create_database_sheet()
    test_create_user1()
    test_create_user2()
    test_set_user()
    test_create_post()
    test_edit_post()
    test_delete_post()
    test_list_posts()
    test_add_friendship()
    test_list_friends()
    test_remove_friendship()
    test_export_data()
    test_inport_data()

run_all_tests()


