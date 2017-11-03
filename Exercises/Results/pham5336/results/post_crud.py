#post_crud

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
#def test_post_crud():

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

# Post CRUD
def create_post_file():
    open('post.csv','w')

def post_list():
    return read_csv('post.csv')


def display_post_file():
    post = post_list()
    print('Posts on file:')
    for p in post:
        print(p[0], ' ' , p[1], ' ' ,p[2] , ' ',p[3])

    
def post_add(postID, title, textbody, userID):
    post = post_list()
    post.append([postID, title, textbody, userID])
    write_csv('post.csv', post)
    return post
    

def post_add_userID(postID, userID):
    post = post_list()
    for p in post:
        if int(p[0]) == postID:
            p[3] = userID
    write_csv('post.csv', post)            
    

def post_list_by_userID(userID):
    post = post_list()
    for p in post:
        if int(p[3]) == userID:
            print('UserID: ', p[3] ,'\nPostID: ', p[0], '\nTitle: ', p[1],'\nBody ', p[2], '\n==========================')
    

def post_textbody_change(postID, newText):
    post = post_list()
    for p in post:
        if int(p[0]) == postID:
            p[2] = newText
    write_csv('post.csv',post)
            

def delete_post(postID):
    post = post_list()
    for p in post:
        if int(p[0]) == postID:
            post.remove(p)
    write_csv('post.csv', post)




#=============================================================================
#Testing

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
    

#=============================================================================
# 1 test for all tests
def test_post_crud():
    test_post_file()
    test_post_list()
    test_display_post_file()
    test_post_add()
    test_post_add_userID()
    test_post_list_by_userID()
    test_post_textbody_change()
    test_delete_post()
    test_display_post_file()
    
    
    
    



    
