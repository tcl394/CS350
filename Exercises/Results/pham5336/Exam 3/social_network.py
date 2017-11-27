#social_network.py

from os.path import exists
from csv import reader, writer
from files import read_csv, read_file, write_csv, write_file
from login import user_login
from register import person_register
from post import new_post,delete_post,display_post_file,add_post_from_user
from friend import add_friend, display_list_of_friend,remove_friend_from_list
from system import reset_data,export_to_txt, import_to_csv

def create_person_database():
    open('person.csv','w')
    assert(exists('person.csv'))
    
def create_post_database():
    open('post.csv','w')
    assert(exists('post.csv'))

def create_friend_list():
    open('friend.csv','w')
    assert(exists('friend.csv'))

def account_menu():
    print('Choose an option from menu:')
    print('  (1)  Login to Your Account')
    print('  (2)  Register New Account')
    accChoice = input('Option: ')
    return accChoice 

def hrline():
    print('=======================================================================')
menuLoop = 'true'
while(menuLoop == 'true'):
    accChoice = account_menu()
    if accChoice == '1':
        user_login()
        menuLoop = 'false'
            
    if accChoice == '2':
        person_register()
        user_login()
        menuLoop = 'false'
            
        
              
def user_menu():
    hrline()
    print('Choose an option from menu:')
    print('  (3)  Display post database')
    print('  (4)  Add a new post')
    print('  (5)  Delete a post')
    print('  (6)  Add a post from other user')
    print('  (7)  List friends')
    print('  (8)  Add a friend')
    print('  (9)  Remove a friend')
    print('  (R)  Reset all data files')
    print('  (E)  Export to txt files')
    print('  (I)  Import to csv files')
    print('  (X)  Exit program')
    hrline()
    userChoice = input('Option: ')
    return userChoice


menuLoop = 'true'
while(menuLoop == 'true'):
    userChoice = user_menu()    
    if userChoice == '3':
        display_post_file(),hrline()
    if userChoice == '4':
        new_post(),hrline()        
    if userChoice == '5':
        delete_post(),hrline()
    if userChoice == '6':
        add_post_from_user()
    if userChoice == '7':
        display_list_of_friend()
    if userChoice == '8':
        add_friend()
    if userChoice == '9':
        remove_friend_from_list()
    if userChoice == 'R' or userChoice == 'r':
        reset_data()
    if userChoice == 'E' or userChoice == 'e':
        export_to_txt()
    if userChoice == 'i' or userChoice == 'i':
        import_to_csv() 
    if userChoice == 'X' or userChoice == 'x':
        exit()

