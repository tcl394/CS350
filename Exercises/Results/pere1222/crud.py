#Pair programmed by: Jonathan Mier & Jose Perez 
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

import csv
import os


def create_author_table():
    open('author.csv','w').write('')
    
def add_author_table(author, email):
    with open('author.csv', 'a') as newFile:
        newFileWriter = csv.writer(newFile)
        newFileWriter.writerow([author, email])

def add_mulitple_authors(authors):
    with open('author.csv', 'a') as newFile:
        newFileWriter = csv.writer(newFile)
        for author in authors:
            newFileWriter.writerow([author, authors[author]])
def read_authors():
    with open('author.csv') as csvDataFile:
        csvReader = csv.reader(csvDataFile)
        for row in csvReader:
            if (row):
                print(row)
            
def print_author_email(author):
    with open('author.csv') as csvDataFile:
        csvReader = csv.reader(csvDataFile)
        for row in csvReader:
            for value in row:
                if (value == author):
                    print(row[1])
                    
def change_author_email(author, new_email):
    r = csv.reader(open('author.csv'))
    lines = [l for l in r]
    count = 0
    for line in lines:
        for value in line:
            if (value == author):
                lines[count][1] = new_email
        count += 1
        
    open('author.csv','w').write('')
    with open('author.csv', 'a') as newFile:
        newFileWriter = csv.writer(newFile)
        for line in lines:
            if (line):
                newFileWriter.writerow(line)
                
def delete_author(author):
    r = csv.reader(open('author.csv'))
    lines = [l for l in r]
    count = 0
    for line in lines:
        for value in line:
            if (value == author):
                lines[count][0] = ''
                lines[count][1] = ''
        count += 1
        
    open('author.csv','w').write('')
    with open('author.csv', 'a') as newFile:
        newFileWriter = csv.writer(newFile)
        for line in lines:
            if (line):
                newFileWriter.writerow(line)
        
# Test building Article CRUD
def test_author_crud():

    # Tests to write for Author CRUD

    # A CSV file exists
    from os.path import exists
    create_author_table()
    assert(exists('author.csv'))

    # * CSV file Author 'Bill, Bill@Here.com'
    add_author_table('Bill', 'bill@here.com')
    # * Add 'Sue' to Author table
    add_author_table('Sue', 'sue@here.com')
    # * Add list of other names (10 people)
    authors = {"Jon":"jon@here.com",
               "Jane":"jane@here.com",
               "Jill":"jill@here.com",
               "Jim":"jim@here.com",
               "Jack":"jack@here.com",
               "Jerry":"jerry@here.com",
               "Bob":"bbo@here.com",
               "Berry":"berry@here.com",
               "Tod":"tod@here.com",
               "Al":"al@here.com"}
    add_mulitple_authors(authors)
    # * Read CSV records
    read_authors()
    # * Print Author email
    print_author_email('Jim')
    # * Change email
    change_author_email('Jim', 'jimmy@here.com')
    # * Delete Author
    delete_author('Jon')

def open_CSV():
    open('articles.csv','w').write('Rattlesnakes, I hate snakes')

def print_article():
    ifile  = open('articles.csv', "r", encoding='UTF8')
    read = csv.reader(ifile)
    for row in read :
        print (row) 

def add_articles():
    open('articles.csv','a').write('Kittens, Kittens are Fuzzy')

def write_article(text):
    open('articles.csv','a').write(text)

def add_authors():
    multiline = os.linesep + 'author_id1' + os.linesep + 'author_id2' + os.linesep + 'author_id3' + os.linesep + 'author_id4'
    open('articles.csv','a').write(multiline)
    

def print_articles_authors():
    ifile  = open('articles.csv', "r", encoding='UTF8')
    read = csv.reader(ifile)
    for row in read :
        print (row)

def remove_article():
    open('articles.csv','a').write('')


def remove_authors():
    open('articles.csv','a').write('')


def test_article_crud():

    # * CSV file Article 'Rattlesnakes, I hate snakes'
    open_CSV()
    # * Print Article list   
    print_article()
    # * Add Article 'Kittens, Kittens are Fuzzy'
    add_articles()
    #write.('Kittens, Kittens are Fuzzy')
    write_article('Kittens, Kittens are Fuzzy')
    # * Add author_id of 4 to Articles
    add_authors()
    # * Print Articles showing Author names
    print_articles_authors()
    # * Remove Article
    remove_article()
    # * Remove Author
    remove_authors()
    
    text = "line1\nline2"
    path = 'test.txt'
    #write_file(path, text)
    #t = read_file(path)
    #print('text:'+text+'$')
    #print('t:'+t+'$')
    #assert(t==text)
    #assert(t!=text)
    pass

# Run test
if __name__ == '__main__' :
    test_author_crud()
    test_article_crud()
