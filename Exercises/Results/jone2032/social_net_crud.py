# social_csv_crud.py
from os.path import exists
from files import read_csv, read_file, write_csv, write_file #REQUIRED!
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

#====================================================================
# Post CRUD
def create_post_file():
    open('post.csv','w')

def post_list():
    return read_csv('post.csv')


def display_post_file():
    post = post_list()
    print('Posts on file: \n')
    for p in post:
        print(p[0], ' ' , p[1], '\n ' ,p[2] , ' ',p[3])

    
def post_add(postID, title, textbody, userID):
    post = post_list()
    post.append([postID, title, textbody, userID])
    write_csv('post.csv', post)
    return post
    

def post_add_userID(postID, userID): #when do we need this?
    post = post_list()
    for p in post:
        if int(p[0]) == postID:
            p[3] = userID
    write_csv('post.csv', post)            
    

def post_list_by_userID(userID):
    post = post_list()
    for p in post:
        if int(p[3]) == userID:
            print('UserID: ', p[3] ,'\nPostID: ', p[0], '\nTitle: ', p[1],'\nBody: ', p[2], '\n==========================')
    

def post_textbody_change(postID, newText): #later add userID to confirm same profile
    post = post_list()
    for p in post:
        if int(p[0]) == postID:
            p[2] = newText
    write_csv('post.csv',post)
            

def delete_post(postID): # later add userID to confirm same profile
    post = post_list()
    for p in post:
        if int(p[0]) == postID:
            post.remove(p)
    write_csv('post.csv', post)


#====================================================================
    
# Post Testing

def test_post_file():
    create_post_file()
    assert(exists('post.csv'))
           
def test_post_list():
    post_list()

def test_display_post_file():
    display_post_file()

       
def test_post_add():
    post_add(4, 'Newtest1','Here is body of newtest1', 0)    
    post_add(5, 'Newtest2','Here is body of newtest2', 0)
    post_add(6, 'Newtest3','Here is body of newtest3', 0)
    post_add(7, 'Newtest4','Here is body of newtest4', 0)
    post_add(8, 'Newtest5','Here is body of newtest5', 0)
    post_add(9, 'Newtest6','Here is body of newtest6', 0)
    
def test_post_add_userID():
    post_add_userID(4, 20)
    post_add_userID(5, 20)
    post_add_userID(6, 23)
    post_add_userID(7, 20)
    post_add_userID(8, 30)
    post_add_userID(9, 23)

def test_post_list_by_userID():
    post_list_by_userID(20)
    #post_list_by_userID(23)
    post_list_by_userID(30)
    
def test_post_textbody_change():
    post_textbody_change(4, 'Changed text of newtest1')
    #post_textbody_change(5, 'Changed text of newtest2')
    post_textbody_change(6, 'Changed text of newtest3')
    
def test_delete_post():
    #delete_post(4)
    delete_post(5)
    #delete_post(6)
#====================================================================
#====================================================================
    
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

#====================================================================
        
# Test building User CRUD
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



#====================================================================
#====================================================================
  

# Test building Article CRUD

def test_user_crud():

       
	# Tests to write for Author CRUD

	# A CSV file exists
	
	#from os.path import exists
	#assert(exists('Author.csv'))

	# * CSV file Author 'Bill, Bill@Here.com'
	# * Add 'Sue' to Author table
	# * Add list of other names (10 people)
	# * Read CSV records
	# * Print Author email
	# * Change email
	# * Delete Author
        print('TEST FOR USER CRUD','\n=============================')
        test_user_file()
        test_user_add() #create
        test_user_list() #read
        test_user_email_display()
        test_user_email_change() #update
        test_delete_user() #delete
        print('\n')
        
def test_post_crud():
        print('TEST FOR POST CRUD','\n=============================')
	# * CSV file Article 'Rattlesnakes, I hate snakes'
	# * Print Article list
	# * Add Article 'Kittens, Kittens are Fuzzy'
	# * Add author_id of 4 to Articles
	# * Print Articles showing Author names
	# * Select articles for Author 4
	# * Lookup '4, Kittens'
	# * Change 'Kittens' body to 'Kittens are cute!'
	# * Remove Article
	# * Remove Author

	#text = "line1\nline2"
	#path = 'test.txt'
	#write_file(path, text)
	#t = read_file(path)
	#print('text:'+text+'$')
	#print('t:'+t+'$')
	#assert(t==text)
	#assert(t!=text)

        test_post_file()
        test_post_list() #read
        test_display_post_file()
        test_post_add() #create
        test_post_add_userID()
        test_post_list_by_userID()
        test_post_textbody_change() #update
        test_delete_post() #delete
        test_display_post_file()


# Run test
if __name__ == '__main__' :
    test_user_crud()
    test_post_crud()

