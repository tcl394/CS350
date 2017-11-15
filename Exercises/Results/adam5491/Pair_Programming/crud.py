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
from os.path import exists
from files import read_csv, read_file, write_csv, write_file

def create_author_file():
    open('author.csv', 'w').write('xxx')

def add_author(name, email):
    authors=author_list()
    authors.append([name, email])
    write_csv('author.csv', authors)
    return authors

def author_list():
    return read_csv('author.csv')


                        
## Tests
# Test building Article CRUD
def test_author_crud():

	# Tests to write for Author CRUD

	# CSV file named 'author.csv' exists
	
	from os.path import exists
	assert(exists('author.csv'))

	# CSV file Author contains 'Bill, Bill@Here.com'
	# Add 'Sue' to Author table

	test_author_add()
	
	# Add list of other names (10 people)
	# Read CSV records
	# Print Author email
	# Change Bill's email
	# Delete Author Sue


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

def test_author_add():
    add_author('Sue', 'Sue@Here.com')

# Run test
if __name__ == '__main__' :
    test_author_crud()
    #test_article_crud()
