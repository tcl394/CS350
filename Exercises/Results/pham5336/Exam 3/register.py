#register.py

from csv import reader, writer
from files import read_csv, read_file, write_csv, write_file
from friend import friend_list

def person_list():
    return read_csv('person.csv')
    

def person_register():
    print ("Welcome to Social Network!")
    print("Register new account!")
    loop = 'true'
    while (loop == 'true'):
        
        userID = input("Enter UserID:")
        userName = input("Enter UserName:")
        passWord = input("Enter Password:")
        person = person_list()
        friend = friend_list()
        
        if (userID != '') and (userName!='') and (passWord!=''):
            person.append([userID,userName,passWord])
            friend.append([userID])
            write_csv('person.csv',person)
            write_csv('friend.csv',friend)
            print('Registed Successfully!'+'\n')
            loop = 'false'
        else:
            print('Please enter required infomation!'+'\n')

