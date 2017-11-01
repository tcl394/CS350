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

# Functions
def create_user_file():
        open('user.csv','w')
        
def add_user(userid,name,email):

        user = user_list()
        user.append([userid,name,email])
        write_csv('user.csv', user)
        return user

def user_list():
        return read_csv('user.csv')



def user_email():
        user = user_list()
        print(user[1][1])
        

def user_email_display(userid):
        user = user_list()
        for i in user:
                ide = int(i[0])
                if ide == userid:
                        print(i[0] + ' ' + i[1] + ' ' +i[2])
                      

def delete_user():
        pass


     #   userInfo = open('user.csv','r')
    #    for line in userInfo:
    #            userInfo.write(line.replace([1],newEmail))
    #    userInfo.close()   
        


  

# Test building Article CRUD
def test_user_file():
        create_user_file()
        assert(exists('user.csv'))
	
def test_user_add():
        add_user('23','hello','hello@hello.com')

def test_user_email_display():
        user_email_display(23)


#=============================
  
def test_user_crud():
        test_user_file()
        test_user_add()
        test_user_email_display()


      
	# * CSV file Author 'Bill, Bill@Here.com'
	# * Add 'Sue' to User table
	# * Add list of other names (10 people)
	# * Read CSV records
	# * Print User email
	# * Change email
	# * Delete Use










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


# Run test
#if __name__ == '__main__' :
#    test_author_crud()
    #test_article_crud()

