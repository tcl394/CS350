# crud.py

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
  

# Test building Article CRUD
def test_author_crud():

	# Tests to write for Author CRUD

	# A CSV file exists
	
	from os.path import exists
	create_author_file()
	assert(exists('author.csv'))

	# * CSV file Author 'Bill, Bill@Here.com'
	# * Add 'Sue' to Author table
	# * Add list of other names (10 people)
	# * Read CSV records
	# * Print Author email
	# * Change email
	# * Delete Author


def test_article_crud():

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

	text = "line1\nline2"
	path = 'test.txt'
	write_file(path, text)
	t = read_file(path)
	print('text:'+text+'$')
	print('t:'+t+'$')
	assert(t==text)
	assert(t!=text)

def change_email():
        return

def author_crud():
        
        return

def article_crud():
        
        return

def create_author_file():
        open('author.csv', 'w').write('xxx')
        
def add_author():
        
        return

# Run test
if __name__ == '__main__' :
    test_author_crud()
    #test_article_crud()

