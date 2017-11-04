# crud.py

from os.path import exists
from files import read_csv, read_file, write_csv, write_file

# Solution to CRUD puzzles

def create_author_file():
    open('author.csv', 'w').write('xxx')	

def add_author(name, email):
    authors = author_list()
    authors.append([name, email])
    write_csv('author.csv', authors)
    return authors

def author_list():
    return read_csv('author.csv')

def author_email(name):
    for a in author_list():
        if a[0] == name:
            return a[1]

def change_email():
    pass

def delete_author():
    pass


# --------------------------------------------------
# Tests 

# CSV file named 'author.csv' exists
def test_author_file_exists():
    create_author_file()
    assert(exists('author.csv'))


# Test author list
def test_author_file():
    #write_file('author.csv', 'Bill, Bill@Here.com')
    for a in author_list():
        print('    '.join(a))

    
# CSV file Author contains 'Bill,Bill@Here.com'
def test_author_bill():
    write_file('author.csv', 'Bill,Bill@Here.com')
    authors = author_list()
    assert(authors[0][0] == 'Bill')


# Add 'Sue' to Author table
def test_author_add():
    add_author('Sue', 'sue@here.com')

# Add list of other names (10 people)
def test_author_add_list():
    pass

# Read CSV records
def test_author_list():
    pass

# Print Author email
def test_author_email():
    #print(author_email('Bill'))
    assert(author_email('Bill') == 'Bill@Here.com')

# Change Bill's email
def test_change_email():
    assert(author_email('Sue') == 'Sue@Here.com')

# Delete Author Sue
def test_delete_author():
    pass


# Tests to write for Author CRUD
def test_author_crud():
    test_author_file_exists()
    test_author_bill()   
    test_author_add()    
    test_author_add_list()    
    test_author_list()    
    test_author_email()    
    test_change_email()    
    test_delete_author()
    test_author_file()
    

# Run test
if __name__ == '__main__' :
    test_author_crud()
