# crud.py
from os.path import exists
from os.path import exists
from files import read_csv, read_file, write_csv, write_file
from csv import reader, writer

## Pair Programming Guide
# * Work in Pairs (1 keyboard + 2 brains)
# * Switch for every iteration  (micro-story)
# * Test - Code - Refactor   (Fail, Pass, Beautify)
# * Typer - Talker
# * Check your ego at the door '?>  Cooperate
# * Save both product and test code
# * Execute all tests for each micro-story
# * Record a log of your time on each test
# * Use the main script hack to run your code directly
# * Finish with a beautiful module call social_net_crud.py



#=============================================================================

# * CSV file User 'Bill, Bill@Here.com'
	# * Add 'Sue' to User table
	# * Add list of other names (10 people)
	# * Read CSV records
	# * Print User email
	# * Change email
	# * Delete Use


# User CRUD
def create_user_file():
        open('user.csv','w')


def user_list():
        return read_csv('user.csv')
        userList = read_csv('user.csv')
        print(userList)
        
def add_user(userid,name,email):
        user = user_list()
        user.append([userid,name,email])
        write_csv('user.csv', user)
        return user


def user_email():
        user = user_list()
        for i in user:
                print(i[2])
        

def user_email_display(userID):
        user = user_list()
        for i in user:
                if int(i[0]) == userID:
                        print('User Name: ' + i[1] + '\nEmail: ' +i[2])
                      

def user_email_change(userID, newEmail):
        user = user_list()
        for i in user:
                if int(i[0]) == userID:
                        i[2] = newEmail
        write_csv('user.csv',user)
        

def delete_user(userID):
        user = user_list()
        for i in user:
                if int(i[0]) == userID:
                      user.remove(i)
        write_csv('user.csv',user)             


#=============================================================================
# Test building Article CRUD
def test_user_file():
        create_user_file()
        assert(exists('user.csv'))
	
def test_user_add():
        #add_user('1','teset1','tester1@hello.com')
        add_user('5','teset5','tester5@hello.com')
        #add_user('7','teset7','tester7@hello.com')
        
def test_user_list():
        user_list()
        
def test_user_email_display():
        #user_email_display(1)
        user_email_display(5)
        #user_email_display(7)
        
def test_user_email_change():
        #user_email_change(1, 'emailchanged@hello.com')
        user_email_change(5, 'emailchanged@hello.com')
        #user_email_change(7, 'emailchanged@hello.com')

def test_delete_user():
        add_user(2, 'tester2','tester2@hello.com')
        #delete_user(1)
        delete_user(5)
        #delete_user(7)



#=============================
# 1 test for all tests
def test_user_crud():
        test_user_file()
        test_user_add()
        test_user_list()
        test_user_email_display()
        test_user_email_change()
        test_delete_user()
      
#=============================================================================	














# Run test
#if __name__ == '__main__' :
#    test_user_crud()
   
