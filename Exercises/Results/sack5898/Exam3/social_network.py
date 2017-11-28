#social_network.py

#*****************************#
#       Lucas Sackrison       #
#       CS 350 - Exam 3       #
#      November 26, 2017      #
#*****************************#

from os.path import exists
from files import read_csv, read_file, write_csv, write_file

#*****************************#
#    User Class/Functions     #
#*****************************#

class user:
    def __init__(self, firstName, lastName, userID):
        self.firstName = firstName
        self.lastName = lastName
        self.userID = userID

    def create_user(user, system):
        system.ALLUSERS.append(user)

    def set_user(user, system):
        system.CURRENTUSERID = self.userID

    def get_user_ID(self):
        return self.userID
        
#*****************************#
#    Post Class/Functions     #
#*****************************#

class post:
    def __init__(self, system, text):
        self.userID = system.CURRENTUSERID
        self.text = text

    def change_text(self, text):
        self.text = text

    def create_post(post, system):
        system.ALLPOSTS.append([system.CURRENTUSERID,post])

    def edit_post(postID, system, newText):
        system.ALLPOSTS[postID].change_text(newText)

    def delete_post(postID, system):
        del system.ALLPOSTS[postID]

    def list_posts(user, system):
        for entry in system.ALLPOSTS:
            if entry[0] == user.userID:
                print (entry[1])
                
#*****************************#
# Friendship Class/Functions  #
#*****************************#

class friendship:
    def __init__(self, user1, user2):
        self.friendPair = [user1, user2]

    def add_friendship(system):
        system.ALLFRIENDSHIPS.append(friendPair)

    def list_friends(userID, system):
        for pair in system.ALLFRIENDSHIPS:
            if pair[0].get_user_ID == userID:
                print (pair[1])
            elif pair[1].get_user_ID == userID:
                print (pair[0])

    def remove_friendship(userID1, userID2, system):
        i = 0
        for pair in system.ALLFRIENDSHIPS:
            if pair[0].get_user_ID == userID1 and pair[1].get_user_ID == userID2 or pair[0].get_user_ID == userID2 and pair[1].get_user_ID == userID1:
                del system.ALLFRIENDSHIPS[i]
            i = i + 1

#*****************************#
#   System Class/Functions    #
#*****************************#

class system:
    def __init__(self):
        self.ALLUSERS = []
        self.ALLPOSTS = []
        self.ALLFRIENDSHIPS = []
        self.CURRENTUSERID = 0

    def create_database_sheet():
        open('database.csv', 'w').write('xxx')

    def export_data():
        write_csv('database.csv', ALLUSERS, ALLPOSTS, ALLFRIENDSHIPS)
        
    def import_data():
        read_csv('database.csv', ALLUSERS, ALLPOSTS, ALLFRIENDSHIPS)

