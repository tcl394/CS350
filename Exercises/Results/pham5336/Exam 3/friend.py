#friend.py


from csv import reader, writer
from files import read_csv, read_file, write_csv, write_file

def friend_list():
    return read_csv('friend.csv')

def add_friend():
    friend = friend_list()
    print('Add friend to list!')
    userID = input('Enter user ID: ')
    friendID = input('Enter friend ID: ')
    if (userID!='')and(friendID!=''):
        for f in friend:
            if userID == f[0] in f:
                f.append(friendID)
        write_csv('friend.csv',friend)
    else:pass    
                    
def display_list_of_friend():
    friend = friend_list()
    print('List of users''friends')
    userID = input('Enter user ID: ')
    if userID!='':
        for f in friend:
            if userID == f[0]:
                print('Friend of user ' + f[0],': ',f[1:])
    else:pass
        
def remove_friend_from_list():
    friend = friend_list()
    print('Remove a friend from friend list:')    
    userID = input('Enter user ID: ')
    friendID = input('Enter friend ID: ')
    if (userID!='')and(friendID!=''):
        for f in friend:
            if userID == f[0] in f:
                f.remove(friendID)     
        write_csv('friend.csv',friend)
    else:pass



        
