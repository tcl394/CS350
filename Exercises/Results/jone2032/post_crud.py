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
#def test_article_crud():

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

def post_add(postID, title, textbody, userID):
    # generate postID later
    pass

def post_add_userID(postID):
    pass

def post_list_by_userID(userID):
    pass

def post_textbody_change(postID):
    pass

def delete_post(postID):
    pass




#=============================================================================
#Testing

def test_post_file():
    create_post_file()
    assert(exists('post.csv'))
           
def test_post_list():
    print (post_list())
    
    
def test_post_add():
	# post_add(1, "My Post", "this is my first post!", 1)
    pass

def test_post_add_userID():
    pass

def test_post_list_by_userID():
    pass

def test_post_textbody_change():
    pass

def test_delete_post():
    pass





















#=============================================================================
# 1 test for all tests
