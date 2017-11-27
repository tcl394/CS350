#login.py

from csv import reader, writer
from files import read_csv, read_file, write_csv, write_file

def person_list():
    return read_csv('person.csv')
      
    
def user_login():
    print("Welcome to Social Network!")
    print("Login into network!")
    login = 'false'
    while(login == 'false'):
        username = input("Enter UserName: ")
        password = input("Enter Password: ")
        person = person_list()

        if (username!='') and (password!=''):       
            for i in person:
                if i[1] == username and i[2] == password:
                    login = 'true'
                    print('Login Successfully!'+'\n')
                    break
            else:
                print('Invalid infomation!')
    return person
    
                                    
        
